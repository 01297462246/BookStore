using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS_QLNS;
using ET_QLNS;
namespace QuanLyNhaSach
{
    public partial class frmGianHang : Form
    {
        BUS_GiangHang bus_GH = new BUS_GiangHang();
        public frmGianHang()
        {
            InitializeComponent();
        }

        private void frmGiangHang_Load(object sender, EventArgs e)
        {
            dgvGiangHang.DataSource = bus_GH.getGH();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_GianHang et_GianHang = null;
            try
            {
                et_GianHang = new ET_GianHang(txtMaGH.Text
                 , txtTenGH.Text
                 , Int32.Parse(txtSoLuong.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kiểu dữ liệu bạn nhập bị sai.Vui lòng nhập lại");
                return;
            }

            if (bus_GH.themGH(et_GianHang))
            {
                dgvGiangHang.DataSource = bus_GH.getGH();
                MessageBox.Show("Bạn Đã thêm thành công.");
            }
            else
            {
                MessageBox.Show("Bạn thêm không thành công.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_GianHang et_GianHang = null;
            try
            {
                et_GianHang = new ET_GianHang(txtMaGH.Text
                 , txtTenGH.Text
                 , Int32.Parse(txtSoLuong.Text));
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Kiểu dữ liệu bạn nhập bị sai.Vui lòng nhập lại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu bạn hiện đang trống");
                return;
            }

            DialogResult r = MessageBox.Show("Bạn có muốn sữa dữ liệu này không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                MessageBox.Show("Bạn đã hủy sữa");
                return;
            }

            if (bus_GH.suaGH(et_GianHang))
            {
                dgvGiangHang.DataSource = bus_GH.getGH();
                MessageBox.Show("Bạn Đã sữa thành công.");
            }
            else
            {
                MessageBox.Show("Bạn sữa không thành công.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaGH.Text.Length <= 0)
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
            if (bus_GH.xoaGH(txtMaGH.Text))
            {
                dgvGiangHang.DataSource = bus_GH.getGH();
                MessageBox.Show("Bạn Đã xóa thành công.");
            }
            else
            {
                MessageBox.Show("Bạn xóa không thành công.");
            }
        }

        private void frmGiangHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn đống chương trình này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvGiangHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow item = dgvGiangHang.SelectedRows[0];
            if (item.Index >= dgvGiangHang.RowCount - 1)
            {
                MessageBox.Show("Không tìm thấy dữ liệu bạn chọn.Vui lòng chọn lại");
                return;
            }
            ET_GianHang et_GH = null;
            
            et_GH = new ET_GianHang(item.Cells[0].Value.ToString(), item.Cells[1].Value.ToString(), int.Parse(item.Cells[2].Value.ToString()));
            txtMaGH.Text = et_GH.MaGH;
            txtTenGH.Text = et_GH.TenGH;
            txtSoLuong.Text = et_GH.SoLuongSach.ToString();
        }

        private void dgvGiangHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
