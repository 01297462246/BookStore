using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ET_QLNS
{
    public class ET_Sach
    {
        //Mã sách, Tên sách, thể loại, giá bán, ten nha xuat ban, tác giả, số lượng,
        //ngày xuất bản, ngày nhập , giảm giá, MaNV, MaGH
        private string _MaSach, _MaGH, _TenSach, _TheLoai, _TenNCC, _TacGia, _MaNV;
        private float _GiaBan;
        private DateTime _NXB, _NgayNhap;
        private int _SoLuong, _GiamGia;
        //--------------------------------------------------------------------
        //GET, SET
        public string MaSach { get => _MaSach; set => _MaSach = value; }
        public string MaGH { get => _MaGH; set => _MaGH = value; }
        public string TenSach { get => _TenSach; set => _TenSach = value; }
        public string TheLoai { get => _TheLoai; set => _TheLoai = value; }
        public string TenNCC { get => _TenNCC; set => _TenNCC = value; }
        public string TacGia { get => _TacGia; set => _TacGia = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public float GiaBan { get => _GiaBan; set => _GiaBan = value; }
        public DateTime NXB { get => _NXB; set => _NXB = value; }
        public DateTime NgayNhap { get => _NgayNhap; set => _NgayNhap = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public int GiamGia { get => _GiamGia; set => _GiamGia = value; }
        //--------------------------------------------------------------------
        //METHOD
        public ArrayList getAllProperties()
        {
            ArrayList list = new ArrayList() {MaSach, MaGH, TenSach, TheLoai, TenNCC, TacGia, MaNV, GiaBan, NXB, NgayNhap, SoLuong, GiamGia };
            return list;
        }
        //--------------------------------------------------------------------
        //CONSTRUCTOR
        public ET_Sach()
        {

        }

        public ET_Sach(string maSach, string maGH, string tenSach, string theloai, string tenNCC, string tacgia, string maNV, float giaban, DateTime nxb, DateTime ngaynhap, int soluong, int giamgia)
        {
            this._GiaBan = giaban;
            this._GiamGia = giamgia;
            this._MaGH = maGH;
            this._MaNV = maNV;
            this._MaSach = maSach;
            this._NgayNhap = ngaynhap;
            this._NXB = nxb;
            this._SoLuong = soluong;
            this._TacGia = tacgia;
            this._TenNCC = tenNCC;
            this._TenSach = tenSach;
            this._TheLoai = theloai;
        }
    }
}
