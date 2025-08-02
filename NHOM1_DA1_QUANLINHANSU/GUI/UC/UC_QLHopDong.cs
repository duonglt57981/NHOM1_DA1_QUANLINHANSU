using Microsoft.IdentityModel.Tokens;
using NHOM1_DA1_QUANLINHANSU.BLL;
using NHOM1_DA1_QUANLINHANSU.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM1_DA1_QUANLINHANSU.GUI.UC
{
    public partial class UC_QLHopDong : UserControl
    {

        private BLL_QLHopDong QLHD_BLL = new BLL_QLHopDong();
        public UC_QLHopDong()
        {
            InitializeComponent();
            LoadHD();
            LoadLoaiHD();
            LoadTrangThai();
            LoadThongTinNV();
        }

        public void LoadHD()
        {
            dataGridView_QLHD.DataSource = QLHD_BLL.GetAllHopDong();
        }

        public void LoadLoaiHD()
        {
            comboBox_QLHD_LoaiHopDong.DataSource = QLHD_BLL.GetAllLoaiHopDong();
            comboBox_QLHD_LoaiHopDong.DisplayMember = "TenHopDong";
            comboBox_QLHD_LoaiHopDong.ValueMember = "IdloaiHopDong";
        }

        public void LoadTrangThai()
        {
            comboBox_QLHD_TrangThai.Items.Add("Còn Hạn");
            comboBox_QLHD_TrangThai.Items.Add("Hết Hạn");
            comboBox_QLHD_TrangThai.Items.Add("Khác");
            comboBox_QLHD_TrangThai.SelectedIndex = 0;
        }

        public void ThongTinNhanVien(Nhanvien nv)
        {
            textBox_QLHD_HoTen.Text = nv.TenNv;
            textBox_QLHD_SDT.Text = nv.Sdt;
            textBox_QLHD_CCCD.Text = nv.Cccd;
            textBox_QLHD_DC.Text = nv.DiaChi;
        }

        public void LoadThongTinNV()
        {
            comboBox_QLHD_IDNV.DataSource = QLHD_BLL.GetAllNhanVien();
            var index = QLHD_BLL.GetAllNhanVien();
            comboBox_QLHD_IDNV.ValueMember = "Idnv";
            comboBox_QLHD_IDNV.DisplayMember = "Idnv";

            comboBox_QLHD_IDNV.SelectedIndexChanged += new EventHandler(comboBox_QLHD_IDNV_SelectedIndexChanged);

            ThongTinNhanVien(index[0]);
        }

        private void comboBox_QLHD_IDNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string IDNV = comboBox_QLHD_IDNV.SelectedValue.ToString();
            Nhanvien nv = QLHD_BLL.GetAllNhanVien().FirstOrDefault(n => n.Idnv.ToString() == IDNV);

            if (nv != null)
            {
                ThongTinNhanVien(nv);
            }
        }


        private void button_QLNV_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_QLHD_ThoiHan.Text)
                || string.IsNullOrEmpty(textBox_QLHD_HeSoLuong.Text)
                || string.IsNullOrEmpty(textBox_QLHD_LanKi.Text)
                || string.IsNullOrEmpty(textBox_QLHD_LuongCB.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin hợp đồng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Hopdong hd = new Hopdong
            {
                NgayBd = DateOnly.FromDateTime(dateTimePicker_QLHD_NgayBD.Value),
                NgayKt = DateOnly.FromDateTime(dateTimePicker_QLHD_NgayKT.Value),
                NgayKiHopDong = DateOnly.FromDateTime(dateTimePicker_NgayKiHD.Value),
                IdloaiHd = (int)comboBox_QLHD_LoaiHopDong.SelectedValue,
                TrangThai = comboBox_QLHD_TrangThai.SelectedItem.ToString(),
                ThoiHan = textBox_QLHD_ThoiHan.Text,
                HeSoLuong = double.Parse(textBox_QLHD_HeSoLuong.Text),
                LuongCoBan = double.Parse(textBox_QLHD_LuongCB.Text),
                LanKi = int.Parse(textBox_QLHD_LanKi.Text),
                NoiDung = textBox_NoiDung.Text,
                Idnv = int.Parse(comboBox_QLHD_IDNV.Text)
            };

        }

        private void button_QLNV_Sua_Click(object sender, EventArgs e)
        {

        }

        private void button_QLNV_LamMoi_Click(object sender, EventArgs e)
        {

        }

        private void button_QLNV_XuatFlie_Click(object sender, EventArgs e)
        {

        }

        private void button_QLNV_TimKiem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_QLHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void UC_QLHopDong_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
