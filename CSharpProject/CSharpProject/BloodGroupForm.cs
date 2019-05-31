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
    public partial class BloodGroupForm : Form
    {
        private readonly IdentitySearchEntities db;
        BloodGroup selectedBloodGroup;
        BloodGroup checkBloodGroup;
        const string folderForEroor = "seeAllError";
        string pathTxt = Path.Combine(folderForEroor, "error.txt");
        public BloodGroupForm()
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

        void UpdateBloodGroup()
        {
            try
            {
                dgvBloodGroup.DataSource = db.BloodGroups.Where(w => w.DeletedDate == null).Select(s => new
                {
                    s.ID,
                    s.BloodGroup1,

                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }

        private void btnAddNewNationality_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                if (String.IsNullOrEmpty(txtNewBloodGroup.Text))
                {
                    errorProvider1.SetError(txtNewBloodGroup, "Please, fill input!");
                    return;
                }

                BloodGroup newBloodGroup = new BloodGroup
                {
                    BloodGroup1 = txtNewBloodGroup.Text,
                };

                checkBloodGroup = db.BloodGroups.Where(w => w.BloodGroup1 == newBloodGroup.BloodGroup1).FirstOrDefault();
                if (checkBloodGroup == null)
                {
                    db.BloodGroups.Add(newBloodGroup);
                    db.SaveChanges();
                    MessageBox.Show("You added new Nationality");
                    UpdateBloodGroup();
                }

                else
                {
                    MessageBox.Show("This Blood Gorup exists!!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }

        private void BloodGroupForm_Load(object sender, EventArgs e)
        {
            try
            {
                UpdateBloodGroup();
                dgvBloodGroup.Columns["ID"].Visible = false;
                btnDeleteBloodGroup.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }

        private void btnDeleteBloodGroup_Click(object sender, EventArgs e)
        {
            try
            {
                selectedBloodGroup.DeletedDate = DateTime.Now;
                db.SaveChanges();
                UpdateBloodGroup();
                selectedBloodGroup = null;
                btnDeleteBloodGroup.Enabled = false;
                btnAddNewBloodGroup.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }


        }

        private void dgvBloodGroup_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = (int)dgvBloodGroup.Rows[e.RowIndex].Cells[0].Value;
                selectedBloodGroup = db.BloodGroups.Where(w => w.ID == id).FirstOrDefault();
                btnAddNewBloodGroup.Enabled = false;
                btnDeleteBloodGroup.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }

        private void BloodGroupForm_Click(object sender, EventArgs e)
        {
            try
            {
                selectedBloodGroup = null;
                btnAddNewBloodGroup.Enabled = true;
                btnDeleteBloodGroup.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }
    }
}
