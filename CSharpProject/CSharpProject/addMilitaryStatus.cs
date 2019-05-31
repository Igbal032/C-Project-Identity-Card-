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
    public partial class addMilitaryStatus : Form
    {
        private readonly IdentitySearchEntities db;
        MilitaryStatuss selectedMilitaryStatus;
        const string folderForEroor = "seeAllError";
        string pathTxt = Path.Combine(folderForEroor, "error.txt");
        MilitaryStatuss checkMilitary;
        public addMilitaryStatus()
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

        private void btnAddNewMilitaryStatus_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                if (String.IsNullOrEmpty(txtNewMilitaryStatus.Text))
                {
                    errorProvider1.SetError(txtNewMilitaryStatus, "Please, fill input!");
                    return;
                }
                MilitaryStatuss newMilitaryStatus = new MilitaryStatuss
                {
                    MilitaryStatus = txtNewMilitaryStatus.Text,
                };
                checkMilitary = db.MilitaryStatusses.Where(w => w.MilitaryStatus == newMilitaryStatus.MilitaryStatus).FirstOrDefault();
                if (checkMilitary == null)
                {
                    db.MilitaryStatusses.Add(newMilitaryStatus);
                    db.SaveChanges();
                    MessageBox.Show("You added new Military Status");
                    UpdateMilitaryStatusLIst();
                }
                else
                {
                    MessageBox.Show("This Military Status exists!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }

        void UpdateMilitaryStatusLIst()
        {
            try
            {
                dgvMilitaryStatus.DataSource = db.MilitaryStatusses.Where(w => w.DeletedDate == null).Select(s => new
                {
                    s.ID,
                    s.MilitaryStatus,
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }
        private void addMilitaryStatus_Load(object sender, EventArgs e)
        {
            try
            {
                UpdateMilitaryStatusLIst();
                btnDeleteMs.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }


        }

        private void dgvMilitaryStatus_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = (int)dgvMilitaryStatus.Rows[e.RowIndex].Cells[0].Value;
                selectedMilitaryStatus = db.MilitaryStatusses.Where(w => w.ID == id).FirstOrDefault();
                btnDeleteMs.Enabled = true;
                btnAddNewMilitaryStatus.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }

        private void btnDeleteMs_Click(object sender, EventArgs e)
        {
            try
            {
                selectedMilitaryStatus.DeletedDate = DateTime.Now;
                db.SaveChanges();
                UpdateMilitaryStatusLIst();
                selectedMilitaryStatus = null;
                btnDeleteMs.Enabled = false;
                btnAddNewMilitaryStatus.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }



        }

        private void txtNewMilitaryStatus_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                btnDeleteMs.Enabled = false;
                btnAddNewMilitaryStatus.Enabled = true;
                selectedMilitaryStatus = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }
    }
}
