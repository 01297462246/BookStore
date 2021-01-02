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
    public partial class frmHoaDon : Form
    {
        BUS_HoaDon bus_HoaDon = new BUS_HoaDon();

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = bus_HoaDon.getHD();
        }
    }
}
