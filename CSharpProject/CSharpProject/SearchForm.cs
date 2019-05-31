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
    public partial class SearchForm : Form
    {
        private readonly IdentitySearchEntities db;
        const string folderForEroor = "seeAllError";
        string pathTxt = Path.Combine(folderForEroor, "error.txt");
        List<Person> person;

        public SearchForm()
        {
            try
            {
                db = new IdentitySearchEntities();
                Directory.CreateDirectory(folderForEroor);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }
            InitializeComponent();

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


        private void SearchForm_Load(object sender, EventArgs e)
        {
            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, check again after some minutes!! ");
                File.AppendAllText(pathTxt, "\n" + ex + ":" + DateTime.Now);
            }


        }

        private void txtSeries_TextChanged(object sender, EventArgs e)
        {
            if (dgvPersonList.Rows.Count == 0)
            {
                person = db.Persons.Where(w => w.Series.Contains(txtSeries.Text)).ToList();
                dgvPersonList.DataSource = person.Select(s => new
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
            else
            {
                dgvPersonList.DataSource = person.Where(w => w.Series.Contains(txtSeries.Text)).Select(s => new
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
        }

        private void txtPersonName_TextChanged_1(object sender, EventArgs e)
        {
            if (dgvPersonList.Rows.Count == 0)
            {
                person = db.Persons.Where(w => w.FirstName.Contains(txtPersonName.Text)).ToList();
                dgvPersonList.DataSource = person.Select(s => new
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

            else
            {
                dgvPersonList.DataSource = person.Where(w => w.FirstName.Contains(txtPersonName.Text)).Select(s => new
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
        }

        private void txtPersonSurName_TextChanged(object sender, EventArgs e)
        {
            if (dgvPersonList.Rows.Count == 0)
            {
                person = db.Persons.Where(w => w.LastName.Contains(txtPersonSurName.Text)).ToList();
                dgvPersonList.DataSource = person.Select(s => new
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

            else
            {
                dgvPersonList.DataSource = person.Where(w => w.LastName.Contains(txtPersonSurName.Text)).Select(s => new
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
        }

        private void txtPersonFatherName_TextChanged(object sender, EventArgs e)
        {
            if (dgvPersonList.Rows.Count == 0)
            {
                person = db.Persons.Where(w => w.FatherName.Contains(txtPersonFatherName.Text)).ToList();
                dgvPersonList.DataSource = person.Select(s => new
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

            else
            {
                dgvPersonList.DataSource = person.Where(w => w.FatherName.Contains(txtPersonFatherName.Text)).Select(s => new
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
        }

        private void txtPlaceOfBirth_TextChanged(object sender, EventArgs e)
        {
            if (dgvPersonList.Rows.Count == 0)
            {
                person = db.Persons.Where(w => w.BirthOfPlace.Contains(txtPlaceOfBirth.Text)).ToList();
                dgvPersonList.DataSource = person.Select(s => new
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

            else
            {
                dgvPersonList.DataSource = person.Where(w => w.BirthOfPlace.Contains(txtPlaceOfBirth.Text)).Select(s => new
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
        }

        private void txtLivingPlace_TextChanged(object sender, EventArgs e)
        {
            if (dgvPersonList.Rows.Count == 0)
            {
                person = db.Persons.Where(w => w.LivingPlace.Contains(txtLivingPlace.Text)).ToList();
                dgvPersonList.DataSource = person.Select(s => new
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

            else
            {
                dgvPersonList.DataSource = person.Where(w => w.LivingPlace.Contains(txtLivingPlace.Text)).Select(s => new
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
        }

        private void txtPersonNumber_TextChanged(object sender, EventArgs e)
        {
            if (dgvPersonList.Rows.Count == 0)
            {
                person = db.Persons.Where(w => w.Number.Contains(txtPersonNumber.Text)).ToList();
                dgvPersonList.DataSource = person.Select(s => new
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

            else
            {
                dgvPersonList.DataSource = person.Where(w => w.Number.Contains(txtPersonNumber.Text)).Select(s => new
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
        }

        private void txtNameThatGiveID_TextChanged(object sender, EventArgs e)
        {
            if (dgvPersonList.Rows.Count == 0)
            {
                person = db.Persons.Where(w => w.IssuingAuthority.Contains(txtNameThatGiveID.Text)).ToList();
                dgvPersonList.DataSource = person.Select(s => new
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

            else
            {
                dgvPersonList.DataSource = person.Where(w => w.IssuingAuthority.Contains(txtNameThatGiveID.Text)).Select(s => new
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
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem gender = cmbGender.SelectedItem as ComboItem;
            if (dgvPersonList.Rows.Count == 0)
            {
                person = db.Persons.Where(w => w.Gender.GenderName == gender.Text).ToList();
                dgvPersonList.DataSource = person.Select(s => new
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
                    s.MilitaryStatuss.MilitaryStatus,
                    s.IssueDate,
                    s.ExpiryDate,

                }).ToList();
            }

            else
            {
                dgvPersonList.DataSource = person.Where(w => w.Gender.GenderName == gender.Text).Select(s => new
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
                    s.MilitaryStatuss.MilitaryStatus,
                    s.IssueDate,
                    s.ExpiryDate,

                }).ToList();
            }
        }

        private void cmbNationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem Nationality = cmbNationality.SelectedItem as ComboItem;
            if (dgvPersonList.Rows.Count == 0)
            {
                person = db.Persons.Where(w => w.Nationality.NationalityName == Nationality.Text).ToList();
                dgvPersonList.DataSource = person.Select(s => new
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
                    s.MilitaryStatuss.MilitaryStatus,
                    s.IssueDate,
                    s.ExpiryDate,

                }).ToList();
            }

            else
            {
                dgvPersonList.DataSource = person.Where(w => w.Nationality.NationalityName == Nationality.Text).Select(s => new
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
                    s.MilitaryStatuss.MilitaryStatus,
                    s.IssueDate,
                    s.ExpiryDate,

                }).ToList();
            }
        }

        private void cmbFamilyStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem familyStatus = cmbFamilyStatus.SelectedItem as ComboItem;
            if (dgvPersonList.Rows.Count == 0)
            {
                person = db.Persons.Where(w => w.FamilyStatu.FamilyStatus == familyStatus.Text).ToList();
                dgvPersonList.DataSource = person.Select(s => new
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
                    s.MilitaryStatuss.MilitaryStatus,
                    s.IssueDate,
                    s.ExpiryDate,

                }).ToList();
            }

            else
            {
                dgvPersonList.DataSource = person.Where(w => w.FamilyStatu.FamilyStatus == familyStatus.Text).Select(s => new
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
                    s.MilitaryStatuss.MilitaryStatus,
                    s.IssueDate,
                    s.ExpiryDate,

                }).ToList();
            }
        }

        private void cmbMilitaryStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem MilitaryStatus = cmbMilitaryStatus.SelectedItem as ComboItem;
            if (dgvPersonList.Rows.Count == 0)
            {
                person = db.Persons.Where(w => w.MilitaryStatuss.MilitaryStatus == MilitaryStatus.Text).ToList();
                dgvPersonList.DataSource = person.Select(s => new
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
                    s.MilitaryStatuss.MilitaryStatus,
                    s.IssueDate,
                    s.ExpiryDate,

                }).ToList();
            }

            else
            {
                dgvPersonList.DataSource = person.Where(w => w.MilitaryStatuss.MilitaryStatus == MilitaryStatus.Text).Select(s => new
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
                    s.MilitaryStatuss.MilitaryStatus,
                    s.IssueDate,
                    s.ExpiryDate,

                }).ToList();
            }
        }

        private void cmbEyeColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem eyeColor = cmbEyeColor.SelectedItem as ComboItem;
            if (dgvPersonList.Rows.Count == 0)
            {
                person = db.Persons.Where(w => w.EyeColor.EyeColor1 == eyeColor.Text).ToList();
                dgvPersonList.DataSource = person.Select(s => new
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
                    s.MilitaryStatuss.MilitaryStatus,
                    s.IssueDate,
                    s.ExpiryDate,

                }).ToList();
            }

            else
            {
                dgvPersonList.DataSource = person.Where(w => w.EyeColor.EyeColor1 == eyeColor.Text).Select(s => new
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
                    s.MilitaryStatuss.MilitaryStatus,
                    s.IssueDate,
                    s.ExpiryDate,

                }).ToList();
            }
        }

        private void cmbBloodGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem blood = cmbBloodGroup.SelectedItem as ComboItem;
            if (dgvPersonList.Rows.Count == 0)
            {
                person = db.Persons.Where(w => w.BloodGroup.BloodGroup1 == blood.Text).ToList();
                dgvPersonList.DataSource = person.Select(s => new
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
                    s.MilitaryStatuss.MilitaryStatus,
                    s.IssueDate,
                    s.ExpiryDate,

                }).ToList();
            }

            else
            {
                dgvPersonList.DataSource = person.Where(w => w.BloodGroup.BloodGroup1 == blood.Text).Select(s => new
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
                    s.MilitaryStatuss.MilitaryStatus,
                    s.IssueDate,
                    s.ExpiryDate,

                }).ToList();
            }
        }

        private void dateTimeBirthDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimeBirthDate.Value.Date;
            if (dgvPersonList.Rows.Count == 0)
            {
                person = db.Persons.Where(w => w.BirthOfDate.Value == date).ToList();
                dgvPersonList.DataSource = person.Select(s => new
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
                    s.MilitaryStatuss.MilitaryStatus,
                    s.IssueDate,
                    s.ExpiryDate,

                }).ToList();
            }

            else
            {
                dgvPersonList.DataSource = person.Where(w => w.BirthOfDate.Value == date).Select(s => new
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
                    s.MilitaryStatuss.MilitaryStatus,
                    s.IssueDate,
                    s.ExpiryDate,

                }).ToList();
            }
        }

        private void dateTimeCreatedDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateCreate = dateTimeCreatedDate.Value.Date;
            if (dgvPersonList.Rows.Count == 0)
            {
                person = db.Persons.Where(w => w.IssueDate.Value == dateCreate).ToList();
                dgvPersonList.DataSource = person.Select(s => new
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
                    s.MilitaryStatuss.MilitaryStatus,
                    s.IssueDate,
                    s.ExpiryDate,

                }).ToList();
            }

            else
            {
                dgvPersonList.DataSource = person.Where(w => w.IssueDate.Value == dateCreate).Select(s => new
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
                    s.MilitaryStatuss.MilitaryStatus,
                    s.IssueDate,
                    s.ExpiryDate,

                }).ToList();
            }
        }

        private void dateTimeEndDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateEnd = dateTimeCreatedDate.Value.Date;
            if (dgvPersonList.Rows.Count == 0)
            {
                person = db.Persons.Where(w => w.ExpiryDate.Value == dateEnd).ToList();
                dgvPersonList.DataSource = person.Select(s => new
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
                    s.MilitaryStatuss.MilitaryStatus,
                    s.IssueDate,
                    s.ExpiryDate,

                }).ToList();
            }

            else
            {
                dgvPersonList.DataSource = person.Where(w => w.ExpiryDate.Value == dateEnd).Select(s => new
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
                    s.MilitaryStatuss.MilitaryStatus,
                    s.IssueDate,
                    s.ExpiryDate,

                }).ToList();
            }
        }

        private void btnReflesh_Click(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            if (dgvPersonList.Rows.Count == 0)
            {
                person = db.Persons.Where(w => w.Height.Value == numericUpDown1.Value).ToList();
                dgvPersonList.DataSource = person.Select(s => new
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
                    s.MilitaryStatuss.MilitaryStatus,
                    s.IssueDate,
                    s.ExpiryDate,

                }).ToList();
            }

            else
            {
                dgvPersonList.DataSource = person.Where(w => w.Height.Value == numericUpDown1.Value).Select(s => new
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
                    s.MilitaryStatuss.MilitaryStatus,
                    s.IssueDate,
                    s.ExpiryDate,

                }).ToList();
            }
        }
    }
}
