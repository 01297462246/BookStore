using BUS_QLNS;
using ET_QLNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class ControlBanSach : UserControl
    {

        ET_Sach eT_Sach = new ET_Sach();
        BUS_ChiTietHoaDon bus_ChiTietHoaDon = new BUS_ChiTietHoaDon();
        BUS_Sach bus_Sach = new BUS_Sach();
        BUS_HoaDon bus_HoaDon = new BUS_HoaDon();
        BUS_NhanVien bus_NhanVien = new BUS_NhanVien();
        BUS_KhachHang bus_KhachHang = new BUS_KhachHang();

        public void Init()
        {
            cbKhachHang.DataSource = bus_KhachHang.getData();
            cbNhanVien.DataSource = bus_NhanVien.GetData();
            cbNhanVien.DisplayMember = "TenNV";
            cbNhanVien.ValueMember = "MaNV";
            cbLoaiHoaDon.Items.Add("le");
            cbLoaiHoaDon.Items.Add("si");
            cbLoaiHoaDon.Text = "le";
            txtTongTien.Text = "0";
            SetDataGridview();
            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //btn.Text = "Demo";
            //btn.UseColumnTextForButtonValue = true;
            //dataGridView1.Columns.Add(btn);

            //dgvRow.Cells["dgvtxtThanhTien"].Value = String.Format("this is 0,0!");
            //dataGridView1.Rows[1].Cells[0].Value = String.Format("this is 0,0!");
        }

        public void SetDataGridview()
        {
            DataGridViewRow dbTempt = dataGridView1.CurrentRow;
            dgvcbcSach.DataSource = bus_Sach.getSach();
            dgvcbcSach.DisplayMember = "TenSach";
            dgvcbcSach.ValueMember = "MaSach";
        }

        public ControlBanSach()
        {
            InitializeComponent();
            Init();
            ResetControl();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Process for UI control ""
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                //Console.WriteLine("Size: " + index);
                DataGridViewRow dgvRow = dataGridView1.CurrentRow;

                if (dgvRow.Cells["dgvtxtSoLuong"].Value != null && dgvRow.Cells["dgvcbcSach"].Value != null)
                {
                    //Console.WriteLine("Value: " + Convert.ToString(dgvRow.Cells["dgvcbcSach"].Value));
                    dataGridView1.Rows[index].Cells["dgvtxtThanhTien"].Value =
                        Convert.ToInt32(dgvRow.Cells["dgvtxtSoLuong"].Value) * bus_Sach.getGiaSach(Convert.ToString(dgvRow.Cells["dgvcbcSach"].Value));
                }
                SumMoney();
            }
        }

        private void SumMoney()
        {
            double sum = 0;
            if (dataGridView1.Rows.Count > 1)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["dgvtxtThanhTien"].Value);
                }
            }
            txtTongTien.Text = sum + "";
        }

        public String CreateNewID()
        {
            string id = (int.Parse(bus_HoaDon.getEndID().Replace("HD", "")) + 1) + "";
            if (id.Length == 1) id = "HD00" + id;
            else if (id.Length == 2) id = "HD0" + id;
            else if (id.Length == 3) id = "HD" + id;
            return id;
        }

        public Boolean CheckIsDigit(string soluong)
        {
            int number;
            return int.TryParse(soluong, out number);
        }

        public Boolean CreateChiTietHD()
        {
            List<ET_ChiTietHoaDon> listET = new List<ET_ChiTietHoaDon>();
            Boolean flag = true;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string maSach = Convert.ToString(dataGridView1.Rows[i].Cells["dgvcbcSach"].Value);
                string maHD = CreateNewID();
                string soLuong = Convert.ToString(dataGridView1.Rows[i].Cells["dgvtxtSoluong"].Value);
                if (CheckIsDigit(soLuong))
                {
                    ET_ChiTietHoaDon et = new ET_ChiTietHoaDon(maSach, maHD, int.Parse(soLuong));
                    listET.Add(et);
                }
                else
                {
                    flag = false;
                    Console.WriteLine("ERROR: " + "item " + i + " không đúng");
                    MessageBox.Show("Xin lỗi đã xảy ra lỗi trong quá trình thao tác!!!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
            if (flag)
            {
                for (int i = 0; i < listET.Count; i++)
                {
                    bus_ChiTietHoaDon.themChiTietHD(listET[i]);
                }
            }
            return flag;
        }

        public void CreateHoaDon()
        {
            string maNV = cbNhanVien.SelectedValue + "";
            ET_HoaDon et = new ET_HoaDon(CreateNewID(), dtpNgayXuatHD.Value.ToString("yyyy-MM-dd"), int.Parse(txtTongTien.Text),
                cbLoaiHoaDon.SelectedItem.ToString(), maNV, cbKhachHang.SelectedItem.ToString());
            if (bus_HoaDon.themHD(et))
            {
                if (CreateChiTietHD())
                {
                    DialogResult r = MessageBox.Show("Thanh toán thành công!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (r == DialogResult.OK)
                    {
                        ResetControl();
                    }
                }
            }
            else
            {
                MessageBox.Show("Xin lỗi đã xảy ra lỗi trong quá trình thao tác!!!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ResetControl()
        {
            this.cbKhachHang.Text = "";
            this.cbLoaiHoaDon.SelectedIndex = 0;
            this.cbNhanVien.SelectedIndex = 0;
            this.dataGridView1.Rows.Clear();
            this.txtTongTien.Text = "0";
            this.dtpNgayXuatHD.Value = DateTime.Now;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (!cbKhachHang.Text.Equals("") && dataGridView1.Rows.Count > 1)
            {
                CreateHoaDon();
            }
            else if (dataGridView1.Rows.Count <= 1)
            {
                MessageBox.Show("Mời bạn chọn sản phẩm!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbKhachHang.Text.Equals(""))
            {
                this.errorProvider1.SetError(cbKhachHang, "Không được để trống trường này");
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string soLuong = Convert.ToString(dataGridView1.Rows[i].Cells["dgvtxtSoluong"].Value);
                string sanPham = Convert.ToString(dataGridView1.Rows[i].Cells["dgvcbcSach"].Value);
                if (sanPham.Equals("") && !soLuong.Equals(""))
                {
                    MessageBox.Show("Mời bạn chọn sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!sanPham.Equals("") && soLuong.Equals(""))
                {
                    MessageBox.Show("Mời bạn nhập số lượng ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbLoaiHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string a = cbNhanVien.SelectedValue+"";
            //MessageBox.Show("Value: " + a + "- Display: " + cbNhanVien.SelectedItem);
        }
    }
}
