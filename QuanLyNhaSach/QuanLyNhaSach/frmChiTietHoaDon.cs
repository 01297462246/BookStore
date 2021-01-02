using BUS_QLNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class frmChiTietHoaDon : Form
    {
        BUS_ChiTietHoaDon bus_ChiTietHoaDon = new BUS_ChiTietHoaDon();

        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            dgvChiTietHoaDon.DataSource = bus_ChiTietHoaDon.getChiTietHD();
        }
    }
}
