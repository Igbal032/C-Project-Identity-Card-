namespace CSharpProject
{
    partial class FamilyStatusForm
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
            this.grpFamilyStatus = new System.Windows.Forms.GroupBox();
            this.dgvFamilyStatus = new System.Windows.Forms.DataGridView();
            this.FamilyStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteFamilyStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewFamilyStatus = new System.Windows.Forms.Button();
            this.txtNewFamilyStatus = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpFamilyStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilyStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFamilyStatus
            // 
            this.grpFamilyStatus.Controls.Add(this.dgvFamilyStatus);
            this.grpFamilyStatus.Location = new System.Drawing.Point(23, 81);
            this.grpFamilyStatus.Name = "grpFamilyStatus";
            this.grpFamilyStatus.Size = new System.Drawing.Size(360, 138);
            this.grpFamilyStatus.TabIndex = 12;
            this.grpFamilyStatus.TabStop = false;
            this.grpFamilyStatus.Text = "FamilyStatus";
            // 
            // dgvFamilyStatus
            // 
            this.dgvFamilyStatus.AllowUserToAddRows = false;
            this.dgvFamilyStatus.AllowUserToDeleteRows = false;
            this.dgvFamilyStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFamilyStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamilyStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FamilyStatusName});
            this.dgvFamilyStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFamilyStatus.Location = new System.Drawing.Point(3, 16);
            this.dgvFamilyStatus.Name = "dgvFamilyStatus";
            this.dgvFamilyStatus.ReadOnly = true;
            this.dgvFamilyStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFamilyStatus.Size = new System.Drawing.Size(354, 119);
            this.dgvFamilyStatus.TabIndex = 0;
            this.dgvFamilyStatus.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFamilyStatus_RowHeaderMouseDoubleClick);
            // 
            // FamilyStatusName
            // 
            this.FamilyStatusName.DataPropertyName = "FamilyStatus";
            this.FamilyStatusName.HeaderText = "Family Status";
            this.FamilyStatusName.Name = "FamilyStatusName";
            this.FamilyStatusName.ReadOnly = true;
            // 
            // btnDeleteFamilyStatus
            // 
            this.btnDeleteFamilyStatus.Location = new System.Drawing.Point(195, 50);
            this.btnDeleteFamilyStatus.Name = "btnDeleteFamilyStatus";
            this.btnDeleteFamilyStatus.Size = new System.Drawing.Size(53, 23);
            this.btnDeleteFamilyStatus.TabIndex = 11;
            this.btnDeleteFamilyStatus.Text = "Delete";
            this.btnDeleteFamilyStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteFamilyStatus.UseVisualStyleBackColor = true;
            this.btnDeleteFamilyStatus.Click += new System.EventHandler(this.btnDeleteFamilyStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Family Status";
            // 
            // btnAddNewFamilyStatus
            // 
            this.btnAddNewFamilyStatus.Location = new System.Drawing.Point(150, 50);
            this.btnAddNewFamilyStatus.Name = "btnAddNewFamilyStatus";
            this.btnAddNewFamilyStatus.Size = new System.Drawing.Size(39, 23);
            this.btnAddNewFamilyStatus.TabIndex = 9;
            this.btnAddNewFamilyStatus.Text = "ADD";
            this.btnAddNewFamilyStatus.UseVisualStyleBackColor = true;
            this.btnAddNewFamilyStatus.Click += new System.EventHandler(this.btnAddNewFamilyStatus_Click);
            // 
            // txtNewFamilyStatus
            // 
            this.txtNewFamilyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewFamilyStatus.Location = new System.Drawing.Point(131, 21);
            this.txtNewFamilyStatus.Multiline = true;
            this.txtNewFamilyStatus.Name = "txtNewFamilyStatus";
            this.txtNewFamilyStatus.Size = new System.Drawing.Size(117, 23);
            this.txtNewFamilyStatus.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FamilyStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 232);
            this.Controls.Add(this.grpFamilyStatus);
            this.Controls.Add(this.btnDeleteFamilyStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNewFamilyStatus);
            this.Controls.Add(this.txtNewFamilyStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FamilyStatusForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FamilyStatus";
            this.Load += new System.EventHandler(this.FamilyStatusForm_Load);
            this.Click += new System.EventHandler(this.FamilyStatusForm_Click);
            this.grpFamilyStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilyStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFamilyStatus;
        private System.Windows.Forms.DataGridView dgvFamilyStatus;
        private System.Windows.Forms.Button btnDeleteFamilyStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewFamilyStatus;
        private System.Windows.Forms.TextBox txtNewFamilyStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyStatusName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}