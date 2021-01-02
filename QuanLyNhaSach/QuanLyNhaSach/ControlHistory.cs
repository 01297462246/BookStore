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
    public partial class ControlHistory : UserControl
    {
        ET_NhanVien eT_NhanVien = new ET_NhanVien();
        //ET_KhachHang eT_KhachHang = new ET_KhachHang();
        ET_HoaDon eT_HoaDon = new ET_HoaDon();
        ET_ChiTietHoaDon eT_ChiTietHoaDon = new ET_ChiTietHoaDon();
        BUS_HoaDon bus_HoaDon = new BUS_HoaDon();
        BUS_ChiTietHoaDon bus_CTHD = new BUS_ChiTietHoaDon();

        string typeFilter = "";
        string typeAll = "All";
        string typeStaff = "Staff";
        string typeCustomer = "Customer";
        string typeDate = "Date";
        string typeMoney = "Money";

        public ControlHistory()
        {
            InitializeComponent();
        }

        private void closePanel()
        {
            pnlDate.Visible = false;
            pnlKhachHang.Visible = false;
            pnlNhanVien.Visible = false;
            pnlTien.Visible = false;
        }
        private void SwitchPanel(Control ctrl)
        {
            Boolean flag = ctrl.Visible;
            if (flag) {  flag = !flag; ctrl.Visible = flag; }
            else { flag = !flag; closePanel(); ctrl.Visible = flag; }
        }

        private void btnTTAll_Click(object sender, EventArgs e)
        {
            typeFilter = typeAll;
            closePanel();

        }

        private void btnTTStaff_Click(object sender, EventArgs e)
        {
            typeFilter = typeStaff;
            SwitchPanel(pnlNhanVien);
        }

        private void btnTTDate_Click(object sender, EventArgs e)
        {
            typeFilter = typeDate;
            SwitchPanel(pnlDate);
        }

        private void btnTTMoney_Click(object sender, EventArgs e)
        {
            typeFilter = typeMoney;
            SwitchPanel(pnlTien);
        }

        private void btnTTCustomer_Click(object sender, EventArgs e)
        {
            typeFilter = typeCustomer;
            SwitchPanel(pnlKhachHang);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (typeFilter.Equals(typeAll))
            {

            }
            else if (typeFilter.Equals(typeDate)) 
            { 
            
            }
            else if (typeFilter.Equals(typeCustomer))
            {

            }
            else if (typeFilter.Equals(typeMoney))
            {

            }
            else if (typeFilter.Equals(typeStaff))
            {

            }
        }

        private void ShowBillForAll() {
            bus_HoaDon.getHD();
        }
    }
}
