using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM1_DA1_QUANLINHANSU.GUI
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void LoadUC(UserControl uc)
        {
            panelMain.Controls.Clear(); // Xóa control cũ
            uc.Dock = DockStyle.Fill;   // Cho UserControl chiếm toàn bộ panel
            panelMain.Controls.Add(uc); // Thêm vào panel
        }


        private void button_QLHopDong_Click_1(object sender, EventArgs e)
        {
            LoadUC(new UC.UC_QLHopDong());
        }

        private void button_QLNhanVien_Click(object sender, EventArgs e)
        {
            LoadUC(new UC.UC_QLNhanVien());
        }
    }
}
