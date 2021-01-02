using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ET_QLNS
{
    public class ET_ChiTietHoaDon
    {
        String _MaSach;
        String _MaHD;
        int _SoLuong;

        public ET_ChiTietHoaDon()
        { 
        }

        public ET_ChiTietHoaDon(string maSach, string maHD, int soLuong)
        {
            _MaSach = maSach;
            _MaHD = maHD;
            _SoLuong = soLuong;
        }

        public string MaSach { get => _MaSach; set => _MaSach = value; }
        public string MaHD { get => _MaHD; set => _MaHD = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }

        public ArrayList getAllProperties()
        {
            ArrayList list = new ArrayList() { MaSach, MaHD, SoLuong };
            return list;
        }
    }
}
