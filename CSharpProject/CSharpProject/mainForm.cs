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
    public partial class mainForm : Form
    {
        const string folder = "img";
        const string folderForEroor = "seeAllError";
        private readonly IdentitySearchEntities db;
        Person selectedPerson;
        Person enteredRowPerson;
        User myUsers;
        Person checkedPerson;
        string pathTxt = Path.Combine(folderForEroor, "error.txt");

        public mainForm(User user)
        {
            try
            {
                db = new IdentitySearchEntities();
                Directory.CreateDirectory(folder);
                Directory.CreateDirectory(folderForEroor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }
            InitializeComponent();
            myUsers = user;

        }

        void updateGrid()
        {
            try
            {
                dgvPersonList.DataSource = db.Persons.Where(w => w.DeletedDate == null).Select(s => new
                {
                    s.ID,
                    s.Series,
                    FLF = s.FirstName + " " + s.LastName + " " + s.FatherName,
                    s.BirthOfDate,
                    s.BirthOfPlace,
                    s.Height,
                    s.Nationality.NationalityName,
                    s.LivingPlace,
                    BloodGroup = s.BloodGroup.BloodGroup1,
                    EyeColor = s.EyeColor.EyeColor1,
                    s.FamilyStatu.FamilyStatus,
                    s.Gender.GenderName,
                    s.Number,
                    s.IssuingAuthority,
                    s.MilitaryStatuss.MilitaryStatus,
                    s.IssueDate,
                    s.ExpiryDate,
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }
        private void mainForm_Load(object sender, EventArgs e)
        {

            try
            {
                btnCleaninpit_Click(null, null);
                btnDelete.Enabled = false;
                btnEditt.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;

                dgvPersonList.Columns["ID"].Visible = false;

                if (myUsers.RoleID > 1)
                {
                    btnDelete.Enabled = false;
                    catalogToolStripMenuItem.Enabled = false;
                    positionToolStripMenuItem.Enabled = false;
                }
                cmbBloodGroup.DataSource = db.BloodGroups.Where(w => w.DeletedDate == null).Select(s => new ComboItem
                {
                    value = s.ID,
                    Text = s.BloodGroup1,
                }).ToList();

                cmbEyeColor.DataSource = db.EyeColors.Where(w => w.DeletedDate == null).Select(s => new ComboItem
                {
                    value = s.ID,
                    Text = s.EyeColor1,
                }).ToList();

                cmbFamilyStatus.DataSource = db.FamilyStatus.Where(w => w.DeletedDate == null).Select(s => new ComboItem
                {
                    value = s.ID,
                    Text = s.FamilyStatus,
                }).ToList();

                cmbGender.DataSource = db.Genders.Where(w => w.DeletedDate == null).Select(s => new ComboItem
                {
                    value = s.ID,
                    Text = s.GenderName,
                }).ToList();

                cmbMilitaryStatus.DataSource = db.MilitaryStatusses.Where(w => w.DeletedDate == null).Select(s => new ComboItem
                {
                    value = s.ID,
                    Text = s.MilitaryStatus,
                }).ToList();

                cmbNationality.DataSource = db.Nationalitys.Where(w => w.DeletedTime == null).Select(s => new ComboItem
                {
                    value = s.ID,
                    Text = s.NationalityName,
                }).ToList();

                updateGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }
        private void dgvPersonList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            try
            {
                int id = (int)dgvPersonList.Rows[e.RowIndex].Cells[0].Value;
                selectedPerson = db.Persons.Where(w => w.ID == id).FirstOrDefault();

                txtSeries.Text = selectedPerson.Series;
                txtPersonName.Text = selectedPerson.FirstName;
                txtPersonSurName.Text = selectedPerson.LastName;
                txtPersonFatherName.Text = selectedPerson.FatherName;
                txtPersonNumber.Text = selectedPerson.Number;
                txtPlaceOfBirth.Text = selectedPerson.BirthOfPlace;
                txtNameThatGiveID.Text = selectedPerson.IssuingAuthority;
                txtLivingPlace.Text = selectedPerson.LivingPlace;
                dateTimeBirthDate.Value = (DateTime)selectedPerson.BirthOfDate;
                dateTimeEndDate.Value = (DateTime)selectedPerson.ExpiryDate;
                dateTimeCreatedDate.Value = (DateTime)selectedPerson.IssueDate;
                cmbBloodGroup.SelectedValue = selectedPerson.BloodGroupID;
                cmbFamilyStatus.SelectedValue = selectedPerson.FamilyStatusID;
                cmbGender.SelectedValue = selectedPerson.GenderID;
                nHeight.Value = (byte)selectedPerson.Height;
                cmbEyeColor.SelectedValue = selectedPerson.EyeColorID;
                cmbMilitaryStatus.SelectedValue = selectedPerson.MilitaryStatusID;
                cmbNationality.SelectedValue = selectedPerson.NationalityID;
                string pathImage = Path.Combine(folder, selectedPerson.ID + ".jpg");
                imgBox.Image = Image.FromFile(pathImage);

                if (myUsers.RoleID > 1)
                {
                    btnDelete.Enabled = false;
                    deleteToolStripMenuItem.Enabled = false;
                    btnEditt.Enabled = true;
                    editToolStripMenuItem.Enabled = true;
                    btnNew.Enabled = false;
                    addToolStripMenuItem.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnNew.Enabled = false;
                    btnEditt.Enabled = true;
                    addToolStripMenuItem.Enabled = false;
                    editToolStripMenuItem.Enabled = true;
                    deleteToolStripMenuItem.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();

                if (
            String.IsNullOrEmpty(txtSeries.Text)
            || String.IsNullOrEmpty(txtPersonName.Text)
            || String.IsNullOrEmpty(txtPersonSurName.Text)
            || String.IsNullOrEmpty(txtPersonFatherName.Text)
            || String.IsNullOrEmpty(txtPlaceOfBirth.Text)
            || String.IsNullOrEmpty(txtPersonNumber.Text)
            || String.IsNullOrEmpty(txtLivingPlace.Text)
            || String.IsNullOrEmpty(txtNameThatGiveID.Text)
            || !dateTimeBirthDate.Checked
            || !dateTimeCreatedDate.Checked
            || !dateTimeEndDate.Checked
            )
                {
                    if (String.IsNullOrEmpty(txtSeries.Text))
                    {
                        errorProvider1.SetError(txtSeries, "Please, fill Series");
                    }

                    if (String.IsNullOrEmpty(txtPersonName.Text))
                    {
                        errorProvider1.SetError(txtPersonName, "Please, fill Name");
                    }
                    if (String.IsNullOrEmpty(txtPersonSurName.Text))
                    {
                        errorProvider1.SetError(txtPersonSurName, "Please, fill Surname");
                    }
                    if (String.IsNullOrEmpty(txtPersonFatherName.Text))
                    {
                        errorProvider1.SetError(txtPersonFatherName, "Please, fill Father Name");
                    }
                    if (String.IsNullOrEmpty(txtPlaceOfBirth.Text))
                    {
                        errorProvider1.SetError(txtPlaceOfBirth, "Please, fill Birth of Place");
                    }
                    if (String.IsNullOrEmpty(txtPersonNumber.Text))
                    {
                        errorProvider1.SetError(txtPersonNumber, "Please, fill Number");
                    }
                    if (String.IsNullOrEmpty(txtLivingPlace.Text))
                    {
                        errorProvider1.SetError(txtLivingPlace, "Please, fill Living Place");
                    }
                    if (String.IsNullOrEmpty(txtNameThatGiveID.Text))
                    {
                        errorProvider1.SetError(txtNameThatGiveID, "Please, fill Issuing Authority");
                    }
                    if (!dateTimeBirthDate.Checked)
                    {
                        errorProvider1.SetError(dateTimeBirthDate, "Please, check Bith Date");
                    }

                    if (!dateTimeCreatedDate.Checked)
                    {
                        errorProvider1.SetError(dateTimeCreatedDate, "Please, check Issue Date");
                    }

                    if (!dateTimeEndDate.Checked)
                    {
                        errorProvider1.SetError(dateTimeEndDate, "Please, check Expiry Date Date");

                    }
                    return;
                }

                if (imgBox.Image == null)
                {
                    MessageBox.Show("Please, submit image!!");
                    return;
                }

                ComboItem selectedEyeColor = cmbEyeColor.SelectedItem as ComboItem;
                ComboItem selectedBloodGroup = cmbBloodGroup.SelectedItem as ComboItem;
                ComboItem selectedMilitarySatatus = cmbMilitaryStatus.SelectedItem as ComboItem;
                ComboItem selectedFamilyStatus = cmbFamilyStatus.SelectedItem as ComboItem;
                ComboItem selectedNationality = cmbNationality.SelectedItem as ComboItem;
                ComboItem selectedGender = cmbGender.SelectedItem as ComboItem;


                Person newPerson = new Person
                {
                    Series = txtSeries.Text,
                    FirstName = txtPersonName.Text,
                    LastName = txtPersonSurName.Text,
                    FatherName = txtPersonFatherName.Text,
                    BirthOfDate = dateTimeBirthDate.Value,
                    BirthOfPlace = txtPlaceOfBirth.Text,
                    EyeColorID = selectedEyeColor.value,
                    BloodGroupID = selectedBloodGroup.value,
                    FamilyStatusID = selectedFamilyStatus.value,
                    GenderID = selectedGender.value,
                    LivingPlace = txtLivingPlace.Text,
                    NationalityID = selectedNationality.value,
                    Number = txtPersonNumber.Text,
                    MilitaryStatusID = selectedMilitarySatatus.value,
                    Height = (byte)nHeight.Value,
                    IssuingAuthority = txtNameThatGiveID.Text,
                    IssueDate = dateTimeCreatedDate.Value,
                    ExpiryDate = dateTimeEndDate.Value,
                };
                checkedPerson = db.Persons.Where(w => w.Series == newPerson.Series).FirstOrDefault();
                if (checkedPerson == null)
                {
                    db.Persons.Add(newPerson);
                    db.SaveChanges();
                    string pathImage = Path.Combine(folder, newPerson.ID + ".jpg");
                    imgBox.Image.Save(pathImage);
                    updateGrid();
                    
                }
                else
                {
                    MessageBox.Show("This person exists!!, Please check again");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("A problem occured, Please, try after some minutes");
                File.AppendAllText(pathTxt, "\n" + ex + " : " + DateTime.Now);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                selectedPerson.DeletedDate = DateTime.Now;
                db.SaveChanges();
                updateGrid();
                selectedPerson = null;
                btnDelete.Enabled = false;
                btnEditt.Enabled = false;
                btnNew.Enabled = true;
                deleteToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                addToolStripMenuItem.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }
        private void btnEditt_Click(object sender, EventArgs e)
        {
            try
            {

                errorProvider1.Clear();

                if (
            String.IsNullOrEmpty(txtSeries.Text)
            || String.IsNullOrEmpty(txtPersonName.Text)
            || String.IsNullOrEmpty(txtPersonSurName.Text)
            || String.IsNullOrEmpty(txtPersonFatherName.Text)
            || String.IsNullOrEmpty(txtPlaceOfBirth.Text)
            || String.IsNullOrEmpty(txtPersonNumber.Text)
            || String.IsNullOrEmpty(txtLivingPlace.Text)
            || String.IsNullOrEmpty(txtNameThatGiveID.Text)
            || !dateTimeBirthDate.Checked
            || !dateTimeCreatedDate.Checked
            || !dateTimeEndDate.Checked
            )
                {
                    if (String.IsNullOrEmpty(txtSeries.Text))
                    {
                        errorProvider1.SetError(txtSeries, "Please, fill Series");
                    }

                    if (String.IsNullOrEmpty(txtPersonName.Text))
                    {
                        errorProvider1.SetError(txtPersonName, "Please, fill Name");
                    }
                    if (String.IsNullOrEmpty(txtPersonSurName.Text))
                    {
                        errorProvider1.SetError(txtPersonSurName, "Please, fill Surname");
                    }
                    if (String.IsNullOrEmpty(txtPersonFatherName.Text))
                    {
                        errorProvider1.SetError(txtPersonFatherName, "Please, fill Father Name");
                    }
                    if (String.IsNullOrEmpty(txtPlaceOfBirth.Text))
                    {
                        errorProvider1.SetError(txtPlaceOfBirth, "Please, fill Birth of Place");
                    }
                    if (String.IsNullOrEmpty(txtPersonNumber.Text))
                    {
                        errorProvider1.SetError(txtPersonNumber, "Please, fill Number");
                    }
                    if (String.IsNullOrEmpty(txtLivingPlace.Text))
                    {
                        errorProvider1.SetError(txtLivingPlace, "Please, fill Living Place");
                    }
                    if (String.IsNullOrEmpty(txtNameThatGiveID.Text))
                    {
                        errorProvider1.SetError(txtNameThatGiveID, "Please, fill Issuing Authority");
                    }
                    if (!dateTimeBirthDate.Checked)
                    {
                        errorProvider1.SetError(dateTimeBirthDate, "Please, check Bith Date");
                    }

                    if (!dateTimeCreatedDate.Checked)
                    {
                        errorProvider1.SetError(dateTimeCreatedDate, "Please, check Issue Date");
                    }

                    if (!dateTimeEndDate.Checked)
                    {
                        errorProvider1.SetError(dateTimeEndDate, "Please, check Expiry Date Date");

                    }
                    return;
                }

                ComboItem selectedEyeColor = cmbEyeColor.SelectedItem as ComboItem;
                ComboItem selectedBloodGroup = cmbBloodGroup.SelectedItem as ComboItem;
                ComboItem selectedMilitarySatatus = cmbMilitaryStatus.SelectedItem as ComboItem;
                ComboItem selectedFamilyStatus = cmbFamilyStatus.SelectedItem as ComboItem;
                ComboItem selectedNationality = cmbNationality.SelectedItem as ComboItem;
                ComboItem selectedGender = cmbGender.SelectedItem as ComboItem;

                selectedPerson.Series = txtSeries.Text;
                selectedPerson.FirstName = txtPersonName.Text;
                selectedPerson.LastName = txtPersonSurName.Text;
                selectedPerson.FatherName = txtPersonFatherName.Text;
                selectedPerson.BirthOfDate = dateTimeBirthDate.Value;
                selectedPerson.BirthOfPlace = txtPlaceOfBirth.Text;
                selectedPerson.EyeColorID = selectedEyeColor.value;
                selectedPerson.BloodGroupID = selectedBloodGroup.value;
                selectedPerson.FamilyStatusID = selectedFamilyStatus.value;
                selectedPerson.GenderID = selectedGender.value;
                selectedPerson.LivingPlace = txtLivingPlace.Text;
                selectedPerson.NationalityID = selectedNationality.value;
                selectedPerson.MilitaryStatusID = selectedMilitarySatatus.value;
                selectedPerson.Height = (byte)nHeight.Value;  // ERROR
                selectedPerson.IssuingAuthority = txtNameThatGiveID.Text;
                selectedPerson.IssueDate = dateTimeCreatedDate.Value;
                selectedPerson.Number = txtPersonNumber.Text;
                selectedPerson.ExpiryDate = dateTimeEndDate.Value;
                selectedPerson.Number = txtPersonNumber.Text;

                db.SaveChanges();
                updateGrid();
                selectedPerson = null;
                btnNew.Enabled = true;
                btnEditt.Enabled = false;
                btnDelete.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                addToolStripMenuItem.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please, try again!!");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            try
            {
                var result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    imgBox.Image = Image.FromFile(openFileDialog.FileName);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            try
            {
                imgBox.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);

            }

        }

        private void eyeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEyeColor newEyeColor = new AddEyeColor();
            newEyeColor.ShowDialog();
        }

        private void militaryStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addMilitaryStatus newMilitarityStatus = new addMilitaryStatus();
            newMilitarityStatus.ShowDialog();
        }

        private void nationalityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addNationality newNationality = new addNationality();
            newNationality.ShowDialog();

        }

        private void familyStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FamilyStatusForm familyStatusForm = new FamilyStatusForm();
            familyStatusForm.ShowDialog();
        }

        private void rollsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNeewRollcs roleForm = new AddNeewRollcs();
            UserForm userForm = new UserForm();
            roleForm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                btnNew_Click(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                btnEditt_Click(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }

        private void dgvPersonList_Click(object sender, EventArgs e)
        {
            try
            {
                btnDelete.Enabled = false;
                btnEditt.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                addToolStripMenuItem.Enabled = true;
                btnNew.Enabled = true;
                selectedPerson = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }

        private void bloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BloodGroupForm bloodGroupMain = new BloodGroupForm();
                bloodGroupMain.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);

            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                btnDelete_Click(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonList.CurrentRow == null) return;
                if (dgvPersonList.CurrentRow.Index + 1 <= dgvPersonList.Rows.Count - 1)
                {
                    dgvPersonList.CurrentCell = dgvPersonList.Rows[dgvPersonList.CurrentRow.Index + 1].Cells[1];
                    dgvPersonList.Rows[dgvPersonList.CurrentCell.RowIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);

            }

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonList.CurrentRow == null) return;
                if (dgvPersonList.CurrentRow.Index - 1 >= 0)
                {

                    dgvPersonList.CurrentCell = dgvPersonList.Rows[dgvPersonList.CurrentRow.Index - 1].Cells[1];
                    dgvPersonList.Rows[dgvPersonList.CurrentCell.RowIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);

            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                searchToolStripMenuItem_Click(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }


        }
        private void btnRefleshList_Click(object sender, EventArgs e)
        {
            try
            {
                updateGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }

        private void btnCleaninpit_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                txtPersonFatherName.Text = "";
                txtPersonName.Text = "";
                txtPersonSurName.Text = "";
                txtLivingPlace.Text = "";
                txtNameThatGiveID.Text = "";
                txtSeries.Text = "";
                txtPlaceOfBirth.Text = "";
                nHeight.Value = 0;
                txtPersonNumber.Text = "";
                dateTimeBirthDate.Checked = false;
                dateTimeEndDate.Checked = false;
                dateTimeCreatedDate.Checked = false;
                imgBox.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }

        }
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm src = new SearchForm();
            src.ShowDialog();
        }

        private void dgvPersonList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dgvPersonList.Rows[e.RowIndex].Cells[0].Value;
                enteredRowPerson = db.Persons.Where(w => w.ID == id).FirstOrDefault();

                txtSeries.Text = enteredRowPerson.Series;
                txtPersonName.Text = enteredRowPerson.FirstName;
                txtPersonSurName.Text = enteredRowPerson.LastName;
                txtPersonFatherName.Text = enteredRowPerson.FatherName;
                txtPersonNumber.Text = enteredRowPerson.Number;
                txtPlaceOfBirth.Text = enteredRowPerson.BirthOfPlace;
                txtNameThatGiveID.Text = enteredRowPerson.IssuingAuthority;
                txtLivingPlace.Text = enteredRowPerson.LivingPlace;
                dateTimeBirthDate.Value = (DateTime)enteredRowPerson.BirthOfDate;
                dateTimeEndDate.Value = (DateTime)enteredRowPerson.ExpiryDate;
                dateTimeCreatedDate.Value = (DateTime)enteredRowPerson.IssueDate;
                cmbBloodGroup.SelectedValue = enteredRowPerson.BloodGroupID;
                cmbFamilyStatus.SelectedValue = enteredRowPerson.FamilyStatusID;
                nHeight.Value = (byte)enteredRowPerson.Height;
                cmbEyeColor.SelectedValue = enteredRowPerson.EyeColorID;
                cmbGender.SelectedValue = enteredRowPerson.GenderID;
                cmbMilitaryStatus.SelectedValue = enteredRowPerson.MilitaryStatusID;
                cmbNationality.SelectedValue = enteredRowPerson.NationalityID;
                string pathImage = Path.Combine(folder, enteredRowPerson.ID + ".jpg");
                imgBox.Image = Image.FromFile(pathImage);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);

            }

        }

        
    }
}

