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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            button_QLHopDong = new Button();
            button_QLNhanVien = new Button();
            panelMain = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(287, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 37);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(349, 8);
            label1.Name = "label1";
            label1.Size = new Size(245, 23);
            label1.TabIndex = 0;
            label1.Text = "Hệ Thống Quản Lí Nhân Sự";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button_QLHopDong);
            panel2.Controls.Add(button_QLNhanVien);
            panel2.Location = new Point(1, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(287, 556);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button2.Location = new Point(3, 107);
            button2.Name = "button2";
            button2.Size = new Size(279, 46);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button_QLHopDong
            // 
            button_QLHopDong.BackColor = Color.DeepSkyBlue;
            button_QLHopDong.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button_QLHopDong.Location = new Point(3, 55);
            button_QLHopDong.Name = "button_QLHopDong";
            button_QLHopDong.Size = new Size(279, 46);
            button_QLHopDong.TabIndex = 2;
            button_QLHopDong.Text = "QUẢN LÍ HỢP ĐỒNG";
            button_QLHopDong.UseVisualStyleBackColor = false;
            button_QLHopDong.Click += button_QLHopDong_Click_1;
            // 
            // button_QLNhanVien
            // 
            button_QLNhanVien.BackColor = Color.DeepSkyBlue;
            button_QLNhanVien.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button_QLNhanVien.Location = new Point(3, 3);
            button_QLNhanVien.Name = "button_QLNhanVien";
            button_QLNhanVien.Size = new Size(279, 46);
            button_QLNhanVien.TabIndex = 1;
            button_QLNhanVien.Text = "QUẢN LÍ NHÂN SỰ";
            button_QLNhanVien.UseVisualStyleBackColor = false;
            button_QLNhanVien.Click += button_QLNhanVien_Click;
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.Location = new Point(294, 44);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(945, 556);
            panelMain.TabIndex = 2;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1240, 599);
            Controls.Add(panelMain);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TrangChu";
            Text = "TrangChu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button2;
        private Button button_QLHopDong;
        private Button button_QLNhanVien;
        private Label label1;
        private Panel panelMain;
    }
}