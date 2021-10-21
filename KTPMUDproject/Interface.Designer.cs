namespace KTPMUDproject
{
    partial class Interface
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonOder = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.buttonMovie = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabelProfile = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.ktpmudDataSet = new KTPMUDproject.ktpmudDataSet();
            this.nhansuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhansuTableAdapter = new KTPMUDproject.ktpmudDataSetTableAdapters.nhansuTableAdapter();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagePhim = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPageStaff = new System.Windows.Forms.TabPage();
            this.tabPageReservation = new System.Windows.Forms.TabPage();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMa_nhan_vien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTen_nhan_vien = new System.Windows.Forms.TextBox();
            this.textBoxTuoi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxGioi_tinh = new System.Windows.Forms.TextBox();
            this.textBoxSo_gio_lam = new System.Windows.Forms.TextBox();
            this.textBoxChuc_vu = new System.Windows.Forms.TextBox();
            this.textBoxQue_quan = new System.Windows.Forms.TextBox();
            this.textBoxSo_dien_thoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonChangeProfile = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ktpmudDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhansuBindingSource)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPagePhim.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 409);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel7.Controls.Add(this.buttonOder);
            this.panel7.Controls.Add(this.buttonReport);
            this.panel7.Controls.Add(this.buttonStaff);
            this.panel7.Controls.Add(this.buttonMovie);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 95);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(168, 314);
            this.panel7.TabIndex = 0;
            // 
            // buttonOder
            // 
            this.buttonOder.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOder.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonOder.Location = new System.Drawing.Point(0, 114);
            this.buttonOder.Name = "buttonOder";
            this.buttonOder.Size = new System.Drawing.Size(168, 38);
            this.buttonOder.TabIndex = 0;
            this.buttonOder.Text = "Đặt phòng/Thanh toán";
            this.buttonOder.UseVisualStyleBackColor = true;
            this.buttonOder.Click += new System.EventHandler(this.buttonOder_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonReport.Location = new System.Drawing.Point(0, 76);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(168, 38);
            this.buttonReport.TabIndex = 0;
            this.buttonReport.Text = "Báo cáo thống kê";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonStaff
            // 
            this.buttonStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStaff.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonStaff.Location = new System.Drawing.Point(0, 38);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(168, 38);
            this.buttonStaff.TabIndex = 0;
            this.buttonStaff.Text = "Nhân sự";
            this.buttonStaff.UseVisualStyleBackColor = true;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // buttonMovie
            // 
            this.buttonMovie.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonMovie.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMovie.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonMovie.Location = new System.Drawing.Point(0, 0);
            this.buttonMovie.Name = "buttonMovie";
            this.buttonMovie.Size = new System.Drawing.Size(168, 38);
            this.buttonMovie.TabIndex = 0;
            this.buttonMovie.Text = "Phim";
            this.buttonMovie.UseVisualStyleBackColor = true;
            this.buttonMovie.Click += new System.EventHandler(this.buttonMovie_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel3.Controls.Add(this.linkLabelProfile);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.linkLabelLogout);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBoxAvatar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 71);
            this.panel3.TabIndex = 0;
            // 
            // linkLabelProfile
            // 
            this.linkLabelProfile.AutoSize = true;
            this.linkLabelProfile.LinkColor = System.Drawing.Color.LightSlateGray;
            this.linkLabelProfile.Location = new System.Drawing.Point(75, 48);
            this.linkLabelProfile.Name = "linkLabelProfile";
            this.linkLabelProfile.Size = new System.Drawing.Size(76, 13);
            this.linkLabelProfile.TabIndex = 2;
            this.linkLabelProfile.TabStop = true;
            this.linkLabelProfile.Text = "Change Profile";
            this.linkLabelProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelProfile_LinkClicked);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Location = new System.Drawing.Point(168, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(580, 371);
            this.panel4.TabIndex = 0;
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.LinkColor = System.Drawing.Color.LightSlateGray;
            this.linkLabelLogout.Location = new System.Drawing.Point(84, 30);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(56, 13);
            this.linkLabelLogout.TabIndex = 1;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Đăng xuất";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(74, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chào, Nguyễn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Location = new System.Drawing.Point(5, 10);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(56, 51);
            this.pictureBoxAvatar.TabIndex = 0;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // ktpmudDataSet
            // 
            this.ktpmudDataSet.DataSetName = "ktpmudDataSet";
            this.ktpmudDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhansuBindingSource
            // 
            this.nhansuBindingSource.DataMember = "nhansu";
            this.nhansuBindingSource.DataSource = this.ktpmudDataSet;
            // 
            // nhansuTableAdapter
            // 
            this.nhansuTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPagePhim);
            this.tabControl.Controls.Add(this.tabPageStaff);
            this.tabControl.Controls.Add(this.tabPageReservation);
            this.tabControl.Controls.Add(this.tabPageProfile);
            this.tabControl.Controls.Add(this.tabPageReport);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(168, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(569, 409);
            this.tabControl.TabIndex = 3;
            // 
            // tabPagePhim
            // 
            this.tabPagePhim.Controls.Add(this.button1);
            this.tabPagePhim.Location = new System.Drawing.Point(4, 22);
            this.tabPagePhim.Name = "tabPagePhim";
            this.tabPagePhim.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePhim.Size = new System.Drawing.Size(561, 383);
            this.tabPagePhim.TabIndex = 0;
            this.tabPagePhim.Text = "Phim";
            this.tabPagePhim.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPageStaff
            // 
            this.tabPageStaff.Location = new System.Drawing.Point(4, 22);
            this.tabPageStaff.Name = "tabPageStaff";
            this.tabPageStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStaff.Size = new System.Drawing.Size(561, 383);
            this.tabPageStaff.TabIndex = 1;
            this.tabPageStaff.Text = "Staff";
            this.tabPageStaff.UseVisualStyleBackColor = true;
            // 
            // tabPageReservation
            // 
            this.tabPageReservation.Location = new System.Drawing.Point(4, 22);
            this.tabPageReservation.Name = "tabPageReservation";
            this.tabPageReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReservation.Size = new System.Drawing.Size(561, 383);
            this.tabPageReservation.TabIndex = 2;
            this.tabPageReservation.Text = "Reservation";
            this.tabPageReservation.UseVisualStyleBackColor = true;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageProfile.Controls.Add(this.button2);
            this.tabPageProfile.Controls.Add(this.panel2);
            this.tabPageProfile.Controls.Add(this.buttonChangeProfile);
            this.tabPageProfile.Controls.Add(this.button3);
            this.tabPageProfile.Controls.Add(this.button4);
            this.tabPageProfile.Location = new System.Drawing.Point(4, 22);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfile.Size = new System.Drawing.Size(561, 383);
            this.tabPageProfile.TabIndex = 3;
            this.tabPageProfile.Text = "Profile";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxMa_nhan_vien);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxTen_nhan_vien);
            this.panel2.Controls.Add(this.textBoxTuoi);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBoxGioi_tinh);
            this.panel2.Controls.Add(this.textBoxSo_gio_lam);
            this.panel2.Controls.Add(this.textBoxChuc_vu);
            this.panel2.Controls.Add(this.textBoxQue_quan);
            this.panel2.Controls.Add(this.textBoxSo_dien_thoai);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(62, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 207);
            this.panel2.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Quê Quán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Số giờ làm";
            // 
            // textBoxMa_nhan_vien
            // 
            this.textBoxMa_nhan_vien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxMa_nhan_vien.ForeColor = System.Drawing.Color.Black;
            this.textBoxMa_nhan_vien.Location = new System.Drawing.Point(132, 49);
            this.textBoxMa_nhan_vien.Name = "textBoxMa_nhan_vien";
            this.textBoxMa_nhan_vien.Size = new System.Drawing.Size(144, 20);
            this.textBoxMa_nhan_vien.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Chức vụ";
            // 
            // textBoxTen_nhan_vien
            // 
            this.textBoxTen_nhan_vien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTen_nhan_vien.Location = new System.Drawing.Point(132, 88);
            this.textBoxTen_nhan_vien.Name = "textBoxTen_nhan_vien";
            this.textBoxTen_nhan_vien.Size = new System.Drawing.Size(144, 20);
            this.textBoxTen_nhan_vien.TabIndex = 1;
            // 
            // textBoxTuoi
            // 
            this.textBoxTuoi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTuoi.Location = new System.Drawing.Point(132, 126);
            this.textBoxTuoi.Name = "textBoxTuoi";
            this.textBoxTuoi.Size = new System.Drawing.Size(144, 20);
            this.textBoxTuoi.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Số điện thoại";
            // 
            // textBoxGioi_tinh
            // 
            this.textBoxGioi_tinh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxGioi_tinh.Location = new System.Drawing.Point(132, 164);
            this.textBoxGioi_tinh.Name = "textBoxGioi_tinh";
            this.textBoxGioi_tinh.Size = new System.Drawing.Size(144, 20);
            this.textBoxGioi_tinh.TabIndex = 3;
            // 
            // textBoxSo_gio_lam
            // 
            this.textBoxSo_gio_lam.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxSo_gio_lam.Location = new System.Drawing.Point(394, 163);
            this.textBoxSo_gio_lam.Name = "textBoxSo_gio_lam";
            this.textBoxSo_gio_lam.Size = new System.Drawing.Size(144, 20);
            this.textBoxSo_gio_lam.TabIndex = 14;
            // 
            // textBoxChuc_vu
            // 
            this.textBoxChuc_vu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxChuc_vu.Location = new System.Drawing.Point(394, 125);
            this.textBoxChuc_vu.Name = "textBoxChuc_vu";
            this.textBoxChuc_vu.Size = new System.Drawing.Size(144, 20);
            this.textBoxChuc_vu.TabIndex = 13;
            // 
            // textBoxQue_quan
            // 
            this.textBoxQue_quan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxQue_quan.Location = new System.Drawing.Point(394, 87);
            this.textBoxQue_quan.Name = "textBoxQue_quan";
            this.textBoxQue_quan.Size = new System.Drawing.Size(144, 20);
            this.textBoxQue_quan.TabIndex = 12;
            // 
            // textBoxSo_dien_thoai
            // 
            this.textBoxSo_dien_thoai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxSo_dien_thoai.Location = new System.Drawing.Point(394, 48);
            this.textBoxSo_dien_thoai.Name = "textBoxSo_dien_thoai";
            this.textBoxSo_dien_thoai.Size = new System.Drawing.Size(144, 20);
            this.textBoxSo_dien_thoai.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tuổi";
            // 
            // buttonChangeProfile
            // 
            this.buttonChangeProfile.Location = new System.Drawing.Point(78, 256);
            this.buttonChangeProfile.Name = "buttonChangeProfile";
            this.buttonChangeProfile.Size = new System.Drawing.Size(167, 23);
            this.buttonChangeProfile.TabIndex = 4;
            this.buttonChangeProfile.Text = "Thay đổi thông tin cá nhân";
            this.buttonChangeProfile.UseVisualStyleBackColor = true;
            this.buttonChangeProfile.Click += new System.EventHandler(this.buttonChangeProfile_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(386, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Đổi mật khẩu";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(144, 285);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "OK";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabPageReport
            // 
            this.tabPageReport.Location = new System.Drawing.Point(4, 22);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReport.Size = new System.Drawing.Size(561, 383);
            this.tabPageReport.TabIndex = 4;
            this.tabPageReport.Text = "Report";
            this.tabPageReport.UseVisualStyleBackColor = true;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 409);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Name = "Interface";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interface";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Interface_Load);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ktpmudDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhansuBindingSource)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPagePhim.ResumeLayout(false);
            this.tabPageProfile.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonMovie;
        private System.Windows.Forms.Button buttonStaff;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel linkLabelProfile;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonOder;
        private ktpmudDataSet ktpmudDataSet;
        private System.Windows.Forms.BindingSource nhansuBindingSource;
        private ktpmudDataSetTableAdapters.nhansuTableAdapter nhansuTableAdapter;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagePhim;
        private System.Windows.Forms.TabPage tabPageStaff;
        private System.Windows.Forms.TabPage tabPageReservation;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.TabPage tabPageReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonChangeProfile;
        private System.Windows.Forms.TextBox textBoxGioi_tinh;
        private System.Windows.Forms.TextBox textBoxTuoi;
        private System.Windows.Forms.TextBox textBoxTen_nhan_vien;
        private System.Windows.Forms.TextBox textBoxMa_nhan_vien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSo_gio_lam;
        private System.Windows.Forms.TextBox textBoxChuc_vu;
        private System.Windows.Forms.TextBox textBoxQue_quan;
        private System.Windows.Forms.TextBox textBoxSo_dien_thoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;


    }
}