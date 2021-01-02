using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ET_QLNS
{
    public class ET_NhaCungCap
    {
        private string _MaNCC, _TenNXB, _SDT, _SoFax, _DiaChi, _NgayNhap, _TongSoLuong, _GiaTien, _MaNV;

        //-------------------------------------------------------------------------
        //GET, SET
        public string MaNCC { get => _MaNCC; set => _MaNCC = value; }
        public string TenNXB { get => _TenNXB; set => _TenNXB = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string SoFax { get => _SoFax; set => _SoFax = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string NgayNhap { get => _NgayNhap; set => _NgayNhap = value; }
        public string TongSoLuong { get => _TongSoLuong; set => _TongSoLuong = value; }
        public string GiaTien { get => _GiaTien; set => _GiaTien = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }

        //-------------------------------------------------------------------------
        //METHOD
        public ArrayList getAllProperties()
        {
            ArrayList list = new ArrayList() {  MaNCC,  TenNXB,  SDT,  SoFax,  DiaChi, NgayNhap, TongSoLuong, GiaTien, MaNV};
            return list;
        }
        //--------------------------------------------------------------------------
        //CONSTRUCTOR
        public ET_NhaCungCap(string maNCC, string tenNXB, string sDT, string soFax,
            string diaChi, string ngayNhap, string tongSoLuong, string giaTien,
            string maNV)
        {
            _MaNCC = maNCC;
            _TenNXB = tenNXB;
            _SDT = sDT;
            _SoFax = soFax;
            _DiaChi = diaChi;
            _NgayNhap = ngayNhap;
            _TongSoLuong = tongSoLuong;
            _GiaTien = giaTien;
        }

        public ET_NhaCungCap() { }
    }
}
