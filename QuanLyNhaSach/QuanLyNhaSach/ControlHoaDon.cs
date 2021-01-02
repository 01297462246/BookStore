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
    public partial class ControlHoaDon : UserControl
    {

        BUS_HoaDon busHD = new BUS_HoaDon();
        public void init() {
            dgvNhaCungCap.DataSource = busHD.getHD();
        }

        public ControlHoaDon()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
