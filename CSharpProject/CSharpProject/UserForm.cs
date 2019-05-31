using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpProject.Models;


namespace CSharpProject
{
    public partial class UserForm : Form
    {
        private readonly IdentitySearchEntities db;
        User selectedUser;
        User checkUser;
        const string folderForEroor = "seeAllError";
        string pathTxt = Path.Combine(folderForEroor, "error.txt");
        public UserForm()
        {
            try
            {
                db = new IdentitySearchEntities();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

            InitializeComponent();
        }

        void updateUserList()
        {
            try
            {
                dgvUser.DataSource = db.Users.Where(w => w.DeletedDate == null).Select(s => new
                {
                    s.ID,
                    s.Email,
                    s.Role.RoleName,
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            try
            {
                cmbRoles.DataSource = db.Roles.Where(w => w.DeletedDate == null).Select(s => new ComboItem
                {

                    value = s.ID,
                    Text = s.RoleName,

                }).ToList();
                updateUserList();
                dgvUser.Columns["ID"].Visible = false;
                btnDeleteUser.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }


        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                ComboItem selectedRole = cmbRoles.SelectedItem as ComboItem;

                if (String.IsNullOrEmpty(txtNewEmail.Text))
                {
                    errorProvider1.SetError(txtNewEmail, "Fill, Email");
                }
                if (String.IsNullOrEmpty(txtNewPassword.Text))
                {
                    errorProvider1.SetError(txtNewPassword, "Fill, Password");
                    return;
                }

                User newUser = new User
                {
                    Email = txtNewEmail.Text.ToLower().Trim(),
                    RoleID = selectedRole.value,
                    Password = Extention.Extention.HashPassword(txtNewPassword.Text),
                };
                checkUser = db.Users.Where(w => w.Email == txtNewEmail.Text).FirstOrDefault();
                if (checkUser == null)
                {
                    db.Users.Add(newUser);
                    db.SaveChanges();
                    updateUserList();
                }
                else
                {
                    MessageBox.Show("User has already existed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }


        }
        private void dgvUser_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            try
            {
                int id = (int)dgvUser.Rows[e.RowIndex].Cells[0].Value;
                selectedUser = db.Users.Where(w => w.ID == id).FirstOrDefault();
                btnDeleteUser.Enabled = true;
                btnAddUser.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

            try
            {
                selectedUser.DeletedDate = DateTime.Now;
                db.SaveChanges();
                updateUserList();
                selectedUser = null;
                btnAddUser.Enabled = true;
                btnDeleteUser.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }

        private void UserForm_Click(object sender, EventArgs e)
        {
            try
            {
                selectedUser = null;
                btnAddUser.Enabled = true;
                btnDeleteUser.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }
    }


}

