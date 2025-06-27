namespace LibraryManager.View
{
    partial class PhieuMuonTraUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgvqlpmt = new Guna.UI2.WinForms.Guna2DataGridView();
            btnthem = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgvqlpmt).BeginInit();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(50, 55);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(311, 39);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Quản Lí Phiếu Mượn Trả";
            // 
            // dgvqlpmt
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvqlpmt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvqlpmt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvqlpmt.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvqlpmt.DefaultCellStyle = dataGridViewCellStyle6;
            dgvqlpmt.GridColor = Color.FromArgb(231, 229, 255);
            dgvqlpmt.Location = new Point(50, 100);
            dgvqlpmt.Name = "dgvqlpmt";
            dgvqlpmt.RowHeadersVisible = false;
            dgvqlpmt.RowTemplate.Height = 25;
            dgvqlpmt.Size = new Size(1134, 350);
            dgvqlpmt.TabIndex = 1;
            dgvqlpmt.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvqlpmt.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvqlpmt.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvqlpmt.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvqlpmt.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvqlpmt.ThemeStyle.BackColor = Color.White;
            dgvqlpmt.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvqlpmt.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvqlpmt.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvqlpmt.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvqlpmt.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvqlpmt.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvqlpmt.ThemeStyle.HeaderStyle.Height = 30;
            dgvqlpmt.ThemeStyle.ReadOnly = false;
            dgvqlpmt.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvqlpmt.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvqlpmt.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvqlpmt.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvqlpmt.ThemeStyle.RowsStyle.Height = 25;
            dgvqlpmt.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvqlpmt.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // btnthem
            // 
            btnthem.BorderRadius = 10;
            btnthem.CustomizableEdges = customizableEdges3;
            btnthem.DisabledState.BorderColor = Color.DarkGray;
            btnthem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnthem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnthem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnthem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnthem.ForeColor = Color.White;
            btnthem.Image = Properties.Resources.icons8_add_32;
            btnthem.ImageAlign = HorizontalAlignment.Left;
            btnthem.ImageSize = new Size(32, 32);
            btnthem.Location = new Point(50, 522);
            btnthem.Name = "btnthem";
            btnthem.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnthem.Size = new Size(180, 45);
            btnthem.TabIndex = 2;
            btnthem.Text = "Thêm Phiếu Mượn";
            btnthem.TextAlign = HorizontalAlignment.Left;
            btnthem.Click += btnthem_Click;
            // 
            // PhieuMuonTraUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnthem);
            Controls.Add(dgvqlpmt);
            Controls.Add(guna2HtmlLabel1);
            Name = "PhieuMuonTraUI";
            Size = new Size(1234, 961);
            Load += PhieuMuonTraUI_Load;
            ((System.ComponentModel.ISupportInitialize)dgvqlpmt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvqlpmt;
        private Guna.UI2.WinForms.Guna2Button btnthem;
    }
}
