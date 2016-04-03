namespace EfMetroDemo
{
    partial class FrmManageDepartment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGridDepartments = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelDepatmentId = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxDepartmentTitle = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonSave = new MetroFramework.Controls.MetroButton();
            this.metroButtonClear = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridDepartments)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroGridDepartments
            // 
            this.metroGridDepartments.AllowUserToResizeRows = false;
            this.metroGridDepartments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridDepartments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridDepartments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridDepartments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridDepartments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridDepartments.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridDepartments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroGridDepartments.EnableHeadersVisualStyles = false;
            this.metroGridDepartments.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridDepartments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridDepartments.Location = new System.Drawing.Point(20, 216);
            this.metroGridDepartments.Name = "metroGridDepartments";
            this.metroGridDepartments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridDepartments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridDepartments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridDepartments.Size = new System.Drawing.Size(335, 175);
            this.metroGridDepartments.TabIndex = 0;
            this.metroGridDepartments.SelectionChanged += new System.EventHandler(this.metroGridDepartments_SelectionChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 184);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(104, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "All Departments";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroButtonClear);
            this.metroPanel1.Controls.Add(this.metroButtonSave);
            this.metroPanel1.Controls.Add(this.metroTextBoxDepartmentTitle);
            this.metroPanel1.Controls.Add(this.metroLabelDepatmentId);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 64);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(332, 107);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 4);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Department Id:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 38);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(111, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Department Title:";
            // 
            // metroLabelDepatmentId
            // 
            this.metroLabelDepatmentId.AutoSize = true;
            this.metroLabelDepatmentId.Location = new System.Drawing.Point(122, 3);
            this.metroLabelDepatmentId.Name = "metroLabelDepatmentId";
            this.metroLabelDepatmentId.Size = new System.Drawing.Size(16, 19);
            this.metroLabelDepatmentId.TabIndex = 4;
            this.metroLabelDepatmentId.Text = "0";
            // 
            // metroTextBoxDepartmentTitle
            // 
            // 
            // 
            // 
            this.metroTextBoxDepartmentTitle.CustomButton.Image = null;
            this.metroTextBoxDepartmentTitle.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.metroTextBoxDepartmentTitle.CustomButton.Name = "";
            this.metroTextBoxDepartmentTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxDepartmentTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxDepartmentTitle.CustomButton.TabIndex = 1;
            this.metroTextBoxDepartmentTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxDepartmentTitle.CustomButton.UseSelectable = true;
            this.metroTextBoxDepartmentTitle.CustomButton.Visible = false;
            this.metroTextBoxDepartmentTitle.Lines = new string[0];
            this.metroTextBoxDepartmentTitle.Location = new System.Drawing.Point(122, 38);
            this.metroTextBoxDepartmentTitle.MaxLength = 32767;
            this.metroTextBoxDepartmentTitle.Name = "metroTextBoxDepartmentTitle";
            this.metroTextBoxDepartmentTitle.PasswordChar = '\0';
            this.metroTextBoxDepartmentTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxDepartmentTitle.SelectedText = "";
            this.metroTextBoxDepartmentTitle.SelectionLength = 0;
            this.metroTextBoxDepartmentTitle.SelectionStart = 0;
            this.metroTextBoxDepartmentTitle.Size = new System.Drawing.Size(207, 23);
            this.metroTextBoxDepartmentTitle.TabIndex = 5;
            this.metroTextBoxDepartmentTitle.UseSelectable = true;
            this.metroTextBoxDepartmentTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxDepartmentTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonSave
            // 
            this.metroButtonSave.Location = new System.Drawing.Point(122, 67);
            this.metroButtonSave.Name = "metroButtonSave";
            this.metroButtonSave.Size = new System.Drawing.Size(75, 23);
            this.metroButtonSave.TabIndex = 6;
            this.metroButtonSave.Text = "Save";
            this.metroButtonSave.UseSelectable = true;
            this.metroButtonSave.Click += new System.EventHandler(this.metroButtonSave_Click);
            // 
            // metroButtonClear
            // 
            this.metroButtonClear.Location = new System.Drawing.Point(204, 68);
            this.metroButtonClear.Name = "metroButtonClear";
            this.metroButtonClear.Size = new System.Drawing.Size(75, 23);
            this.metroButtonClear.TabIndex = 7;
            this.metroButtonClear.Text = "Clear";
            this.metroButtonClear.UseSelectable = true;
            this.metroButtonClear.Click += new System.EventHandler(this.metroButtonClear_Click);
            // 
            // FrmManageDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 411);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroGridDepartments);
            this.Name = "FrmManageDepartment";
            this.Text = "Manage Departments";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmManageDepartment_FormClosed);
            this.Load += new System.EventHandler(this.FrmManageDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridDepartments)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGridDepartments;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButtonClear;
        private MetroFramework.Controls.MetroButton metroButtonSave;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDepartmentTitle;
        private MetroFramework.Controls.MetroLabel metroLabelDepatmentId;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}