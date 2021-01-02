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
    public partial class ItemBill : UserControl
    {

        public ItemBill()
        {
            InitializeComponent();
            SetValueForUI();
        }

        private string _nameBill;
        private string _nameNV;
        private string _nameKH;
        private string _time;
        private string _tongtien;
        private DataTable _tableCTHD;

        public ItemBill(string nameBill, string nameNV, string nameKH, string time, string tongtien, DataTable tableCTHD)
        {
            _nameBill = nameBill;
            _nameNV = nameNV;
            _nameKH = nameKH;
            _time = time;
            _tongtien = tongtien;
            _tableCTHD = tableCTHD;
        }

        public string NameBill { get => _nameBill; set => _nameBill = value; }
        public string NameNV { get => _nameNV; set => _nameNV = value; }
        public string NameKH { get => _nameKH; set => _nameKH = value; }
        public string Time { get => _time; set => _time = value; }
        public string Tongtien { get => _tongtien; set => _tongtien = value; }
        public DataTable TableCTHD { get => _tableCTHD; set => _tableCTHD = value; }

        public void SetValueForUI(){
            lblTenHoaDon.Text = NameBill;
            lblTenKH.Text = NameKH;
            lblTenNV.Text = NameNV;
            lblThoiGian.Text = Time;
            dgvCTHD.DataSource = TableCTHD;
            lblTongTien.Text = Tongtien;
        }
    }
}
