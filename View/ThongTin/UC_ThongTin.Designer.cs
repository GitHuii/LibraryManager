namespace LibraryManager.View.ThongTin
{
    partial class UC_ThongTin
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label1 = new Label();
            lbltk = new Label();
            lblpq = new Label();
            label4 = new Label();
            btndangxuat = new Guna.UI2.WinForms.Guna2Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(50, 50);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(200, 27);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Thông Tin Đăng Nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(50, 100);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 1;
            label1.Text = "Tài Khoản";
            // 
            // lbltk
            // 
            lbltk.AutoSize = true;
            lbltk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbltk.Location = new Point(200, 100);
            lbltk.Name = "lbltk";
            lbltk.Size = new Size(23, 21);
            lbltk.TabIndex = 2;
            lbltk.Text = "tk";
            // 
            // lblpq
            // 
            lblpq.AutoSize = true;
            lblpq.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblpq.Location = new Point(200, 130);
            lblpq.Name = "lblpq";
            lblpq.Size = new Size(28, 21);
            lblpq.TabIndex = 4;
            lblpq.Text = "pq";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(50, 130);
            label4.Name = "label4";
            label4.Size = new Size(103, 21);
            label4.TabIndex = 3;
            label4.Text = "Phân Quyền";
            // 
            // btndangxuat
            // 
            btndangxuat.BorderRadius = 20;
            btndangxuat.CustomizableEdges = customizableEdges3;
            btndangxuat.DisabledState.BorderColor = Color.DarkGray;
            btndangxuat.DisabledState.CustomBorderColor = Color.DarkGray;
            btndangxuat.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btndangxuat.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btndangxuat.FillColor = Color.DodgerBlue;
            btndangxuat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btndangxuat.ForeColor = Color.White;
            btndangxuat.Image = Properties.Resources.icons8_logout_32__1_;
            btndangxuat.ImageSize = new Size(32, 32);
            btndangxuat.Location = new Point(50, 200);
            btndangxuat.Name = "btndangxuat";
            btndangxuat.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btndangxuat.Size = new Size(350, 50);
            btndangxuat.TabIndex = 53;
            btndangxuat.Text = " Đăng Xuất";
            btndangxuat.Click += btndangxuat_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel2.Location = new Point(700, 50);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(194, 27);
            guna2HtmlLabel2.TabIndex = 54;
            guna2HtmlLabel2.Text = "Thông Tin Phần Mềm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(850, 100);
            label5.Name = "label5";
            label5.Size = new Size(175, 21);
            label5.TabIndex = 58;
            label5.Text = "Nhóm 6 - DHTI16A6HN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(700, 100);
            label6.Name = "label6";
            label6.Size = new Size(123, 21);
            label6.TabIndex = 57;
            label6.Text = "Nhà Phát Triển";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(850, 250);
            label7.Name = "label7";
            label7.Size = new Size(51, 21);
            label7.TabIndex = 56;
            label7.Text = "v1.0.0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(700, 250);
            label8.Name = "label8";
            label8.Size = new Size(87, 21);
            label8.TabIndex = 55;
            label8.Text = "Phiên Bản";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(850, 130);
            label9.Name = "label9";
            label9.Size = new Size(128, 21);
            label9.TabIndex = 59;
            label9.Text = "Nguyễn Viết Huy";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(850, 160);
            label10.Name = "label10";
            label10.Size = new Size(113, 21);
            label10.TabIndex = 60;
            label10.Text = "Khổng Đức Hải";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(850, 190);
            label11.Name = "label11";
            label11.Size = new Size(120, 21);
            label11.TabIndex = 61;
            label11.Text = "Đinh Tiến Mạnh";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(850, 220);
            label12.Name = "label12";
            label12.Size = new Size(136, 21);
            label12.TabIndex = 62;
            label12.Text = "Nguyễn Xuân Duy";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(700, 280);
            label13.Name = "label13";
            label13.Size = new Size(57, 21);
            label13.TabIndex = 63;
            label13.Text = "Mô Tả";
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.Connection = null;
            sqlCommand2.Notification = null;
            sqlCommand2.Transaction = null;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(850, 280);
            label14.Name = "label14";
            label14.Size = new Size(183, 21);
            label14.TabIndex = 64;
            label14.Text = "Dự Án Học Phần Đồ Án 1";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(850, 310);
            label15.Name = "label15";
            label15.Size = new Size(99, 21);
            label15.TabIndex = 66;
            label15.Text = "Vũ Anh Tuấn";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(700, 310);
            label16.Name = "label16";
            label16.Size = new Size(56, 21);
            label16.TabIndex = 65;
            label16.Text = "GVHD";
            // 
            // UC_ThongTin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(btndangxuat);
            Controls.Add(lblpq);
            Controls.Add(label4);
            Controls.Add(lbltk);
            Controls.Add(label1);
            Controls.Add(guna2HtmlLabel1);
            Name = "UC_ThongTin";
            Size = new Size(1200, 750);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label label1;
        private Label lbltk;
        private Label lblpq;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button btndangxuat;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private Label label14;
        private Label label15;
        private Label label16;
    }
}
