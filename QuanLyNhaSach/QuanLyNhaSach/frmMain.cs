using QuanLyNhaSach.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class frmMain : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
         );

        public frmMain()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.FormBorderStyle = FormBorderStyle.None;
            //frmLoad frm = new frmLoad();
            //frm.Show();
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imsSach_Click(object sender, EventArgs e)
        {
            ControlSach ctrl = new ControlSach();
            ProcessGUI.CallContainer(pnlContainer, ctrl);
        }

        private void imsNhaCungCap_Click(object sender, EventArgs e)
        {
            ControlNhaCungCap ctrl = new ControlNhaCungCap();
            ProcessGUI.CallContainer(pnlContainer,ctrl);
        }

        private void imsTheLoai_Click(object sender, EventArgs e)
        {
            ControlTheLoai ctrl = new ControlTheLoai();
            ProcessGUI.CallContainer(pnlContainer, ctrl);
        }

        private void imsHoaDon_Click(object sender, EventArgs e)
        {
            ControlHoaDon ctrl = new ControlHoaDon();
            ProcessGUI.CallContainer(pnlContainer, ctrl);
        }

        private void imsKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void imsNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btnSach_SubMenu_Click(object sender, EventArgs e)
        {
            ControlBanSach ctrl = new ControlBanSach();
            ProcessGUI.CallContainer(pnlContainer, ctrl);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ControlBanSach ctrl = new ControlBanSach();
            ProcessGUI.CallContainer(pnlContainer, ctrl);
        }

        private void btnNCC_Submenu_Click(object sender, EventArgs e)
        {
            ControlSach ctrl = new ControlSach();
            ProcessGUI.CallContainer(pnlContainer, ctrl);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thực sự muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel=true;
            }
        }

        private void btnHoaDon_Submenu_Click(object sender, EventArgs e)
        {
          
        }

        private void btnChiTietHD_Submenu_Click(object sender, EventArgs e)
        {
            ControlHistory ctrl = new ControlHistory();
            ProcessGUI.CallContainer(pnlContainer, ctrl);
        }
    }
}
