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
            tabPage2 = new TabPage();
            tàiKhoảnToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
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
            tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLíTàiKhoảnToolStripMenuItem, quênMậtKhẩuToolStripMenuItem, đăngXuấtToolStripMenuItem, tàiKhoảnToolStripMenuItem1 });
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
            quảnLíTàiKhoảnToolStripMenuItem.Size = new Size(224, 26);
            quảnLíTàiKhoảnToolStripMenuItem.Text = "Quản lí tài khoản";
            // 
            // quênMậtKhẩuToolStripMenuItem
            // 
            quênMậtKhẩuToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            quênMậtKhẩuToolStripMenuItem.Name = "quênMậtKhẩuToolStripMenuItem";
            quênMậtKhẩuToolStripMenuItem.Size = new Size(224, 26);
            quênMậtKhẩuToolStripMenuItem.Text = "Quên mật khẩu";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            đăngXuấtToolStripMenuItem.ForeColor = SystemColors.ControlText;
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(224, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 31);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1181, 570);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1173, 537);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản lí nhân viên";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1173, 537);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tàiKhoảnToolStripMenuItem1
            // 
            tàiKhoảnToolStripMenuItem1.Name = "tàiKhoảnToolStripMenuItem1";
            tàiKhoảnToolStripMenuItem1.Size = new Size(224, 28);
            tàiKhoảnToolStripMenuItem1.Text = "Tài Khoản";
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 601);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TrangChu";
            Text = "TrangChu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
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
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem1;
    }
}