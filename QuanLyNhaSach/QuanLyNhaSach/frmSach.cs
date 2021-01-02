using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ET_QLNS;
using BUS_QLNS;
namespace QuanLyNhaSach
{
    public partial class frmSach : Form
    {
        BUS_Sach bus_sach = new BUS_Sach();

        public frmSach()
        {
            InitializeComponent();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            BUS_GiangHang bus_GH = new BUS_GiangHang();
            cboGH.DataSource = bus_GH.getGH();
            cboGH.ValueMember = "MaGH";
            cboGH.DisplayMember = "TenGH";
            dgvSach.DataSource = bus_sach.getSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_Sach et_Sach = null;
            try
            {
                   et_Sach = new ET_Sach(txtMaSach.Text
                    , cboGH.SelectedValue.ToString()
                    , txtTenSach.Text
                    , txtTheLoai.Text
                    , txtTenNXB.Text
                    , txtTacGia.Text
                    , txtMaNV.Text
                    , float.Parse(txtGiaBan.Text)
                    , dtpNXB.Value
                    , dtpNgayNhap.Value
                    , Int32.Parse(txtSoLuong.Text)
                    , Int32.Parse(txtGiamGia.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kiểu dữ liệu bạn nhập bị sai.Vui lòng nhập lại");
                return;
            }

            if(bus_sach.themSach(et_Sach))
            {
                MessageBox.Show("Bạn Đã thêm thành công.");
                dgvSach.DataSource = bus_sach.getSach();
            }
            else
            {
                MessageBox.Show("Bạn thêm không thành công.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_Sach et_Sach = null;
            try
            {
                et_Sach = new ET_Sach(txtMaSach.Text
                 , cboGH.SelectedValue.ToString()
                 , txtTenSach.Text
                 , txtTheLoai.Text
                 , txtTenNXB.Text
                 , txtTacGia.Text
                 , txtMaNV.Text
                 , float.Parse(txtGiaBan.Text)
                 , dtpNXB.Value
                 , dtpNgayNhap.Value
                 , Int32.Parse(txtSoLuong.Text)
                 , Int32.Parse(txtGiamGia.Text));
            }
            catch(InvalidCastException ex)
            {
                MessageBox.Show("Kiểu dữ liệu bạn nhập bị sai.Vui lòng nhập lại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu bạn hiện đang trống");
                return;
            }

            DialogResult r = MessageBox.Show("Bạn có muốn sữa dữ liệu này không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.No)
            {
                MessageBox.Show("Bạn đã hủy sữa");
                return;
            }
           
            if (bus_sach.suaSach(et_Sach))
            {
                MessageBox.Show("Bạn Đã sữa thành công.");
            }
            else
            {
                MessageBox.Show("Bạn sữa không thành công.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaSach.Text.Length <= 0)
            {
                MessageBox.Show("bạn phải nhập mã sách nếu muốn xóa");
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có muốn xóa dữ liệu này không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                MessageBox.Show("Bạn đã hủy xóa");
                return;
            }
            if (bus_sach.xoaSach(txtMaSach.Text))
            {
                MessageBox.Show("Bạn Đã sữa thành công.");
            }
            else
            {
                MessageBox.Show("Bạn sữa không thành công.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult r = MessageBox.Show("Bạn muốn đống chương trình này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if(r == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }
    }
}
