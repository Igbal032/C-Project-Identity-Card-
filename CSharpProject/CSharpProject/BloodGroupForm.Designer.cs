namespace CSharpProject
{
    partial class BloodGroupForm
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
            this.components = new System.ComponentModel.Container();
            this.grpBloodGroup = new System.Windows.Forms.GroupBox();
            this.dgvBloodGroup = new System.Windows.Forms.DataGridView();
            this.NationalityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteBloodGroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewBloodGroup = new System.Windows.Forms.Button();
            this.txtNewBloodGroup = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBloodGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloodGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBloodGroup
            // 
            this.grpBloodGroup.Controls.Add(this.dgvBloodGroup);
            this.grpBloodGroup.Location = new System.Drawing.Point(24, 86);
            this.grpBloodGroup.Name = "grpBloodGroup";
            this.grpBloodGroup.Size = new System.Drawing.Size(360, 138);
            this.grpBloodGroup.TabIndex = 12;
            this.grpBloodGroup.TabStop = false;
            this.grpBloodGroup.Text = "Blood Group";
            // 
            // dgvBloodGroup
            // 
            this.dgvBloodGroup.AllowUserToAddRows = false;
            this.dgvBloodGroup.AllowUserToDeleteRows = false;
            this.dgvBloodGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBloodGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBloodGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NationalityName});
            this.dgvBloodGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBloodGroup.Location = new System.Drawing.Point(3, 16);
            this.dgvBloodGroup.Name = "dgvBloodGroup";
            this.dgvBloodGroup.ReadOnly = true;
            this.dgvBloodGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBloodGroup.Size = new System.Drawing.Size(354, 119);
            this.dgvBloodGroup.TabIndex = 0;
            this.dgvBloodGroup.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBloodGroup_RowHeaderMouseDoubleClick);
            // 
            // NationalityName
            // 
            this.NationalityName.DataPropertyName = "BloodGroup1";
            this.NationalityName.HeaderText = "Blood Group";
            this.NationalityName.Name = "NationalityName";
            this.NationalityName.ReadOnly = true;
            // 
            // btnDeleteBloodGroup
            // 
            this.btnDeleteBloodGroup.Location = new System.Drawing.Point(192, 52);
            this.btnDeleteBloodGroup.Name = "btnDeleteBloodGroup";
            this.btnDeleteBloodGroup.Size = new System.Drawing.Size(53, 23);
            this.btnDeleteBloodGroup.TabIndex = 11;
            this.btnDeleteBloodGroup.Text = "Delete";
            this.btnDeleteBloodGroup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteBloodGroup.UseVisualStyleBackColor = true;
            this.btnDeleteBloodGroup.Click += new System.EventHandler(this.btnDeleteBloodGroup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Blood Grpup";
            // 
            // btnAddNewBloodGroup
            // 
            this.btnAddNewBloodGroup.Location = new System.Drawing.Point(147, 52);
            this.btnAddNewBloodGroup.Name = "btnAddNewBloodGroup";
            this.btnAddNewBloodGroup.Size = new System.Drawing.Size(39, 23);
            this.btnAddNewBloodGroup.TabIndex = 9;
            this.btnAddNewBloodGroup.Text = "ADD";
            this.btnAddNewBloodGroup.UseVisualStyleBackColor = true;
            this.btnAddNewBloodGroup.Click += new System.EventHandler(this.btnAddNewNationality_Click);
            // 
            // txtNewBloodGroup
            // 
            this.txtNewBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewBloodGroup.Location = new System.Drawing.Point(130, 23);
            this.txtNewBloodGroup.Multiline = true;
            this.txtNewBloodGroup.Name = "txtNewBloodGroup";
            this.txtNewBloodGroup.Size = new System.Drawing.Size(117, 23);
            this.txtNewBloodGroup.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BloodGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 251);
            this.Controls.Add(this.grpBloodGroup);
            this.Controls.Add(this.btnDeleteBloodGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNewBloodGroup);
            this.Controls.Add(this.txtNewBloodGroup);
            this.Name = "BloodGroupForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BloodGroupForm";
            this.Load += new System.EventHandler(this.BloodGroupForm_Load);
            this.Click += new System.EventHandler(this.BloodGroupForm_Click);
            this.grpBloodGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloodGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBloodGroup;
        private System.Windows.Forms.DataGridView dgvBloodGroup;
        private System.Windows.Forms.Button btnDeleteBloodGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewBloodGroup;
        private System.Windows.Forms.TextBox txtNewBloodGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalityName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}