namespace CSharpProject
{
    partial class addMilitaryStatus
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
            this.btnAddNewMilitaryStatus = new System.Windows.Forms.Button();
            this.txtNewMilitaryStatus = new System.Windows.Forms.TextBox();
            this.btnDeleteMs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMilitaryStatus = new System.Windows.Forms.DataGridView();
            this.MilitaryStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMilitaryStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Military Status :";
            // 
            // btnAddNewMilitaryStatus
            // 
            this.btnAddNewMilitaryStatus.Location = new System.Drawing.Point(167, 48);
            this.btnAddNewMilitaryStatus.Name = "btnAddNewMilitaryStatus";
            this.btnAddNewMilitaryStatus.Size = new System.Drawing.Size(41, 21);
            this.btnAddNewMilitaryStatus.TabIndex = 4;
            this.btnAddNewMilitaryStatus.Text = "ADD";
            this.btnAddNewMilitaryStatus.UseVisualStyleBackColor = true;
            this.btnAddNewMilitaryStatus.Click += new System.EventHandler(this.btnAddNewMilitaryStatus_Click);
            // 
            // txtNewMilitaryStatus
            // 
            this.txtNewMilitaryStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewMilitaryStatus.Location = new System.Drawing.Point(139, 12);
            this.txtNewMilitaryStatus.Multiline = true;
            this.txtNewMilitaryStatus.Name = "txtNewMilitaryStatus";
            this.txtNewMilitaryStatus.Size = new System.Drawing.Size(123, 30);
            this.txtNewMilitaryStatus.TabIndex = 3;
            this.txtNewMilitaryStatus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNewMilitaryStatus_MouseClick);
            // 
            // btnDeleteMs
            // 
            this.btnDeleteMs.Location = new System.Drawing.Point(214, 48);
            this.btnDeleteMs.Name = "btnDeleteMs";
            this.btnDeleteMs.Size = new System.Drawing.Size(48, 21);
            this.btnDeleteMs.TabIndex = 6;
            this.btnDeleteMs.Text = "Delete";
            this.btnDeleteMs.UseVisualStyleBackColor = true;
            this.btnDeleteMs.Click += new System.EventHandler(this.btnDeleteMs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMilitaryStatus);
            this.groupBox1.Location = new System.Drawing.Point(16, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 152);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Military Status";
            // 
            // dgvMilitaryStatus
            // 
            this.dgvMilitaryStatus.AllowUserToAddRows = false;
            this.dgvMilitaryStatus.AllowUserToDeleteRows = false;
            this.dgvMilitaryStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMilitaryStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMilitaryStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MilitaryStatus});
            this.dgvMilitaryStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMilitaryStatus.Location = new System.Drawing.Point(3, 16);
            this.dgvMilitaryStatus.Name = "dgvMilitaryStatus";
            this.dgvMilitaryStatus.ReadOnly = true;
            this.dgvMilitaryStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMilitaryStatus.Size = new System.Drawing.Size(387, 133);
            this.dgvMilitaryStatus.TabIndex = 0;
            this.dgvMilitaryStatus.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMilitaryStatus_RowHeaderMouseDoubleClick);
            // 
            // MilitaryStatus
            // 
            this.MilitaryStatus.DataPropertyName = "MilitaryStatus";
            this.MilitaryStatus.HeaderText = "Military Status";
            this.MilitaryStatus.Name = "MilitaryStatus";
            this.MilitaryStatus.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // addMilitaryStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 251);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteMs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNewMilitaryStatus);
            this.Controls.Add(this.txtNewMilitaryStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addMilitaryStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MilitaryStatus";
            this.Load += new System.EventHandler(this.addMilitaryStatus_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMilitaryStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewMilitaryStatus;
        private System.Windows.Forms.TextBox txtNewMilitaryStatus;
        private System.Windows.Forms.Button btnDeleteMs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMilitaryStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn MilitaryStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}