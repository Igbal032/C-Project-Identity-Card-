namespace CSharpProject
{
    partial class AddEyeColor
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
            this.txtNewColor = new System.Windows.Forms.TextBox();
            this.addNewColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteColor = new System.Windows.Forms.Button();
            this.dgvColorList = new System.Windows.Forms.DataGridView();
            this.EyeColor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorList = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColorList)).BeginInit();
            this.ColorList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNewColor
            // 
            this.txtNewColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewColor.Location = new System.Drawing.Point(83, 12);
            this.txtNewColor.Multiline = true;
            this.txtNewColor.Name = "txtNewColor";
            this.txtNewColor.Size = new System.Drawing.Size(138, 26);
            this.txtNewColor.TabIndex = 0;
            // 
            // addNewColor
            // 
            this.addNewColor.Location = new System.Drawing.Point(117, 44);
            this.addNewColor.Name = "addNewColor";
            this.addNewColor.Size = new System.Drawing.Size(49, 22);
            this.addNewColor.TabIndex = 1;
            this.addNewColor.Text = "ADD";
            this.addNewColor.UseVisualStyleBackColor = true;
            this.addNewColor.Click += new System.EventHandler(this.addNewColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Color :";
            // 
            // btnDeleteColor
            // 
            this.btnDeleteColor.Location = new System.Drawing.Point(172, 44);
            this.btnDeleteColor.Name = "btnDeleteColor";
            this.btnDeleteColor.Size = new System.Drawing.Size(49, 22);
            this.btnDeleteColor.TabIndex = 3;
            this.btnDeleteColor.Text = "Delete";
            this.btnDeleteColor.UseVisualStyleBackColor = true;
            this.btnDeleteColor.Click += new System.EventHandler(this.btnDeleteColor_Click);
            // 
            // dgvColorList
            // 
            this.dgvColorList.AllowUserToAddRows = false;
            this.dgvColorList.AllowUserToDeleteRows = false;
            this.dgvColorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColorList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EyeColor1});
            this.dgvColorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvColorList.Location = new System.Drawing.Point(3, 16);
            this.dgvColorList.Name = "dgvColorList";
            this.dgvColorList.ReadOnly = true;
            this.dgvColorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColorList.Size = new System.Drawing.Size(397, 113);
            this.dgvColorList.TabIndex = 4;
            this.dgvColorList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvColorList_RowHeaderMouseDoubleClick);
            // 
            // EyeColor1
            // 
            this.EyeColor1.DataPropertyName = "EyeColor1";
            this.EyeColor1.HeaderText = "Eye Color";
            this.EyeColor1.Name = "EyeColor1";
            this.EyeColor1.ReadOnly = true;
            // 
            // ColorList
            // 
            this.ColorList.Controls.Add(this.dgvColorList);
            this.ColorList.Location = new System.Drawing.Point(20, 79);
            this.ColorList.Name = "ColorList";
            this.ColorList.Size = new System.Drawing.Size(403, 132);
            this.ColorList.TabIndex = 5;
            this.ColorList.TabStop = false;
            this.ColorList.Text = "Color List";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddEyeColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 223);
            this.Controls.Add(this.ColorList);
            this.Controls.Add(this.btnDeleteColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addNewColor);
            this.Controls.Add(this.txtNewColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEyeColor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EyeColor";
            this.Load += new System.EventHandler(this.AddEyeColor_Load);
            this.Click += new System.EventHandler(this.AddEyeColor_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColorList)).EndInit();
            this.ColorList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewColor;
        private System.Windows.Forms.Button addNewColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteColor;
        private System.Windows.Forms.DataGridView dgvColorList;
        private System.Windows.Forms.GroupBox ColorList;
        private System.Windows.Forms.DataGridViewTextBoxColumn EyeColor1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}