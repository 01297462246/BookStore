using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ET_QLNS
{
    public class ET_HoaDon
    {
        String _MaHD;
        String _NgayXuatHoaDon;
        float _TongTien;
        String _LoaiHoaDon;
        String _MaNV;
        String _MaKH;

        public string MaHD { get => _MaHD; set => _MaHD = value; }
        public string NgayXuatHoaDon { get => _NgayXuatHoaDon; set => _NgayXuatHoaDon = value; }
        public float TongTien { get => _TongTien; set => _TongTien = value; }
        public string LoaiHoaDon { get => _LoaiHoaDon; set => _LoaiHoaDon = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string MaKH { get => _MaKH; set => _MaKH = value; }

        public ArrayList getAllProperties()
        {
            ArrayList list = new ArrayList() { MaHD, NgayXuatHoaDon, TongTien, LoaiHoaDon, MaNV, MaKH };
            return list;
        }

        public ET_HoaDon(string maHD, string ngayXuatHoaDon, float tongTien, string loaiHoaDon, string maNV, string maKH)
        {
            _MaHD = maHD;
            _NgayXuatHoaDon = ngayXuatHoaDon;
            _TongTien = tongTien;
            _LoaiHoaDon = loaiHoaDon;
            _MaNV = maNV;
            _MaKH = maKH;
        }

        public ET_HoaDon() { }

        public override string ToString()
        {
            return "MaHD:" + MaHD
                + "MaKH:" + MaKH
                + "MaNV:" + MaNV
                + "TongTien:" + TongTien
                + "NgayXuatHoaDon" + NgayXuatHoaDon
                + "LoaiHoaDon" + LoaiHoaDon;
        }
    }
}
