namespace CSharpProject
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSeries = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.grpNameThatGiveID = new System.Windows.Forms.GroupBox();
            this.txtNameThatGiveID = new System.Windows.Forms.TextBox();
            this.txtPersonNumber = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtLivingPlace = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.cmbEyeColor = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbMilitaryStatus = new System.Windows.Forms.ComboBox();
            this.cmbFamilyStatus = new System.Windows.Forms.ComboBox();
            this.cmbNationality = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimeBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtPlaceOfBirth = new System.Windows.Forms.TextBox();
            this.txtPersonFatherName = new System.Windows.Forms.TextBox();
            this.txtPersonSurName = new System.Windows.Forms.TextBox();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimeCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPersonList = new System.Windows.Forms.GroupBox();
            this.dgvPersonList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthOfDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthOfPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BloodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LivingPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EyeGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssuingAuthority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MilitaryStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnReflesh = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.grpNameThatGiveID.SuspendLayout();
            this.grpPersonList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSeries
            // 
            this.txtSeries.Location = new System.Drawing.Point(109, 15);
            this.txtSeries.Multiline = true;
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.Size = new System.Drawing.Size(100, 20);
            this.txtSeries.TabIndex = 87;
            this.txtSeries.TextChanged += new System.EventHandler(this.txtSeries_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(245, 351);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 13);
            this.label18.TabIndex = 86;
            this.label18.Text = "Blood Group :";
            // 
            // grpNameThatGiveID
            // 
            this.grpNameThatGiveID.Controls.Add(this.txtNameThatGiveID);
            this.grpNameThatGiveID.Location = new System.Drawing.Point(24, 421);
            this.grpNameThatGiveID.Name = "grpNameThatGiveID";
            this.grpNameThatGiveID.Size = new System.Drawing.Size(398, 40);
            this.grpNameThatGiveID.TabIndex = 85;
            this.grpNameThatGiveID.TabStop = false;
            this.grpNameThatGiveID.Text = "Name that give ID card ";
            // 
            // txtNameThatGiveID
            // 
            this.txtNameThatGiveID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNameThatGiveID.Location = new System.Drawing.Point(3, 16);
            this.txtNameThatGiveID.Multiline = true;
            this.txtNameThatGiveID.Name = "txtNameThatGiveID";
            this.txtNameThatGiveID.Size = new System.Drawing.Size(392, 21);
            this.txtNameThatGiveID.TabIndex = 43;
            this.txtNameThatGiveID.TextChanged += new System.EventHandler(this.txtNameThatGiveID_TextChanged);
            // 
            // txtPersonNumber
            // 
            this.txtPersonNumber.Location = new System.Drawing.Point(124, 393);
            this.txtPersonNumber.Multiline = true;
            this.txtPersonNumber.Name = "txtPersonNumber";
            this.txtPersonNumber.Size = new System.Drawing.Size(295, 20);
            this.txtPersonNumber.TabIndex = 84;
            this.txtPersonNumber.TextChanged += new System.EventHandler(this.txtPersonNumber_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 400);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 82;
            this.label19.Text = "Number :";
            // 
            // txtLivingPlace
            // 
            this.txtLivingPlace.Location = new System.Drawing.Point(124, 370);
            this.txtLivingPlace.Multiline = true;
            this.txtLivingPlace.Name = "txtLivingPlace";
            this.txtLivingPlace.Size = new System.Drawing.Size(295, 20);
            this.txtLivingPlace.TabIndex = 83;
            this.txtLivingPlace.TextChanged += new System.EventHandler(this.txtLivingPlace_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 377);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 81;
            this.label16.Text = "Living Place";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 400);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 13);
            this.label17.TabIndex = 80;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 351);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 79;
            this.label15.Text = "Eye Color:";
            // 
            // cmbBloodGroup
            // 
            this.cmbBloodGroup.DisplayMember = "Text";
            this.cmbBloodGroup.FormattingEnabled = true;
            this.cmbBloodGroup.Location = new System.Drawing.Point(320, 343);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Size = new System.Drawing.Size(99, 21);
            this.cmbBloodGroup.TabIndex = 78;
            this.cmbBloodGroup.ValueMember = "Value";
            this.cmbBloodGroup.SelectedIndexChanged += new System.EventHandler(this.cmbBloodGroup_SelectedIndexChanged);
            // 
            // cmbEyeColor
            // 
            this.cmbEyeColor.DisplayMember = "ID";
            this.cmbEyeColor.FormattingEnabled = true;
            this.cmbEyeColor.Location = new System.Drawing.Point(124, 343);
            this.cmbEyeColor.Name = "cmbEyeColor";
            this.cmbEyeColor.Size = new System.Drawing.Size(99, 21);
            this.cmbEyeColor.TabIndex = 77;
            this.cmbEyeColor.ValueMember = "ID";
            this.cmbEyeColor.SelectedIndexChanged += new System.EventHandler(this.cmbEyeColor_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 325);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 76;
            this.label14.Text = "Military Status:";
            // 
            // cmbMilitaryStatus
            // 
            this.cmbMilitaryStatus.DisplayMember = "Text";
            this.cmbMilitaryStatus.FormattingEnabled = true;
            this.cmbMilitaryStatus.Location = new System.Drawing.Point(124, 317);
            this.cmbMilitaryStatus.Name = "cmbMilitaryStatus";
            this.cmbMilitaryStatus.Size = new System.Drawing.Size(295, 21);
            this.cmbMilitaryStatus.TabIndex = 75;
            this.cmbMilitaryStatus.ValueMember = "Value";
            this.cmbMilitaryStatus.SelectedIndexChanged += new System.EventHandler(this.cmbMilitaryStatus_SelectedIndexChanged);
            // 
            // cmbFamilyStatus
            // 
            this.cmbFamilyStatus.DisplayMember = "Text";
            this.cmbFamilyStatus.FormattingEnabled = true;
            this.cmbFamilyStatus.Location = new System.Drawing.Point(124, 293);
            this.cmbFamilyStatus.Name = "cmbFamilyStatus";
            this.cmbFamilyStatus.Size = new System.Drawing.Size(99, 21);
            this.cmbFamilyStatus.TabIndex = 73;
            this.cmbFamilyStatus.ValueMember = "Value";
            this.cmbFamilyStatus.SelectedIndexChanged += new System.EventHandler(this.cmbFamilyStatus_SelectedIndexChanged);
            // 
            // cmbNationality
            // 
            this.cmbNationality.DisplayMember = "Text";
            this.cmbNationality.FormattingEnabled = true;
            this.cmbNationality.Location = new System.Drawing.Point(124, 269);
            this.cmbNationality.Name = "cmbNationality";
            this.cmbNationality.Size = new System.Drawing.Size(295, 21);
            this.cmbNationality.TabIndex = 72;
            this.cmbNationality.ValueMember = "Value";
            this.cmbNationality.SelectedIndexChanged += new System.EventHandler(this.cmbNationality_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(318, 301);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 70;
            this.label13.Text = "Height :";
            // 
            // cmbGender
            // 
            this.cmbGender.DisplayMember = "Text";
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(298, 247);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 21);
            this.cmbGender.TabIndex = 71;
            this.cmbGender.ValueMember = "Value";
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(250, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 69;
            this.label10.Text = "Gender :";
            // 
            // dateTimeBirthDate
            // 
            this.dateTimeBirthDate.Checked = false;
            this.dateTimeBirthDate.CustomFormat = "dd.MM.yyyy";
            this.dateTimeBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeBirthDate.Location = new System.Drawing.Point(124, 248);
            this.dateTimeBirthDate.MaxDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.dateTimeBirthDate.Name = "dateTimeBirthDate";
            this.dateTimeBirthDate.ShowCheckBox = true;
            this.dateTimeBirthDate.Size = new System.Drawing.Size(78, 20);
            this.dateTimeBirthDate.TabIndex = 68;
            this.dateTimeBirthDate.Value = new System.DateTime(2019, 4, 3, 0, 0, 0, 0);
            this.dateTimeBirthDate.ValueChanged += new System.EventHandler(this.dateTimeBirthDate_ValueChanged);
            // 
            // txtPlaceOfBirth
            // 
            this.txtPlaceOfBirth.Location = new System.Drawing.Point(124, 225);
            this.txtPlaceOfBirth.Multiline = true;
            this.txtPlaceOfBirth.Name = "txtPlaceOfBirth";
            this.txtPlaceOfBirth.Size = new System.Drawing.Size(295, 20);
            this.txtPlaceOfBirth.TabIndex = 67;
            this.txtPlaceOfBirth.TextChanged += new System.EventHandler(this.txtPlaceOfBirth_TextChanged);
            // 
            // txtPersonFatherName
            // 
            this.txtPersonFatherName.Location = new System.Drawing.Point(124, 202);
            this.txtPersonFatherName.Multiline = true;
            this.txtPersonFatherName.Name = "txtPersonFatherName";
            this.txtPersonFatherName.Size = new System.Drawing.Size(295, 20);
            this.txtPersonFatherName.TabIndex = 66;
            this.txtPersonFatherName.TextChanged += new System.EventHandler(this.txtPersonFatherName_TextChanged);
            // 
            // txtPersonSurName
            // 
            this.txtPersonSurName.Location = new System.Drawing.Point(124, 179);
            this.txtPersonSurName.Multiline = true;
            this.txtPersonSurName.Name = "txtPersonSurName";
            this.txtPersonSurName.Size = new System.Drawing.Size(295, 20);
            this.txtPersonSurName.TabIndex = 65;
            this.txtPersonSurName.TextChanged += new System.EventHandler(this.txtPersonSurName_TextChanged);
            // 
            // txtPersonName
            // 
            this.txtPersonName.Location = new System.Drawing.Point(124, 157);
            this.txtPersonName.Multiline = true;
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(295, 20);
            this.txtPersonName.TabIndex = 64;
            this.txtPersonName.TextChanged += new System.EventHandler(this.txtPersonName_TextChanged_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 63;
            this.label12.Text = "Family Status:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 62;
            this.label11.Text = "Nationality:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = "Birth date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Place of birth:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Father\'s Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "End Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Created Date:";
            // 
            // dateTimeEndDate
            // 
            this.dateTimeEndDate.Checked = false;
            this.dateTimeEndDate.CustomFormat = "dd.MM.yyyy";
            this.dateTimeEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEndDate.Location = new System.Drawing.Point(96, 118);
            this.dateTimeEndDate.Name = "dateTimeEndDate";
            this.dateTimeEndDate.ShowCheckBox = true;
            this.dateTimeEndDate.Size = new System.Drawing.Size(88, 20);
            this.dateTimeEndDate.TabIndex = 53;
            this.dateTimeEndDate.ValueChanged += new System.EventHandler(this.dateTimeEndDate_ValueChanged);
            // 
            // dateTimeCreatedDate
            // 
            this.dateTimeCreatedDate.Checked = false;
            this.dateTimeCreatedDate.CustomFormat = "dd.MM.yyyy";
            this.dateTimeCreatedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeCreatedDate.Location = new System.Drawing.Point(96, 92);
            this.dateTimeCreatedDate.MinDate = new System.DateTime(2019, 4, 7, 0, 0, 0, 0);
            this.dateTimeCreatedDate.Name = "dateTimeCreatedDate";
            this.dateTimeCreatedDate.ShowCheckBox = true;
            this.dateTimeCreatedDate.Size = new System.Drawing.Size(88, 20);
            this.dateTimeCreatedDate.TabIndex = 52;
            this.dateTimeCreatedDate.ValueChanged += new System.EventHandler(this.dateTimeCreatedDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Seriya AZE N° ";
            // 
            // grpPersonList
            // 
            this.grpPersonList.Controls.Add(this.dgvPersonList);
            this.grpPersonList.Controls.Add(this.btnEdit);
            this.grpPersonList.Location = new System.Drawing.Point(428, 31);
            this.grpPersonList.Name = "grpPersonList";
            this.grpPersonList.Size = new System.Drawing.Size(616, 405);
            this.grpPersonList.TabIndex = 88;
            this.grpPersonList.TabStop = false;
            this.grpPersonList.Text = "Person Information";
            // 
            // dgvPersonList
            // 
            this.dgvPersonList.AllowUserToAddRows = false;
            this.dgvPersonList.AllowUserToDeleteRows = false;
            this.dgvPersonList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Series,
            this.FLF,
            this.BirthOfDate,
            this.BirthOfPlace,
            this.Height,
            this.BloodGroup,
            this.Nationality,
            this.LivingPlace,
            this.EyeGroup,
            this.FamilyStatus,
            this.Gender,
            this.Number,
            this.IssuingAuthority,
            this.MilitaryStatus,
            this.IssueDate,
            this.ExpiryDate});
            this.dgvPersonList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonList.Location = new System.Drawing.Point(3, 16);
            this.dgvPersonList.Name = "dgvPersonList";
            this.dgvPersonList.ReadOnly = true;
            this.dgvPersonList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonList.Size = new System.Drawing.Size(610, 386);
            this.dgvPersonList.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 422.1742F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 50;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 50;
            // 
            // Series
            // 
            this.Series.DataPropertyName = "Series";
            this.Series.HeaderText = "Series";
            this.Series.MinimumWidth = 70;
            this.Series.Name = "Series";
            this.Series.ReadOnly = true;
            // 
            // FLF
            // 
            this.FLF.DataPropertyName = "FLF";
            this.FLF.FillWeight = 462.9441F;
            this.FLF.HeaderText = "FLF";
            this.FLF.MinimumWidth = 120;
            this.FLF.Name = "FLF";
            this.FLF.ReadOnly = true;
            // 
            // BirthOfDate
            // 
            this.BirthOfDate.DataPropertyName = "BirthOfDate";
            this.BirthOfDate.FillWeight = 51.06298F;
            this.BirthOfDate.HeaderText = "Birth Of Date";
            this.BirthOfDate.MinimumWidth = 70;
            this.BirthOfDate.Name = "BirthOfDate";
            this.BirthOfDate.ReadOnly = true;
            // 
            // BirthOfPlace
            // 
            this.BirthOfPlace.DataPropertyName = "BirthOfPlace";
            this.BirthOfPlace.FillWeight = 51.06298F;
            this.BirthOfPlace.HeaderText = "Birth Of Place";
            this.BirthOfPlace.MinimumWidth = 70;
            this.BirthOfPlace.Name = "BirthOfPlace";
            this.BirthOfPlace.ReadOnly = true;
            // 
            // Height
            // 
            this.Height.DataPropertyName = "Height";
            this.Height.FillWeight = 51.06298F;
            this.Height.HeaderText = "Height";
            this.Height.MinimumWidth = 70;
            this.Height.Name = "Height";
            this.Height.ReadOnly = true;
            // 
            // BloodGroup
            // 
            this.BloodGroup.DataPropertyName = "BloodGroup";
            this.BloodGroup.HeaderText = "BloodGroup";
            this.BloodGroup.MinimumWidth = 70;
            this.BloodGroup.Name = "BloodGroup";
            this.BloodGroup.ReadOnly = true;
            // 
            // Nationality
            // 
            this.Nationality.DataPropertyName = "NationalityName";
            this.Nationality.FillWeight = 51.06298F;
            this.Nationality.HeaderText = "Ntionality";
            this.Nationality.MinimumWidth = 70;
            this.Nationality.Name = "Nationality";
            this.Nationality.ReadOnly = true;
            // 
            // LivingPlace
            // 
            this.LivingPlace.DataPropertyName = "LivingPlace";
            this.LivingPlace.FillWeight = 51.06298F;
            this.LivingPlace.HeaderText = "Living Place";
            this.LivingPlace.MinimumWidth = 70;
            this.LivingPlace.Name = "LivingPlace";
            this.LivingPlace.ReadOnly = true;
            // 
            // EyeGroup
            // 
            this.EyeGroup.DataPropertyName = "EyeColor";
            this.EyeGroup.FillWeight = 51.06298F;
            this.EyeGroup.HeaderText = "Eye Group";
            this.EyeGroup.MinimumWidth = 70;
            this.EyeGroup.Name = "EyeGroup";
            this.EyeGroup.ReadOnly = true;
            // 
            // FamilyStatus
            // 
            this.FamilyStatus.DataPropertyName = "FamilyStatus";
            this.FamilyStatus.FillWeight = 51.06298F;
            this.FamilyStatus.HeaderText = "Family Status";
            this.FamilyStatus.MinimumWidth = 70;
            this.FamilyStatus.Name = "FamilyStatus";
            this.FamilyStatus.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "GenderName";
            this.Gender.FillWeight = 51.06298F;
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 70;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.FillWeight = 51.06298F;
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 90;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // IssuingAuthority
            // 
            this.IssuingAuthority.DataPropertyName = "IssuingAuthority";
            this.IssuingAuthority.HeaderText = "Issuing Authority";
            this.IssuingAuthority.MinimumWidth = 70;
            this.IssuingAuthority.Name = "IssuingAuthority";
            this.IssuingAuthority.ReadOnly = true;
            // 
            // MilitaryStatus
            // 
            this.MilitaryStatus.DataPropertyName = "MilitaryStatus";
            this.MilitaryStatus.FillWeight = 51.06298F;
            this.MilitaryStatus.HeaderText = "MilitaryStatus";
            this.MilitaryStatus.MinimumWidth = 70;
            this.MilitaryStatus.Name = "MilitaryStatus";
            this.MilitaryStatus.ReadOnly = true;
            // 
            // IssueDate
            // 
            this.IssueDate.DataPropertyName = "IssueDate";
            this.IssueDate.FillWeight = 51.06298F;
            this.IssueDate.HeaderText = "IssueDate";
            this.IssueDate.MinimumWidth = 70;
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.ReadOnly = true;
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.DataPropertyName = "ExpiryDate";
            this.ExpiryDate.FillWeight = 51.06298F;
            this.ExpiryDate.HeaderText = "ExpiryDate";
            this.ExpiryDate.MinimumWidth = 70;
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.ReadOnly = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(404, 267);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 36);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnReflesh
            // 
            this.btnReflesh.Location = new System.Drawing.Point(347, 47);
            this.btnReflesh.Name = "btnReflesh";
            this.btnReflesh.Size = new System.Drawing.Size(75, 33);
            this.btnReflesh.TabIndex = 89;
            this.btnReflesh.Text = "Reflesh";
            this.btnReflesh.UseVisualStyleBackColor = true;
            this.btnReflesh.Click += new System.EventHandler(this.btnReflesh_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(369, 296);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown1.TabIndex = 90;
            this.numericUpDown1.Value = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 467);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnReflesh);
            this.Controls.Add(this.grpPersonList);
            this.Controls.Add(this.txtSeries);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.grpNameThatGiveID);
            this.Controls.Add(this.txtPersonNumber);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtLivingPlace);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbBloodGroup);
            this.Controls.Add(this.cmbEyeColor);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbMilitaryStatus);
            this.Controls.Add(this.cmbFamilyStatus);
            this.Controls.Add(this.cmbNationality);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimeBirthDate);
            this.Controls.Add(this.txtPlaceOfBirth);
            this.Controls.Add(this.txtPersonFatherName);
            this.Controls.Add(this.txtPersonSurName);
            this.Controls.Add(this.txtPersonName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeEndDate);
            this.Controls.Add(this.dateTimeCreatedDate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.grpNameThatGiveID.ResumeLayout(false);
            this.grpNameThatGiveID.PerformLayout();
            this.grpPersonList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSeries;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox grpNameThatGiveID;
        private System.Windows.Forms.TextBox txtNameThatGiveID;
        private System.Windows.Forms.TextBox txtPersonNumber;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtLivingPlace;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.ComboBox cmbEyeColor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbMilitaryStatus;
        private System.Windows.Forms.ComboBox cmbFamilyStatus;
        private System.Windows.Forms.ComboBox cmbNationality;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimeBirthDate;
        private System.Windows.Forms.TextBox txtPlaceOfBirth;
        private System.Windows.Forms.TextBox txtPersonFatherName;
        private System.Windows.Forms.TextBox txtPersonSurName;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeEndDate;
        private System.Windows.Forms.DateTimePicker dateTimeCreatedDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpPersonList;
        private System.Windows.Forms.DataGridView dgvPersonList;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnReflesh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Series;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLF;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthOfDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthOfPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloodGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn LivingPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn EyeGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssuingAuthority;
        private System.Windows.Forms.DataGridViewTextBoxColumn MilitaryStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}