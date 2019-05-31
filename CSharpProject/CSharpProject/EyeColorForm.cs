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
    public partial class AddEyeColor : Form
    {
        private readonly IdentitySearchEntities db;
        EyeColor selectedColor;
        EyeColor checkEyeColor;
        const string folderForEroor = "seeAllError";
        string pathTxt = Path.Combine(folderForEroor, "error.txt");
        public AddEyeColor()
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

        private void addNewColor_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                if (String.IsNullOrEmpty(txtNewColor.Text))
                {
                    errorProvider1.SetError(txtNewColor, "Please, fill input!");
                    return;
                }
                EyeColor newEyeColor = new EyeColor
                {
                    EyeColor1 = txtNewColor.Text,
                };
                checkEyeColor = db.EyeColors.Where(w => w.EyeColor1 == newEyeColor.EyeColor1).FirstOrDefault();
                if (checkEyeColor==null)
                {
                    db.EyeColors.Add(newEyeColor);
                    db.SaveChanges();
                    MessageBox.Show("You added new color");
                    updateColor();
                }
                MessageBox.Show("This Color exists");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }

        void updateColor()
        {
            try
            {
                dgvColorList.DataSource = db.EyeColors.Where(w => w.DeletedDate == null).Select(s => new
                {
                    s.ID,
                    s.EyeColor1,

                }).ToList();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }

        private void AddEyeColor_Load(object sender, EventArgs e)
        {
            try
            {
                updateColor();
                dgvColorList.Columns["ID"].Visible = false;
                btnDeleteColor.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }

        private void dgvColorList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = (int)dgvColorList.Rows[e.RowIndex].Cells[0].Value;
                selectedColor = db.EyeColors.Where(w => w.ID == id).FirstOrDefault();
                btnDeleteColor.Enabled = true;
                addNewColor.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }


        }

        private void btnDeleteColor_Click(object sender, EventArgs e)
        {
            try
            {
                selectedColor.DeletedDate = DateTime.Now;
                db.SaveChanges();
                updateColor();
                btnDeleteColor.Enabled = false;
                addNewColor.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }


        }

        private void AddEyeColor_Click(object sender, EventArgs e)
        {
            try
            {
                selectedColor = null;
                btnDeleteColor.Enabled = false;
                addNewColor.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }
    }
}
