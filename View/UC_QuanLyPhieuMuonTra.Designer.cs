namespace LibraryManager.View
{
    partial class UC_QuanLyPhieuMuonTra
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnmuonsach = new Guna.UI2.WinForms.Guna2Button();
            btntrasach = new Guna.UI2.WinForms.Guna2Button();
            dgvqlpmt = new Guna.UI2.WinForms.Guna2DataGridView();
            dgvchitietphieumuontra = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvqlpmt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvchitietphieumuontra).BeginInit();
            guna2GroupBox1.SuspendLayout();
            guna2GroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnmuonsach
            // 
            btnmuonsach.BorderRadius = 15;
            btnmuonsach.CustomizableEdges = customizableEdges1;
            btnmuonsach.DisabledState.BorderColor = Color.DarkGray;
            btnmuonsach.DisabledState.CustomBorderColor = Color.DarkGray;
            btnmuonsach.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnmuonsach.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnmuonsach.FillColor = Color.DodgerBlue;
            btnmuonsach.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnmuonsach.ForeColor = Color.White;
            btnmuonsach.Image = Properties.Resources.icons8_borrow_book_32;
            btnmuonsach.ImageAlign = HorizontalAlignment.Left;
            btnmuonsach.ImageSize = new Size(32, 32);
            btnmuonsach.Location = new Point(744, 650);
            btnmuonsach.Name = "btnmuonsach";
            btnmuonsach.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnmuonsach.Size = new Size(200, 50);
            btnmuonsach.TabIndex = 2;
            btnmuonsach.Text = "     Mượn Sách";
            btnmuonsach.TextAlign = HorizontalAlignment.Left;
            btnmuonsach.Click += btnmuonsach_Click;
            // 
            // btntrasach
            // 
            btntrasach.BorderRadius = 15;
            btntrasach.CustomizableEdges = customizableEdges3;
            btntrasach.DisabledState.BorderColor = Color.DarkGray;
            btntrasach.DisabledState.CustomBorderColor = Color.DarkGray;
            btntrasach.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btntrasach.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btntrasach.FillColor = Color.DodgerBlue;
            btntrasach.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btntrasach.ForeColor = Color.White;
            btntrasach.Image = Properties.Resources.icons8_return_book_32;
            btntrasach.ImageAlign = HorizontalAlignment.Left;
            btntrasach.ImageSize = new Size(32, 32);
            btntrasach.Location = new Point(950, 650);
            btntrasach.Name = "btntrasach";
            btntrasach.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btntrasach.Size = new Size(200, 50);
            btntrasach.TabIndex = 3;
            btntrasach.Text = "     Trả Sách";
            btntrasach.TextAlign = HorizontalAlignment.Left;
            btntrasach.Click += btntrasach_Click;
            // 
            // dgvqlpmt
            // 
            dgvqlpmt.AllowUserToAddRows = false;
            dgvqlpmt.AllowUserToDeleteRows = false;
            dgvqlpmt.AllowUserToResizeColumns = false;
            dgvqlpmt.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvqlpmt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvqlpmt.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvqlpmt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvqlpmt.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvqlpmt.DefaultCellStyle = dataGridViewCellStyle3;
            dgvqlpmt.Dock = DockStyle.Fill;
            dgvqlpmt.GridColor = Color.Silver;
            dgvqlpmt.Location = new Point(0, 40);
            dgvqlpmt.MultiSelect = false;
            dgvqlpmt.Name = "dgvqlpmt";
            dgvqlpmt.ReadOnly = true;
            dgvqlpmt.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvqlpmt.RowHeadersVisible = false;
            dgvqlpmt.RowHeadersWidth = 50;
            dgvqlpmt.RowTemplate.Height = 25;
            dgvqlpmt.Size = new Size(1100, 280);
            dgvqlpmt.TabIndex = 17;
            dgvqlpmt.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvqlpmt.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvqlpmt.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvqlpmt.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvqlpmt.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvqlpmt.ThemeStyle.BackColor = Color.White;
            dgvqlpmt.ThemeStyle.GridColor = Color.Silver;
            dgvqlpmt.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvqlpmt.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvqlpmt.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvqlpmt.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvqlpmt.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvqlpmt.ThemeStyle.HeaderStyle.Height = 30;
            dgvqlpmt.ThemeStyle.ReadOnly = true;
            dgvqlpmt.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvqlpmt.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvqlpmt.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvqlpmt.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvqlpmt.ThemeStyle.RowsStyle.Height = 25;
            dgvqlpmt.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvqlpmt.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvqlpmt.CellClick += dgvqlpmt_CellClick;
            // 
            // dgvchitietphieumuontra
            // 
            dgvchitietphieumuontra.AllowUserToAddRows = false;
            dgvchitietphieumuontra.AllowUserToDeleteRows = false;
            dgvchitietphieumuontra.AllowUserToResizeColumns = false;
            dgvchitietphieumuontra.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvchitietphieumuontra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvchitietphieumuontra.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvchitietphieumuontra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvchitietphieumuontra.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvchitietphieumuontra.DefaultCellStyle = dataGridViewCellStyle6;
            dgvchitietphieumuontra.Dock = DockStyle.Fill;
            dgvchitietphieumuontra.GridColor = Color.Silver;
            dgvchitietphieumuontra.Location = new Point(0, 40);
            dgvchitietphieumuontra.MultiSelect = false;
            dgvchitietphieumuontra.Name = "dgvchitietphieumuontra";
            dgvchitietphieumuontra.ReadOnly = true;
            dgvchitietphieumuontra.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvchitietphieumuontra.RowHeadersVisible = false;
            dgvchitietphieumuontra.RowHeadersWidth = 50;
            dgvchitietphieumuontra.RowTemplate.Height = 25;
            dgvchitietphieumuontra.Size = new Size(688, 240);
            dgvchitietphieumuontra.TabIndex = 18;
            dgvchitietphieumuontra.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvchitietphieumuontra.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvchitietphieumuontra.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvchitietphieumuontra.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvchitietphieumuontra.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvchitietphieumuontra.ThemeStyle.BackColor = Color.White;
            dgvchitietphieumuontra.ThemeStyle.GridColor = Color.Silver;
            dgvchitietphieumuontra.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvchitietphieumuontra.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvchitietphieumuontra.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvchitietphieumuontra.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvchitietphieumuontra.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvchitietphieumuontra.ThemeStyle.HeaderStyle.Height = 30;
            dgvchitietphieumuontra.ThemeStyle.ReadOnly = true;
            dgvchitietphieumuontra.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvchitietphieumuontra.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvchitietphieumuontra.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvchitietphieumuontra.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvchitietphieumuontra.ThemeStyle.RowsStyle.Height = 25;
            dgvchitietphieumuontra.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvchitietphieumuontra.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // guna2GroupBox1
            // 
            guna2GroupBox1.BorderRadius = 20;
            guna2GroupBox1.Controls.Add(dgvchitietphieumuontra);
            guna2GroupBox1.CustomBorderColor = Color.FromArgb(224, 224, 224);
            guna2GroupBox1.CustomizableEdges = customizableEdges5;
            guna2GroupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            guna2GroupBox1.ForeColor = Color.FromArgb(64, 64, 64);
            guna2GroupBox1.Location = new Point(50, 420);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2GroupBox1.Size = new Size(688, 280);
            guna2GroupBox1.TabIndex = 37;
            guna2GroupBox1.Text = "Chi Tiết Phiếu Mượn Trả";
            // 
            // guna2GroupBox2
            // 
            guna2GroupBox2.BorderRadius = 20;
            guna2GroupBox2.Controls.Add(dgvqlpmt);
            guna2GroupBox2.CustomBorderColor = Color.FromArgb(224, 224, 224);
            guna2GroupBox2.CustomizableEdges = customizableEdges7;
            guna2GroupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            guna2GroupBox2.ForeColor = Color.FromArgb(64, 64, 64);
            guna2GroupBox2.Location = new Point(50, 91);
            guna2GroupBox2.Name = "guna2GroupBox2";
            guna2GroupBox2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2GroupBox2.Size = new Size(1100, 320);
            guna2GroupBox2.TabIndex = 44;
            guna2GroupBox2.Text = "Danh Sách";
            // 
            // UC_QuanLyPhieuMuonTra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2GroupBox2);
            Controls.Add(guna2GroupBox1);
            Controls.Add(btntrasach);
            Controls.Add(btnmuonsach);
            Name = "UC_QuanLyPhieuMuonTra";
            Size = new Size(1200, 750);
            Load += PhieuMuonTraUI_Load;
            ((System.ComponentModel.ISupportInitialize)dgvqlpmt).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvchitietphieumuontra).EndInit();
            guna2GroupBox1.ResumeLayout(false);
            guna2GroupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnmuonsach;
        private Guna.UI2.WinForms.Guna2Button btntrasach;
        private Guna.UI2.WinForms.Guna2DataGridView dgvqlpmt;
        private Guna.UI2.WinForms.Guna2DataGridView dgvchitietphieumuontra;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
    }
}
