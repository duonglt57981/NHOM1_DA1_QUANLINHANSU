
using NHOM1_DA1_QUANLINHANSU.BLL;
using NHOM1_DA1_QUANLINHANSU.DAL;
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
        private QLNhanVien_BLL QLNV_BLL = new QLNhanVien_BLL();
        private byte[] hinhAnhByte = null;
        public UC_QLNhanVien()
        {
            InitializeComponent();
            LoadNV();
            LoadPhongban();
            LoadTrinhDo();
            LoadCongViec();
            LoadVaiTro();
            LoadTrangThai();
            LoadGioiTinh();
        }

        public void LoadNV()
        {
            dataGridView_QLNV.DataSource = QLNV_BLL.GetAllNhanVien();
        }

        public void LoadPhongban()
        {
            comboBox_QLNV_PB.DataSource = QLNV_BLL.GetPhongban();
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

        public void LoadVaiTro()
        {
            comboBox_QLNV_VT.DataSource = QLNV_BLL.GetVaiTro();
            comboBox_QLNV_VT.DisplayMember = "TenVaiTro";
            comboBox_QLNV_VT.ValueMember = "IdvaiTro";
        }

        public void LoadTrangThai()
        {
            comboBox_QLNV_TT.Items.Add("Hoạt Động");
            comboBox_QLNV_TT.Items.Add("Không Hoạt Động");
            comboBox_QLNV_TT.Items.Add("Khác");
        }

        public void LoadGioiTinh()
        {
            comboBox_QLNV_GT.Items.Add("Nam");
            comboBox_QLNV_GT.Items.Add("Nữ");
            comboBox_QLNV_GT.Items.Add("Khác");
        }

        private void button_QLNV_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_QLNV_TenNV.Text)
        || string.IsNullOrEmpty(textBox_QLNV_SDT.Text)
        || string.IsNullOrEmpty(textBox_QLNV_CCCD.Text)
        || string.IsNullOrEmpty(textBox_QLNV_TienPC.Text)
        || string.IsNullOrEmpty(textBox_QLNV_DiaChi.Text))
            {
                MessageBox.Show("Vui lòng không để trống các trường thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ;

            if (textBox_QLNV_SDT.TextLength < 10)
            {
                MessageBox.Show("Bạn nhập sai số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (textBox_QLNV_SDT.TextLength > 10)
            {
                MessageBox.Show("Bạn nhập sai số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ;

            var nv = new Nhanvien
            {
                TenNv = textBox_QLNV_TenNV.Text,
                NgaySinh = DateOnly.FromDateTime(dateTimePicker_QLNV_NgaySinh.Value),
                GioiTinh = comboBox_QLNV_GT.Text,
                Sdt = textBox_QLNV_SDT.Text,
                Cccd = textBox_QLNV_CCCD.Text,
                SoTienPhuCap = float.Parse(textBox_QLNV_TienPC.Text),
                TrangThai = comboBox_QLNV_TT.SelectedItem.ToString(),
                DiaChi = textBox_QLNV_DiaChi.Text,
                HinhAnh = hinhAnhByte,
                IdphongBan = (int)comboBox_QLNV_PB.SelectedValue,
                IdcongViec = (int)comboBox_QLNV_CV.SelectedValue,
                IdtrinhDo = (int)comboBox_QLNV_TD.SelectedValue,
                IdvaiTro = (int)comboBox_QLNV_VT.SelectedValue
            };

            QLNV_BLL.AddNhanVien(nv);
            LoadNV();
        }

        private void button_QLNV_ChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox__QLNV.Image = Image.FromFile(ofd.FileName);
                pictureBox__QLNV.SizeMode = PictureBoxSizeMode.StretchImage;

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

            using (var _dbct = new Nhom1Da1QlnhansuContext())
            {
                var nv = _dbct.Nhanviens.FirstOrDefault(n => n.Idnv == Idnv);

                if (nv.HinhAnh != null || nv.HinhAnh.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(nv.HinhAnh))
                    {
                        pictureBox__QLNV.Image = Image.FromStream(ms);
                        pictureBox__QLNV.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    pictureBox__QLNV.Image = null;
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
            comboBox_QLNV_VT.Text = dataGridView_QLNV.Rows[e.RowIndex].Cells["TenVaiTro"].Value.ToString();
        }

        private void comboBox_QLNV_VT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_QLNV_LamMoi_Click(object sender, EventArgs e)
        {

        }

        private void UC_QLNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
