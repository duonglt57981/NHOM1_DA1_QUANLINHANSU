using NHOM1_DA1_QUANLINHANSU.GUI.UC;
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

            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }


        private void button_QLHopDong_Click_1(object sender, EventArgs e)
        {
            LoadUC(new UC.UC_QLHopDong());
        }

        private void button_QLNhanVien_Click(object sender, EventArgs e)
        {
            LoadUC(new UC.UC_QLNhanVien());
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            UC_Default defaultUC = new UC_Default(); 
            if (!panelMain.Controls.Contains(defaultUC))
            {
                panelMain.Controls.Add(defaultUC);
                defaultUC.Dock = DockStyle.Fill;
                defaultUC.BringToFront();
            }
            else
            {
                panelMain.Controls[0].BringToFront(); 
            }
        }
        
    }
}
