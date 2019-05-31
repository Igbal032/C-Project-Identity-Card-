namespace CSharpProject
{
    partial class AddNeewRollcs
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
            this.grpRolls = new System.Windows.Forms.GroupBox();
            this.dgvRolls = new System.Windows.Forms.DataGridView();
            this.NationalityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteRoll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddRoll = new System.Windows.Forms.Button();
            this.txtNewRoll = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpRolls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRolls
            // 
            this.grpRolls.Controls.Add(this.dgvRolls);
            this.grpRolls.Location = new System.Drawing.Point(41, 123);
            this.grpRolls.Name = "grpRolls";
            this.grpRolls.Size = new System.Drawing.Size(360, 138);
            this.grpRolls.TabIndex = 12;
            this.grpRolls.TabStop = false;
            this.grpRolls.Text = "Rolls";
            // 
            // dgvRolls
            // 
            this.dgvRolls.AllowUserToAddRows = false;
            this.dgvRolls.AllowUserToDeleteRows = false;
            this.dgvRolls.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRolls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRolls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NationalityName});
            this.dgvRolls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRolls.Location = new System.Drawing.Point(3, 16);
            this.dgvRolls.Name = "dgvRolls";
            this.dgvRolls.ReadOnly = true;
            this.dgvRolls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRolls.Size = new System.Drawing.Size(354, 119);
            this.dgvRolls.TabIndex = 0;
            this.dgvRolls.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRolls_RowHeaderMouseDoubleClick);
            // 
            // NationalityName
            // 
            this.NationalityName.DataPropertyName = "RoleName";
            this.NationalityName.HeaderText = "Role Name";
            this.NationalityName.Name = "NationalityName";
            this.NationalityName.ReadOnly = true;
            // 
            // btnDeleteRoll
            // 
            this.btnDeleteRoll.Location = new System.Drawing.Point(151, 63);
            this.btnDeleteRoll.Name = "btnDeleteRoll";
            this.btnDeleteRoll.Size = new System.Drawing.Size(53, 23);
            this.btnDeleteRoll.TabIndex = 11;
            this.btnDeleteRoll.Text = "Delete";
            this.btnDeleteRoll.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteRoll.UseVisualStyleBackColor = true;
            this.btnDeleteRoll.Click += new System.EventHandler(this.btnDeleteRoll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Role :";
            // 
            // btnAddRoll
            // 
            this.btnAddRoll.Location = new System.Drawing.Point(106, 63);
            this.btnAddRoll.Name = "btnAddRoll";
            this.btnAddRoll.Size = new System.Drawing.Size(39, 23);
            this.btnAddRoll.TabIndex = 9;
            this.btnAddRoll.Text = "ADD";
            this.btnAddRoll.UseVisualStyleBackColor = true;
            this.btnAddRoll.Click += new System.EventHandler(this.btnAddRoll_Click);
            // 
            // txtNewRoll
            // 
            this.txtNewRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewRoll.Location = new System.Drawing.Point(87, 34);
            this.txtNewRoll.Multiline = true;
            this.txtNewRoll.Name = "txtNewRoll";
            this.txtNewRoll.Size = new System.Drawing.Size(117, 23);
            this.txtNewRoll.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddNeewRollcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 277);
            this.Controls.Add(this.grpRolls);
            this.Controls.Add(this.btnDeleteRoll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddRoll);
            this.Controls.Add(this.txtNewRoll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNeewRollcs";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNeewRollcs";
            this.Load += new System.EventHandler(this.AddNeewRollcs_Load);
            this.Click += new System.EventHandler(this.AddNeewRollcs_Click);
            this.grpRolls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRolls;
        private System.Windows.Forms.DataGridView dgvRolls;
        private System.Windows.Forms.Button btnDeleteRoll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddRoll;
        private System.Windows.Forms.TextBox txtNewRoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalityName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}