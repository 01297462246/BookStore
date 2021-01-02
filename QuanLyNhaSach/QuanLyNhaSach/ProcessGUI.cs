using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public class ProcessGUI
    {
        //Size: 760-635
        public static void CallContainer(Control control, Control newContent)
        {
            control.Controls.Clear();
            newContent.Size = new System.Drawing.Size(760, 635);
            newContent.Dock = DockStyle.Fill;
            newContent.BringToFront();
            newContent.Focus();
            control.Controls.Add(newContent);
        }
    }
}
