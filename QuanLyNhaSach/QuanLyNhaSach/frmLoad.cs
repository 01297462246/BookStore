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
    public partial class frmLoad : Form
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

        public frmLoad()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            progressbarCircle.Value = 0;
        }

        private void progressbarCircle_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressbarCircle.Value += 5;
            progressbarCircle.Text = progressbarCircle.Value.ToString() + "%";

            if (progressbarCircle.Value == 100)
            {
                timer1.Enabled = false;
                frmLogin frm = new frmLogin();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}
