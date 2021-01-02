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
    public partial class frmLogin : Form
    {
        private BUS_DangNhap bus_DangNhap = new BUS_DangNhap();
        private bool type = true;
        private ET_DangNhap ET_DangNhap { get; set; }


        public frmLogin()
        {
            InitializeComponent();
        }

        private void txt_Click(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            control.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //lay thong tin tu form cho et_DangNhap.
            ET_DangNhap = new ET_DangNhap(txtUser.Text, txtPass.Text, type);
            DataTable dt = bus_DangNhap.GetData(ET_DangNhap.MaNV
                , ET_DangNhap.PassWord
                , ET_DangNhap.PhanQuyen);
            //Check dt empty.
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Dang nhap thanh cong");
                this.Hide();
                frmMain main = new frmMain();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kiem tra lai ten dang nhap hoac mat khau");
            }

        }

        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rad = (RadioButton)sender;
            if (rad.Checked)
            {
                type = (!type);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
