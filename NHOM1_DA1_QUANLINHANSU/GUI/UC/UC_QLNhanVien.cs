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
    public partial class UC_QLNhanVien : UserControl
    {
        private BLL.BLL_QLNhanVien QLNV_BLL = new BLL.BLL_QLNhanVien();
        private byte[] hinhAnhByte = null;
        public UC_QLNhanVien()
        {
            InitializeComponent();
            LoadNV();
            LoadCongViec();
            LoadTrinhDo();
            LoadTrangThai();
            LoadGioiTinh();
        }

        public void LoadNV()
        {
            dataGridView_QLNV.DataSource = QLNV_BLL.GetAllNhanVien();
        }

        public void LoadPhongBan()
        {
            comboBox_QLNV_PB.DataSource = QLNV_BLL.GetPhongBAN();
            comboBox_QLNV_PB.DisplayMember = "TenPhongBan";
            comboBox_QLNV_PB.ValueMember = "IdphongBan";
        }

        public void LoadCongViec()
        {
            comboBox_QLNV_CV.DataSource = QLNV_BLL.GetCongViec();
            comboBox_QLNV_CV.DisplayMember = "TenCongViec";
            comboBox_QLNV_CV.ValueMember = "IdcongViec";
        }

        public void LoadTrinhDo()
        {
            comboBox_QLNV_TD.DataSource = QLNV_BLL.GetTrinhDo();
            comboBox_QLNV_TD.DisplayMember = "TenTrinhDo";
            comboBox_QLNV_TD.ValueMember = "IdtrinhDo";
        }

        public void LoadTrangThai()
        {
            comboBox_QLNV_TT.Items.Add("Hoạt Động");
            comboBox_QLNV_TT.Items.Add("Không Hoạt Động");
            comboBox_QLNV_TT.SelectedIndex = 0;
        }

        public void LoadGioiTinh()
        {
            comboBox_QLNV_GT.Items.Add("Nam");
            comboBox_QLNV_GT.Items.Add("Nữ");
            comboBox_QLNV_GT.Items.Add("Khác");
            comboBox_QLNV_GT.SelectedIndex = 0;
        }

        public void LoadID()
        {
            comboBox_IDTaiKhoan.DataSource = IDTaiKhoan;
        }

        private void button_QLNV_Them_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_QLNV_TenNV.Text)
                || !string.IsNullOrEmpty(textBox_QLNV_SDT.Text)
                || !string.IsNullOrEmpty(textBox_QLNV_CCCD.Text)
                || !string.IsNullOrEmpty(textBox_QLNV_TienPC.Text)
                || !string.IsNullOrEmpty(comboBox_QLNV_TT.Text)
                || !string.IsNullOrEmpty(comboBox_QLNV_GT.Text)
                || !string.IsNullOrEmpty(comboBox_QLNV_PB.Text)
                || !string.IsNullOrEmpty(comboBox_QLNV_CV.Text)
                || !string.IsNullOrEmpty(comboBox_QLNV_TD.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox_QLNV_SDT.TextLength > 10 || textBox_QLNV_SDT.TextLength < 10)
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox_QLNV_CCCD.TextLength > 12 || textBox_QLNV_CCCD.TextLength < 12)
            {
                MessageBox.Show("Vui lòng nhập đúng số CCCD", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (hinhAnhByte == null || hinhAnhByte.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn hình ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Nhanvien nv = new Nhanvien
            {
                TenNv = textBox_QLNV_TenNV.Text,
                GioiTinh = comboBox_QLNV_GT.Text,
                NgaySinh = DateOnly.FromDateTime(dateTimePicker_QLNV_NgaySinh.Value),
                Sdt = textBox_QLNV_SDT.Text,
                Cccd = textBox_QLNV_CCCD.Text,
                DiaChi = textBox_QLNV_DiaChi.Text,
                HinhAnh = hinhAnhByte,
                SoTienPhuCap = float.Parse(textBox_QLNV_TienPC.Text),
                TrangThai = comboBox_QLNV_TT.Text,
                IdphongBan = (int)comboBox_QLNV_PB.SelectedValue,
                IdcongViec = (int)comboBox_QLNV_CV.SelectedValue,
                IdtrinhDo = (int)comboBox_QLNV_TD.SelectedValue
            };

            QLNV_BLL.ThemNhanVien(nv);

        }

        private void button_QLNV_ChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_QLNV.Image = Image.FromFile(ofd.FileName);
                pictureBox_QLNV.SizeMode = PictureBoxSizeMode.StretchImage;

                // đọc ảnh thành byte
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        hinhAnhByte = br.ReadBytes((int)fs.Length);
                    }
                }
            }
        }

        private void dataGridView_QLNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Idnv = (int)dataGridView_QLNV.Rows[e.RowIndex].Cells["Idnv"].Value;

            using (var _db = new Nhom1Da1QlnsContext())
            {
                var nv = _db.Nhanviens.FirstOrDefault(n => n.Idnv == Idnv);

                if (nv.HinhAnh != null || nv.HinhAnh.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(nv.HinhAnh))
                    {
                        pictureBox_QLNV.Image = Image.FromStream(ms);
                        pictureBox_QLNV.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    pictureBox_QLNV.Image = null;
                }
            }
            textBox_QLNV_ID.Text = dataGridView_QLNV.Rows[e.RowIndex].Cells["Idnv"].Value.ToString();
            textBox_QLNV_TenNV.Text = dataGridView_QLNV.Rows[e.RowIndex].Cells["TenNv"].Value.ToString();
            comboBox_QLNV_GT.Text = dataGridView_QLNV.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
            dateTimePicker_QLNV_NgaySinh.Text = dataGridView_QLNV.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
            textBox_QLNV_SDT.Text = dataGridView_QLNV.Rows[e.RowIndex].Cells["Sdt"].Value.ToString();
            textBox_QLNV_CCCD.Text = dataGridView_QLNV.Rows[e.RowIndex].Cells["Cccd"].Value.ToString();
            textBox_QLNV_DiaChi.Text = dataGridView_QLNV.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            textBox_QLNV_TienPC.Text = dataGridView_QLNV.Rows[e.RowIndex].Cells["SoTienPhuCap"].Value.ToString();
            comboBox_QLNV_TT.Text = dataGridView_QLNV.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();
            comboBox_QLNV_PB.Text = dataGridView_QLNV.Rows[e.RowIndex].Cells["TenPhongBan"].Value.ToString();
            comboBox_QLNV_TD.Text = dataGridView_QLNV.Rows[e.RowIndex].Cells["TenTrinhDo"].Value.ToString();
            comboBox_QLNV_CV.Text = dataGridView_QLNV.Rows[e.RowIndex].Cells["TenCongViec"].Value.ToString();
            comboBox_IDTaiKhoan.Text = dataGridView_QLNV.Rows[e.RowIndex].Cells["IdtaiKhoan"].Value.ToString();

        }

        private void button_QLNV_LamMoi_Click(object sender, EventArgs e)
        {
            textBox_QLNV_TenNV.Clear();
            textBox_QLNV_SDT.Clear();
            textBox_QLNV_CCCD.Clear();
            textBox_QLNV_DiaChi.Clear();
        }

        private void button_QLNV_Sua_Click(object sender, EventArgs e)
        {

        }

        private void button_QLNV_XuatFlie_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button_QLNV_TinhLuong_Click(object sender, EventArgs e)
        {

        }
    }

}
