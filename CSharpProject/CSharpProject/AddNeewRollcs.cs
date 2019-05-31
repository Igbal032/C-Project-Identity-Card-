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
    public partial class AddNeewRollcs : Form
    {
        private readonly IdentitySearchEntities db;
        Role selectedRole;
        Role checkRole;
        const string folderForEroor = "seeAllError";
        string pathTxt = Path.Combine(folderForEroor, "error.txt");
        public AddNeewRollcs()
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

        void updateRoleList()
        {
            try
            {
                dgvRolls.DataSource = db.Roles.Where(w => w.DeletedDate == null).Select(s => new
                {
                    s.ID,
                    s.RoleName,
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }
        private void AddNeewRollcs_Load(object sender, EventArgs e)
        {
            try
            {
                updateRoleList();
                dgvRolls.Columns["ID"].Visible = false;
                btnDeleteRoll.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }
        }

        private void btnAddRoll_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                if (String.IsNullOrEmpty(txtNewRoll.Text))
                {
                    errorProvider1.SetError(txtNewRoll, "Please, fill input!");
                    return;
                }

                Role newRole = new Role
                {
                    RoleName = txtNewRoll.Text,
                };

                checkRole = db.Roles.Where(w => w.RoleName == newRole.RoleName).FirstOrDefault();
                if (checkRole == null)
                {
                    db.Roles.Add(newRole);
                    db.SaveChanges();
                    MessageBox.Show("You added new Role");
                    updateRoleList();
                }
                else
                {
                    MessageBox.Show("This Role exists!!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }
        }



        private void dgvRolls_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = (int)dgvRolls.Rows[e.RowIndex].Cells[0].Value;
                selectedRole = db.Roles.Where(w => w.ID == id).FirstOrDefault();
                btnAddRoll.Enabled = false;
                btnDeleteRoll.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }

        private void btnDeleteRoll_Click(object sender, EventArgs e)
        {
            try
            {
                selectedRole.DeletedDate = DateTime.Now;
                db.SaveChanges();
                updateRoleList();
                selectedRole = null;
                btnDeleteRoll.Enabled = false;
                btnAddRoll.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }
        }

        private void AddNeewRollcs_Click(object sender, EventArgs e)
        {
            try
            {
                selectedRole = null;
                btnDeleteRoll.Enabled = false;
                btnAddRoll.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }
    }
}
