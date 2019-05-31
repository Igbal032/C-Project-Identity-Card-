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
    public partial class addNationality : Form
    {
        private readonly IdentitySearchEntities db;
        Nationality selectedNationality;
        Nationality checkNationality;
        const string folderForEroor = "seeAllError";
        string pathTxt = Path.Combine(folderForEroor, "error.txt");

        public addNationality()
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

        private void btnAddNewNationality_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                if (String.IsNullOrEmpty(txtNewNationality.Text))
                {
                    errorProvider1.SetError(txtNewNationality, "Please, fill input!");
                    return;
                }
                Nationality NewNationality = new Nationality
                {
                    NationalityName = txtNewNationality.Text,
                };
                checkNationality = db.Nationalitys.Where(w => w.NationalityName == NewNationality.NationalityName).FirstOrDefault();
                if (checkNationality == null)
                {
                    db.Nationalitys.Add(NewNationality);
                    db.SaveChanges();
                    MessageBox.Show("You added new Nationality");
                    UpdateNationality();
                }
                else
                {
                    MessageBox.Show("This Nationality exists!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }

        void UpdateNationality()
        {
            try
            {
                dgvNationality.DataSource = db.Nationalitys.Where(w => w.DeletedTime == null).Select(s => new
                {
                    s.ID,
                    s.NationalityName,

                }).ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }

        private void addNationality_Load(object sender, EventArgs e)
        {
            try
            {
                UpdateNationality();
                dgvNationality.Columns["ID"].Visible = false;
                btnDeleteNationality.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }


        }

        private void dgvNationality_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = (int)dgvNationality.Rows[e.RowIndex].Cells[0].Value;
                selectedNationality = db.Nationalitys.Where(w => w.ID == id).FirstOrDefault();
                btnAddNewNationality.Enabled = false;
                btnDeleteNationality.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }
        private void btnDeleteNationality_Click(object sender, EventArgs e)
        {
            try
            {
                selectedNationality.DeletedTime = DateTime.Now;
                db.SaveChanges();
                UpdateNationality();
                selectedNationality = null;
                btnDeleteNationality.Enabled = false;
                btnAddNewNationality.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }

        private void addNationality_Click(object sender, EventArgs e)
        {
            try
            {
                selectedNationality = null;
                btnAddNewNationality.Enabled = true;
                btnDeleteNationality.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }
    }

}

