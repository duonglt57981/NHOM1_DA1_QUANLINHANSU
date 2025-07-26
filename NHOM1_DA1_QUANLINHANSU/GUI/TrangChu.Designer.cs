namespace NHOM1_DA1_QUANLINHANSU.GUI
{
    partial class TrangChu
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
            menuStrip1 = new MenuStrip();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            quảnLíTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            quênMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            uC_qlNhanVien1 = new NHOM1_DA1_QUANLINHANSU.GUI.UC.UC_QLNhanVien();
            tabPage2 = new TabPage();
            sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            uC_qlHopDong1 = new NHOM1_DA1_QUANLINHANSU.GUI.UC.UC_QLHopDong();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1181, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLíTàiKhoảnToolStripMenuItem, quênMậtKhẩuToolStripMenuItem, đăngXuấtToolStripMenuItem });
            tàiKhoảnToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tàiKhoảnToolStripMenuItem.ForeColor = SystemColors.HotTrack;
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(111, 27);
            tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // quảnLíTàiKhoảnToolStripMenuItem
            // 
            quảnLíTàiKhoảnToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            quảnLíTàiKhoảnToolStripMenuItem.Name = "quảnLíTàiKhoảnToolStripMenuItem";
            quảnLíTàiKhoảnToolStripMenuItem.Size = new Size(217, 26);
            quảnLíTàiKhoảnToolStripMenuItem.Text = "Quản lí tài khoản";
            // 
            // quênMậtKhẩuToolStripMenuItem
            // 
            quênMậtKhẩuToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            quênMậtKhẩuToolStripMenuItem.Name = "quênMậtKhẩuToolStripMenuItem";
            quênMậtKhẩuToolStripMenuItem.Size = new Size(217, 26);
            quênMậtKhẩuToolStripMenuItem.Text = "Quên mật khẩu";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            đăngXuấtToolStripMenuItem.ForeColor = SystemColors.ControlText;
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(217, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 31);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1181, 570);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(uC_qlNhanVien1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1173, 537);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản lí nhân viên";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // uC_qlNhanVien1
            // 
            uC_qlNhanVien1.Dock = DockStyle.Fill;
            uC_qlNhanVien1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uC_qlNhanVien1.Location = new Point(3, 3);
            uC_qlNhanVien1.Name = "uC_qlNhanVien1";
            uC_qlNhanVien1.Size = new Size(1167, 531);
            uC_qlNhanVien1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(uC_qlHopDong1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1173, 537);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Quản lí hợp đồng";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // uC_qlHopDong1
            // 
            uC_qlHopDong1.Dock = DockStyle.Fill;
            uC_qlHopDong1.Location = new Point(3, 3);
            uC_qlHopDong1.Name = "uC_qlHopDong1";
            uC_qlHopDong1.Size = new Size(1167, 531);
            uC_qlHopDong1.TabIndex = 0;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 601);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.HotTrack;
            MainMenuStrip = menuStrip1;
            Name = "TrangChu";
            Text = "Hệ thống quản lí nhân sự";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem quảnLíTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem quênMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private UC.UC_QLNhanVien uC_qlNhanVien1;
        private UC.UC_QLHopDong uC_qlHopDong1;
    }
}