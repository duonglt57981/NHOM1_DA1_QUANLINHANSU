namespace NHOM1_DA1_QUANLINHANSU.GUI.UC
{
    partial class UC_QLNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_QLNhanVien));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            IDTaiKhoan = new Label();
            comboBox_IDTaiKhoan = new ComboBox();
            label13 = new Label();
            comboBox_QLNV_GT = new ComboBox();
            dateTimePicker_QLNV_NgaySinh = new DateTimePicker();
            comboBox_QLNV_TT = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            textBox_QLNV_DiaChi = new TextBox();
            label9 = new Label();
            comboBox_QLNV_PB = new ComboBox();
            label4 = new Label();
            textBox_QLNV_TienPC = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox_QLNV_TD = new ComboBox();
            comboBox_QLNV_CV = new ComboBox();
            textBox_QLNV_SDT = new TextBox();
            textBox_QLNV_CCCD = new TextBox();
            textBox_QLNV_TenNV = new TextBox();
            textBox_QLNV_ID = new TextBox();
            groupBox2 = new GroupBox();
            button_QLNV_ChonAnh = new Button();
            pictureBox_QLNV = new PictureBox();
            panel3 = new Panel();
            groupBox3 = new GroupBox();
            textBox_TimKiem = new TextBox();
            button_TimKiem = new Button();
            button_QLNV_Sua = new Button();
            button_QLNV_XuatFlie = new Button();
            button_QLNV_Them = new Button();
            button_QLNV_LamMoi = new Button();
            button_QLNV_TinhLuong = new Button();
            textBox_QLNV_TinhLuong = new TextBox();
            groupBox4 = new GroupBox();
            panel4 = new Panel();
            panel2 = new Panel();
            dataGridView_QLNV = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_QLNV).BeginInit();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_QLNV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1043, 281);
            panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(IDTaiKhoan);
            groupBox1.Controls.Add(comboBox_IDTaiKhoan);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(comboBox_QLNV_GT);
            groupBox1.Controls.Add(dateTimePicker_QLNV_NgaySinh);
            groupBox1.Controls.Add(comboBox_QLNV_TT);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBox_QLNV_DiaChi);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(comboBox_QLNV_PB);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox_QLNV_TienPC);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox_QLNV_TD);
            groupBox1.Controls.Add(comboBox_QLNV_CV);
            groupBox1.Controls.Add(textBox_QLNV_SDT);
            groupBox1.Controls.Add(textBox_QLNV_CCCD);
            groupBox1.Controls.Add(textBox_QLNV_TenNV);
            groupBox1.Controls.Add(textBox_QLNV_ID);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1043, 281);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // IDTaiKhoan
            // 
            IDTaiKhoan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            IDTaiKhoan.AutoSize = true;
            IDTaiKhoan.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            IDTaiKhoan.ForeColor = SystemColors.HotTrack;
            IDTaiKhoan.Location = new Point(874, 175);
            IDTaiKhoan.Name = "IDTaiKhoan";
            IDTaiKhoan.Size = new Size(59, 19);
            IDTaiKhoan.TabIndex = 82;
            IDTaiKhoan.Text = "ID TK:";
            // 
            // comboBox_IDTaiKhoan
            // 
            comboBox_IDTaiKhoan.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox_IDTaiKhoan.FormattingEnabled = true;
            comboBox_IDTaiKhoan.Location = new Point(969, 168);
            comboBox_IDTaiKhoan.Name = "comboBox_IDTaiKhoan";
            comboBox_IDTaiKhoan.Size = new Size(63, 28);
            comboBox_IDTaiKhoan.TabIndex = 81;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label13.ForeColor = SystemColors.HotTrack;
            label13.Location = new Point(579, 38);
            label13.Name = "label13";
            label13.Size = new Size(84, 19);
            label13.TabIndex = 80;
            label13.Text = "Gioi tính:";
            // 
            // comboBox_QLNV_GT
            // 
            comboBox_QLNV_GT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox_QLNV_GT.FormattingEnabled = true;
            comboBox_QLNV_GT.Location = new Point(669, 34);
            comboBox_QLNV_GT.Name = "comboBox_QLNV_GT";
            comboBox_QLNV_GT.Size = new Size(174, 28);
            comboBox_QLNV_GT.TabIndex = 79;
            // 
            // dateTimePicker_QLNV_NgaySinh
            // 
            dateTimePicker_QLNV_NgaySinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dateTimePicker_QLNV_NgaySinh.Format = DateTimePickerFormat.Short;
            dateTimePicker_QLNV_NgaySinh.Location = new Point(669, 79);
            dateTimePicker_QLNV_NgaySinh.Name = "dateTimePicker_QLNV_NgaySinh";
            dateTimePicker_QLNV_NgaySinh.Size = new Size(173, 28);
            dateTimePicker_QLNV_NgaySinh.TabIndex = 78;
            // 
            // comboBox_QLNV_TT
            // 
            comboBox_QLNV_TT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox_QLNV_TT.FormattingEnabled = true;
            comboBox_QLNV_TT.Location = new Point(668, 167);
            comboBox_QLNV_TT.Name = "comboBox_QLNV_TT";
            comboBox_QLNV_TT.Size = new Size(173, 28);
            comboBox_QLNV_TT.TabIndex = 75;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label11.ForeColor = SystemColors.HotTrack;
            label11.Location = new Point(874, 81);
            label11.Name = "label11";
            label11.Size = new Size(78, 19);
            label11.TabIndex = 74;
            label11.Text = "Trình độ:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label10.ForeColor = SystemColors.HotTrack;
            label10.Location = new Point(183, 222);
            label10.Name = "label10";
            label10.Size = new Size(68, 19);
            label10.TabIndex = 73;
            label10.Text = "Địa chỉ:";
            // 
            // textBox_QLNV_DiaChi
            // 
            textBox_QLNV_DiaChi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_QLNV_DiaChi.Location = new Point(252, 218);
            textBox_QLNV_DiaChi.Name = "textBox_QLNV_DiaChi";
            textBox_QLNV_DiaChi.Size = new Size(785, 28);
            textBox_QLNV_DiaChi.TabIndex = 72;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(579, 127);
            label9.Name = "label9";
            label9.Size = new Size(75, 19);
            label9.TabIndex = 71;
            label9.Text = "Tiền PC:";
            // 
            // comboBox_QLNV_PB
            // 
            comboBox_QLNV_PB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox_QLNV_PB.FormattingEnabled = true;
            comboBox_QLNV_PB.Location = new Point(969, 33);
            comboBox_QLNV_PB.Name = "comboBox_QLNV_PB";
            comboBox_QLNV_PB.Size = new Size(63, 28);
            comboBox_QLNV_PB.TabIndex = 60;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(871, 37);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 65;
            label4.Text = "Phòng ban:";
            // 
            // textBox_QLNV_TienPC
            // 
            textBox_QLNV_TienPC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_QLNV_TienPC.Location = new Point(669, 123);
            textBox_QLNV_TienPC.Name = "textBox_QLNV_TienPC";
            textBox_QLNV_TienPC.Size = new Size(173, 28);
            textBox_QLNV_TienPC.TabIndex = 70;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(183, 83);
            label8.Name = "label8";
            label8.Size = new Size(67, 19);
            label8.TabIndex = 69;
            label8.Text = "Tên NV:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(579, 83);
            label7.Name = "label7";
            label7.Size = new Size(87, 19);
            label7.TabIndex = 68;
            label7.Text = "Ngày sinh:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(183, 127);
            label6.Name = "label6";
            label6.Size = new Size(45, 19);
            label6.TabIndex = 67;
            label6.Text = "SĐT:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(183, 172);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 66;
            label5.Text = "CCCD:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(874, 127);
            label3.Name = "label3";
            label3.Size = new Size(88, 19);
            label3.TabIndex = 64;
            label3.Text = "Công việc:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(575, 172);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 63;
            label2.Text = "Trạng thái:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(183, 37);
            label1.Name = "label1";
            label1.Size = new Size(33, 19);
            label1.TabIndex = 62;
            label1.Text = "ID:";
            // 
            // comboBox_QLNV_TD
            // 
            comboBox_QLNV_TD.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox_QLNV_TD.FormattingEnabled = true;
            comboBox_QLNV_TD.Location = new Point(969, 77);
            comboBox_QLNV_TD.Name = "comboBox_QLNV_TD";
            comboBox_QLNV_TD.Size = new Size(63, 28);
            comboBox_QLNV_TD.TabIndex = 61;
            // 
            // comboBox_QLNV_CV
            // 
            comboBox_QLNV_CV.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox_QLNV_CV.FormattingEnabled = true;
            comboBox_QLNV_CV.Location = new Point(969, 121);
            comboBox_QLNV_CV.Name = "comboBox_QLNV_CV";
            comboBox_QLNV_CV.Size = new Size(63, 28);
            comboBox_QLNV_CV.TabIndex = 59;
            // 
            // textBox_QLNV_SDT
            // 
            textBox_QLNV_SDT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_QLNV_SDT.Location = new Point(252, 123);
            textBox_QLNV_SDT.Name = "textBox_QLNV_SDT";
            textBox_QLNV_SDT.Size = new Size(305, 28);
            textBox_QLNV_SDT.TabIndex = 58;
            // 
            // textBox_QLNV_CCCD
            // 
            textBox_QLNV_CCCD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_QLNV_CCCD.Location = new Point(252, 168);
            textBox_QLNV_CCCD.Name = "textBox_QLNV_CCCD";
            textBox_QLNV_CCCD.Size = new Size(305, 28);
            textBox_QLNV_CCCD.TabIndex = 57;
            // 
            // textBox_QLNV_TenNV
            // 
            textBox_QLNV_TenNV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_QLNV_TenNV.Location = new Point(252, 78);
            textBox_QLNV_TenNV.Name = "textBox_QLNV_TenNV";
            textBox_QLNV_TenNV.Size = new Size(305, 28);
            textBox_QLNV_TenNV.TabIndex = 56;
            // 
            // textBox_QLNV_ID
            // 
            textBox_QLNV_ID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_QLNV_ID.Location = new Point(252, 34);
            textBox_QLNV_ID.Name = "textBox_QLNV_ID";
            textBox_QLNV_ID.ReadOnly = true;
            textBox_QLNV_ID.Size = new Size(305, 28);
            textBox_QLNV_ID.TabIndex = 55;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button_QLNV_ChonAnh);
            groupBox2.Controls.Add(pictureBox_QLNV);
            groupBox2.Location = new Point(7, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(170, 254);
            groupBox2.TabIndex = 54;
            groupBox2.TabStop = false;
            // 
            // button_QLNV_ChonAnh
            // 
            button_QLNV_ChonAnh.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_QLNV_ChonAnh.ForeColor = SystemColors.HotTrack;
            button_QLNV_ChonAnh.Location = new Point(6, 222);
            button_QLNV_ChonAnh.Name = "button_QLNV_ChonAnh";
            button_QLNV_ChonAnh.Size = new Size(158, 29);
            button_QLNV_ChonAnh.TabIndex = 1;
            button_QLNV_ChonAnh.Text = "Chọn ảnh";
            button_QLNV_ChonAnh.UseVisualStyleBackColor = true;
            button_QLNV_ChonAnh.Click += button_QLNV_ChonAnh_Click;
            // 
            // pictureBox_QLNV
            // 
            pictureBox_QLNV.Location = new Point(6, 14);
            pictureBox_QLNV.Name = "pictureBox_QLNV";
            pictureBox_QLNV.Size = new Size(158, 202);
            pictureBox_QLNV.TabIndex = 0;
            pictureBox_QLNV.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(groupBox3);
            panel3.Location = new Point(1, 458);
            panel3.Name = "panel3";
            panel3.Size = new Size(798, 112);
            panel3.TabIndex = 8;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(textBox_TimKiem);
            groupBox3.Controls.Add(button_TimKiem);
            groupBox3.Controls.Add(button_QLNV_Sua);
            groupBox3.Controls.Add(button_QLNV_XuatFlie);
            groupBox3.Controls.Add(button_QLNV_Them);
            groupBox3.Controls.Add(button_QLNV_LamMoi);
            groupBox3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(0, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(798, 109);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // textBox_TimKiem
            // 
            textBox_TimKiem.Anchor = AnchorStyles.None;
            textBox_TimKiem.Location = new Point(622, 24);
            textBox_TimKiem.Name = "textBox_TimKiem";
            textBox_TimKiem.Size = new Size(170, 28);
            textBox_TimKiem.TabIndex = 74;
            // 
            // button_TimKiem
            // 
            button_TimKiem.Anchor = AnchorStyles.None;
            button_TimKiem.BackColor = Color.WhiteSmoke;
            button_TimKiem.FlatAppearance.BorderSize = 2;
            button_TimKiem.FlatAppearance.CheckedBackColor = Color.Transparent;
            button_TimKiem.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise;
            button_TimKiem.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            button_TimKiem.FlatStyle = FlatStyle.Flat;
            button_TimKiem.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            button_TimKiem.ForeColor = Color.SteelBlue;
            button_TimKiem.Image = (Image)resources.GetObject("button_TimKiem.Image");
            button_TimKiem.Location = new Point(622, 58);
            button_TimKiem.Name = "button_TimKiem";
            button_TimKiem.Size = new Size(170, 42);
            button_TimKiem.TabIndex = 73;
            button_TimKiem.Text = "Tìm kiếm";
            button_TimKiem.TextAlign = ContentAlignment.MiddleRight;
            button_TimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_TimKiem.UseVisualStyleBackColor = false;
            button_TimKiem.Click += button_TimKiem_Click;
            // 
            // button_QLNV_Sua
            // 
            button_QLNV_Sua.Anchor = AnchorStyles.None;
            button_QLNV_Sua.BackColor = Color.WhiteSmoke;
            button_QLNV_Sua.FlatAppearance.BorderSize = 2;
            button_QLNV_Sua.FlatAppearance.CheckedBackColor = Color.Transparent;
            button_QLNV_Sua.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise;
            button_QLNV_Sua.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            button_QLNV_Sua.FlatStyle = FlatStyle.Flat;
            button_QLNV_Sua.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            button_QLNV_Sua.ForeColor = Color.SteelBlue;
            button_QLNV_Sua.Image = (Image)resources.GetObject("button_QLNV_Sua.Image");
            button_QLNV_Sua.Location = new Point(162, 26);
            button_QLNV_Sua.Name = "button_QLNV_Sua";
            button_QLNV_Sua.Size = new Size(96, 76);
            button_QLNV_Sua.TabIndex = 68;
            button_QLNV_Sua.Text = "Sửa";
            button_QLNV_Sua.TextAlign = ContentAlignment.MiddleRight;
            button_QLNV_Sua.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_QLNV_Sua.UseVisualStyleBackColor = false;
            button_QLNV_Sua.Click += button_QLNV_Sua_Click;
            // 
            // button_QLNV_XuatFlie
            // 
            button_QLNV_XuatFlie.Anchor = AnchorStyles.None;
            button_QLNV_XuatFlie.BackColor = Color.WhiteSmoke;
            button_QLNV_XuatFlie.FlatAppearance.BorderSize = 2;
            button_QLNV_XuatFlie.FlatAppearance.CheckedBackColor = Color.Transparent;
            button_QLNV_XuatFlie.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise;
            button_QLNV_XuatFlie.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            button_QLNV_XuatFlie.FlatStyle = FlatStyle.Flat;
            button_QLNV_XuatFlie.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            button_QLNV_XuatFlie.ForeColor = Color.SteelBlue;
            button_QLNV_XuatFlie.Image = (Image)resources.GetObject("button_QLNV_XuatFlie.Image");
            button_QLNV_XuatFlie.Location = new Point(469, 24);
            button_QLNV_XuatFlie.Name = "button_QLNV_XuatFlie";
            button_QLNV_XuatFlie.Size = new Size(98, 76);
            button_QLNV_XuatFlie.TabIndex = 69;
            button_QLNV_XuatFlie.Text = "Xuất file";
            button_QLNV_XuatFlie.TextAlign = ContentAlignment.MiddleRight;
            button_QLNV_XuatFlie.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_QLNV_XuatFlie.UseVisualStyleBackColor = false;
            button_QLNV_XuatFlie.Click += button_QLNV_XuatFlie_Click;
            // 
            // button_QLNV_Them
            // 
            button_QLNV_Them.Anchor = AnchorStyles.None;
            button_QLNV_Them.BackColor = Color.WhiteSmoke;
            button_QLNV_Them.FlatAppearance.BorderSize = 2;
            button_QLNV_Them.FlatAppearance.CheckedBackColor = Color.Transparent;
            button_QLNV_Them.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise;
            button_QLNV_Them.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            button_QLNV_Them.FlatStyle = FlatStyle.Flat;
            button_QLNV_Them.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            button_QLNV_Them.ForeColor = Color.SteelBlue;
            button_QLNV_Them.Image = (Image)resources.GetObject("button_QLNV_Them.Image");
            button_QLNV_Them.Location = new Point(4, 26);
            button_QLNV_Them.Name = "button_QLNV_Them";
            button_QLNV_Them.Size = new Size(99, 76);
            button_QLNV_Them.TabIndex = 67;
            button_QLNV_Them.Text = "Thêm";
            button_QLNV_Them.TextAlign = ContentAlignment.MiddleRight;
            button_QLNV_Them.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_QLNV_Them.UseVisualStyleBackColor = false;
            button_QLNV_Them.Click += button_QLNV_Them_Click;
            // 
            // button_QLNV_LamMoi
            // 
            button_QLNV_LamMoi.Anchor = AnchorStyles.None;
            button_QLNV_LamMoi.BackColor = Color.WhiteSmoke;
            button_QLNV_LamMoi.FlatAppearance.BorderSize = 2;
            button_QLNV_LamMoi.FlatAppearance.CheckedBackColor = Color.Transparent;
            button_QLNV_LamMoi.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise;
            button_QLNV_LamMoi.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            button_QLNV_LamMoi.FlatStyle = FlatStyle.Flat;
            button_QLNV_LamMoi.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            button_QLNV_LamMoi.ForeColor = Color.SteelBlue;
            button_QLNV_LamMoi.Image = (Image)resources.GetObject("button_QLNV_LamMoi.Image");
            button_QLNV_LamMoi.Location = new Point(315, 26);
            button_QLNV_LamMoi.Name = "button_QLNV_LamMoi";
            button_QLNV_LamMoi.Size = new Size(99, 76);
            button_QLNV_LamMoi.TabIndex = 70;
            button_QLNV_LamMoi.Text = "Làm mới";
            button_QLNV_LamMoi.TextAlign = ContentAlignment.MiddleRight;
            button_QLNV_LamMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_QLNV_LamMoi.UseVisualStyleBackColor = false;
            button_QLNV_LamMoi.Click += button_QLNV_LamMoi_Click;
            // 
            // button_QLNV_TinhLuong
            // 
            button_QLNV_TinhLuong.Anchor = AnchorStyles.None;
            button_QLNV_TinhLuong.BackColor = Color.WhiteSmoke;
            button_QLNV_TinhLuong.FlatAppearance.BorderSize = 2;
            button_QLNV_TinhLuong.FlatAppearance.CheckedBackColor = Color.Transparent;
            button_QLNV_TinhLuong.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise;
            button_QLNV_TinhLuong.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            button_QLNV_TinhLuong.FlatStyle = FlatStyle.Flat;
            button_QLNV_TinhLuong.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            button_QLNV_TinhLuong.ForeColor = Color.SteelBlue;
            button_QLNV_TinhLuong.Location = new Point(9, 65);
            button_QLNV_TinhLuong.Name = "button_QLNV_TinhLuong";
            button_QLNV_TinhLuong.Size = new Size(226, 37);
            button_QLNV_TinhLuong.TabIndex = 0;
            button_QLNV_TinhLuong.Text = "Tính lương";
            button_QLNV_TinhLuong.UseVisualStyleBackColor = false;
            button_QLNV_TinhLuong.Click += button_QLNV_TinhLuong_Click;
            // 
            // textBox_QLNV_TinhLuong
            // 
            textBox_QLNV_TinhLuong.Anchor = AnchorStyles.None;
            textBox_QLNV_TinhLuong.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_QLNV_TinhLuong.ForeColor = SystemColors.HotTrack;
            textBox_QLNV_TinhLuong.Location = new Point(9, 25);
            textBox_QLNV_TinhLuong.Name = "textBox_QLNV_TinhLuong";
            textBox_QLNV_TinhLuong.Size = new Size(226, 34);
            textBox_QLNV_TinhLuong.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox_QLNV_TinhLuong);
            groupBox4.Controls.Add(button_QLNV_TinhLuong);
            groupBox4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            groupBox4.Location = new Point(0, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(244, 109);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tính lương";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.Controls.Add(groupBox4);
            panel4.Location = new Point(805, 458);
            panel4.Name = "panel4";
            panel4.Size = new Size(244, 112);
            panel4.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dataGridView_QLNV);
            panel2.Location = new Point(3, 287);
            panel2.Name = "panel2";
            panel2.Size = new Size(1043, 165);
            panel2.TabIndex = 11;
            // 
            // dataGridView_QLNV
            // 
            dataGridView_QLNV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_QLNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView_QLNV.BackgroundColor = Color.White;
            dataGridView_QLNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_QLNV.Location = new Point(0, 0);
            dataGridView_QLNV.Name = "dataGridView_QLNV";
            dataGridView_QLNV.ReadOnly = true;
            dataGridView_QLNV.RowHeadersWidth = 51;
            dataGridView_QLNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_QLNV.Size = new Size(1043, 165);
            dataGridView_QLNV.TabIndex = 0;
            dataGridView_QLNV.CellClick += dataGridView_QLNV_CellClick_1;
            // 
            // UC_QLNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Name = "UC_QLNhanVien";
            Size = new Size(1049, 570);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_QLNV).EndInit();
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_QLNV).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel3;
        private Button button_QLNV_TinhLuong;
        private TextBox textBox_QLNV_TinhLuong;
        private GroupBox groupBox4;
        private Panel panel4;
        private GroupBox groupBox3;
        private Button button_QLNV_Sua;
        private Button button_QLNV_XuatFlie;
        private Button button_QLNV_Them;
        private Button button_QLNV_LamMoi;
        private GroupBox groupBox1;
        private Label label13;
        private ComboBox comboBox_QLNV_GT;
        private DateTimePicker dateTimePicker_QLNV_NgaySinh;
        private Label label12;
        private ComboBox comboBox_QLNV_VT;
        private ComboBox comboBox_QLNV_TT;
        private Label label11;
        private Label label10;
        private TextBox textBox_QLNV_DiaChi;
        private Label label9;
        private TextBox textBox_QLNV_TienPC;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox_QLNV_TD;
        private ComboBox comboBox_QLNV_PB;
        private ComboBox comboBox_QLNV_CV;
        private TextBox textBox_QLNV_SDT;
        private TextBox textBox_QLNV_CCCD;
        private TextBox textBox_QLNV_TenNV;
        private TextBox textBox_QLNV_ID;
        private GroupBox groupBox2;
        private Button button_QLNV_ChonAnh;
        private PictureBox pictureBox_QLNV;
        private TextBox textBox_TimKiem;
        private Button button_TimKiem;
        private Label IDTaiKhoan;
        private ComboBox comboBox_IDTaiKhoan;
        private Panel panel2;
        private DataGridView dataGridView_QLNV;
    }
}
