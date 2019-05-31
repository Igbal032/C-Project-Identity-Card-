using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpProject.Models;
using CSharpProject.Extention;
using System.IO;

namespace CSharpProject
{
    public partial class AdminPanel : Form
    {
        private readonly IdentitySearchEntities db;
        User user;
        const string folderForError = "seeAllError";
        const string folderForEroor = "seeAllError";
        string pathTxt = Path.Combine(folderForEroor, "error.txt");
        public AdminPanel()
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


        private void btnLogİN_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string eMail = txtEmail.Text.ToLower().Trim();
            string password = txtPassword.Text;
            user = db.Users.Where(w => w.Email == eMail).FirstOrDefault();
            string pathTxt = Path.Combine(folderForError, "error.txt");

            try
            {
                if (user == null)
                {
                    MessageBox.Show("This User doesn't exists");
                }

                else
                {
                    if (String.IsNullOrEmpty(eMail))
                    {
                        errorProvider1.SetError(txtEmail, "Please, fill Email");
                        return;

                    }

                    if (String.IsNullOrEmpty(password))
                    {
                        errorProvider1.SetError(txtPassword, "Please, fill Password");
                        return;
                    }

                    if (eMail != user.Email || Extention.Extention.HashPassword(password) != user.Password)
                    {
                        MessageBox.Show("Email or Password is false");
                        return;
                    }

                    if (Extention.Extention.CheckPassword(password, user.Password) && (eMail == user.Email))
                    {

                        mainForm mainForm = new mainForm(user);
                        mainForm.ShowDialog();
                        txtEmail.Text = "";
                        txtPassword.Text = "";
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
