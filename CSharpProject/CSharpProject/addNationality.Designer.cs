namespace CSharpProject
{
    partial class addNationality
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewNationality = new System.Windows.Forms.Button();
            this.txtNewNationality = new System.Windows.Forms.TextBox();
            this.btnDeleteNationality = new System.Windows.Forms.Button();
            this.grpNationality = new System.Windows.Forms.GroupBox();
            this.dgvNationality = new System.Windows.Forms.DataGridView();
            this.NationalityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpNationality.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNationality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nationality";
            // 
            // btnAddNewNationality
            // 
            this.btnAddNewNationality.Location = new System.Drawing.Point(120, 59);
            this.btnAddNewNationality.Name = "btnAddNewNationality";
            this.btnAddNewNationality.Size = new System.Drawing.Size(39, 23);
            this.btnAddNewNationality.TabIndex = 4;
            this.btnAddNewNationality.Text = "ADD";
            this.btnAddNewNationality.UseVisualStyleBackColor = true;
            this.btnAddNewNationality.Click += new System.EventHandler(this.btnAddNewNationality_Click);
            // 
            // txtNewNationality
            // 
            this.txtNewNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewNationality.Location = new System.Drawing.Point(101, 30);
            this.txtNewNationality.Multiline = true;
            this.txtNewNationality.Name = "txtNewNationality";
            this.txtNewNationality.Size = new System.Drawing.Size(117, 23);
            this.txtNewNationality.TabIndex = 3;
            // 
            // btnDeleteNationality
            // 
            this.btnDeleteNationality.Location = new System.Drawing.Point(165, 59);
            this.btnDeleteNationality.Name = "btnDeleteNationality";
            this.btnDeleteNationality.Size = new System.Drawing.Size(53, 23);
            this.btnDeleteNationality.TabIndex = 6;
            this.btnDeleteNationality.Text = "Delete";
            this.btnDeleteNationality.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteNationality.UseVisualStyleBackColor = true;
            this.btnDeleteNationality.Click += new System.EventHandler(this.btnDeleteNationality_Click);
            // 
            // grpNationality
            // 
            this.grpNationality.Controls.Add(this.dgvNationality);
            this.grpNationality.Location = new System.Drawing.Point(12, 93);
            this.grpNationality.Name = "grpNationality";
            this.grpNationality.Size = new System.Drawing.Size(360, 138);
            this.grpNationality.TabIndex = 7;
            this.grpNationality.TabStop = false;
            this.grpNationality.Text = "Nationality";
            // 
            // dgvNationality
            // 
            this.dgvNationality.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNationality.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNationality.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NationalityName});
            this.dgvNationality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNationality.Location = new System.Drawing.Point(3, 16);
            this.dgvNationality.Name = "dgvNationality";
            this.dgvNationality.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNationality.Size = new System.Drawing.Size(354, 119);
            this.dgvNationality.TabIndex = 0;
            this.dgvNationality.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNationality_RowHeaderMouseDoubleClick);
            // 
            // NationalityName
            // 
            this.NationalityName.DataPropertyName = "NationalityName";
            this.NationalityName.HeaderText = "Nationality";
            this.NationalityName.Name = "NationalityName";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // addNationality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 243);
            this.Controls.Add(this.grpNationality);
            this.Controls.Add(this.btnDeleteNationality);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNewNationality);
            this.Controls.Add(this.txtNewNationality);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addNationality";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nationality";
            this.Load += new System.EventHandler(this.addNationality_Load);
            this.Click += new System.EventHandler(this.addNationality_Click);
            this.grpNationality.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNationality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewNationality;
        private System.Windows.Forms.TextBox txtNewNationality;
        private System.Windows.Forms.Button btnDeleteNationality;
        private System.Windows.Forms.GroupBox grpNationality;
        private System.Windows.Forms.DataGridView dgvNationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalityName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}