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
    public partial class FamilyStatusForm : Form
    {
        private readonly IdentitySearchEntities db;
        FamilyStatu selectedFamilyStatus;
        FamilyStatu checkFamilyStatus;
        const string folderForEroor = "seeAllError";
        string pathTxt = Path.Combine(folderForEroor, "error.txt");
        public FamilyStatusForm()
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

        void updateFamilyStatus()
        {
            try
            {
                dgvFamilyStatus.DataSource = db.FamilyStatus.Where(w => w.DeletedDate == null).Select(s => new
                {

                    s.ID,
                    s.FamilyStatus,

                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }
        private void FamilyStatusForm_Load(object sender, EventArgs e)
        {
            try
            {
                updateFamilyStatus();
                dgvFamilyStatus.Columns["ID"].Visible = false;
                btnDeleteFamilyStatus.Enabled = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }


        }
        private void btnAddNewFamilyStatus_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                if (String.IsNullOrEmpty(txtNewFamilyStatus.Text))
                {
                    errorProvider1.SetError(txtNewFamilyStatus, "Please, fill input!");
                    return;
                }
                FamilyStatu newFamilyStatus = new FamilyStatu
                {
                    FamilyStatus = txtNewFamilyStatus.Text,
                };
                checkFamilyStatus = db.FamilyStatus.Where(w => w.FamilyStatus == newFamilyStatus.FamilyStatus).FirstOrDefault();
                if (checkFamilyStatus == null)
                {
                    db.FamilyStatus.Add(newFamilyStatus);
                    db.SaveChanges();
                    MessageBox.Show("You added new Family Status");
                    updateFamilyStatus();
                }
                else
                {
                    MessageBox.Show("This Family Status exists!!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }



        }

        private void dgvFamilyStatus_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = (int)dgvFamilyStatus.Rows[e.RowIndex].Cells[0].Value;
                selectedFamilyStatus = db.FamilyStatus.Where(w => w.ID == id).FirstOrDefault();
                btnDeleteFamilyStatus.Enabled = true;
                btnAddNewFamilyStatus.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }


        }

        private void btnDeleteFamilyStatus_Click(object sender, EventArgs e)
        {

            try
            {
                selectedFamilyStatus.DeletedDate = DateTime.Now;
                db.SaveChanges();
                updateFamilyStatus();
                selectedFamilyStatus = null;
                btnAddNewFamilyStatus.Enabled = true;
                btnDeleteFamilyStatus.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }


        }

        private void FamilyStatusForm_Click(object sender, EventArgs e)
        {
            try
            {
                selectedFamilyStatus = null;
                btnDeleteFamilyStatus.Enabled = false;
                btnAddNewFamilyStatus.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);

            }

        }
    }
}
