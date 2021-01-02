using BUS_QLNS;
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
    public partial class controlChiTietHoaDon : UserControl
    {
        BUS_ChiTietHoaDon bus_CTHD = new BUS_ChiTietHoaDon();
        public void init() {
            dgvChiTietHoaDon.DataSource = bus_CTHD.getChiTietHD();
        }

        public controlChiTietHoaDon()
        {
            InitializeComponent();
            init();
        }
    }
}
