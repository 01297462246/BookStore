using System;
using System.Collections;
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
    public partial class frmNhanVien : Form
    {
        BUS_NhanVien bus_NhanVien = new BUS_NhanVien();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BUS_GiangHang bus_GH = new BUS_GiangHang(); 
            dgvNhanVien.DataSource = bus_NhanVien.GetData();
            DataTable dt =  bus_GH.getGH();
            cboMaGH.DataSource = dt;
            cboMaGH.ValueMember = "MaGH";
            cboMaGH.DisplayMember = "TenGH";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_NhanVien et_NhanVien = null;
            try
            {
               mtbSoDienThoai.TextMaskFormat = mtbCMND.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                if(txtMaQL.Text.Length <= 0)
                {
                    et_NhanVien = new ET_NhanVien(txtMaNV.Text, txtTenNV.Text, mtbCMND.Text, mtbSoDienThoai.Text, txtDiaChi.Text);
                }
                else
                {
                    et_NhanVien = new ET_NhanVien(txtMaNV.Text, txtTenNV.Text, mtbCMND.Text, mtbSoDienThoai.Text, txtDiaChi.Text, cboMaGH.SelectedValue.ToString(), txtMaQL.Text);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kiểu dữ liệu bạn nhập bị sai.Vui lòng nhập lại");
                return;
            }

            if (bus_NhanVien.ThemNhanVien(et_NhanVien))
            {
                dgvNhanVien.DataSource  = bus_NhanVien.GetData();
                MessageBox.Show("Bạn Đã thêm thành công.");
            }
            else
            {
                MessageBox.Show("Bạn thêm không thành công.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_NhanVien et_NhanVien = null;
            try
            {
                mtbSoDienThoai.TextMaskFormat = mtbCMND.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                if (txtMaQL.Text.Length <= 0)//khong co MaQL
                {
                    et_NhanVien = new ET_NhanVien(txtMaNV.Text, txtTenNV.Text, mtbCMND.Text, mtbSoDienThoai.Text, txtDiaChi.Text);
                }
                else //Co MaQL
                {
                    et_NhanVien = new ET_NhanVien(txtMaNV.Text, txtTenNV.Text, mtbCMND.Text, mtbSoDienThoai.Text, txtDiaChi.Text, cboMaGH.SelectedValue.ToString(), txtMaQL.Text);
                }
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

            if (bus_NhanVien.SuaNhanVien(et_NhanVien))
            {
                dgvNhanVien.DataSource = bus_NhanVien.GetData();
                MessageBox.Show("Bạn Đã sữa thành công.");
            }
            else
            {
                MessageBox.Show("Bạn sữa không thành công.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Length <= 0)
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
            if (bus_NhanVien.XoaNhanVien(txtMaNV.Text))
            {
                dgvNhanVien.DataSource = bus_NhanVien.GetData();
                MessageBox.Show("Bạn Đã Xóa thành công.");
            }
            else
            {
                MessageBox.Show("Bạn sữa không thành công.");
            }
        }

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow item = dgvNhanVien.SelectedRows[0];
            if(item == null)
            {
                return;
            }
            if (item.Index >= dgvNhanVien.RowCount - 1)
            {
                MessageBox.Show("Không tìm thấy dữ liệu bạn chọn.Vui lòng chọn lại");
                return;
            }
            ET_NhanVien et_NhanVien = null;
            et_NhanVien = new ET_NhanVien(item.Cells[0].Value.ToString(), item.Cells[1].Value.ToString(), item.Cells[2].Value.ToString(), item.Cells[3].Value.ToString(), item.Cells[4].Value.ToString(), item.Cells[5].Value.ToString(), item.Cells[6].Value.ToString());
            txtMaNV.Text = et_NhanVien.MaNV;
            txtTenNV.Text = et_NhanVien.TenNV;
            mtbCMND.Text = et_NhanVien.CMND;
            mtbSoDienThoai.Text = et_NhanVien.SDT;
            txtDiaChi.Text = et_NhanVien.DC;
            cboMaGH.SelectedValue = et_NhanVien.MaGH;
            txtMaQL.Text = et_NhanVien.MaQL;
        }

    }
}
