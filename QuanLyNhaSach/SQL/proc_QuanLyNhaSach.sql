use QuanLyNhaSach
GO
-------------------------------------------- proc sp_Chuc Nang Them Xoa Sua ------------------------------------------


----------------------------------------------------------- KHACH HANG -------------------------------------------

Create proc sp_ThemKhachHang(
	@MaKH [char](10)  ,
	@TenKH [nvarchar](50) ,
	@NamSinh [date] ,
	@DoiTuong [nvarchar](30) ,
	@SDT [char](10) 
)
AS
BEGIN
INSERT INTO dbo.KhachHang values (
	@MaKH ,
	@TenKH ,
	@NamSinh ,
	@DoiTuong ,
	@SDT 
)
END;
GO

Create proc sp_XoaKhachHang(
	@MaKH [char](10)
)
AS
BEGIN
DELETE FROM KhachHang where MaKH = @MaKH
END;
GO

Create proc sp_CapNhatKhachHang(
	@MaKH [char](10)  ,
	@TenKH [nvarchar](50) ,
	@NamSinh [date] ,
	@DoiTuong [nvarchar](30) ,
	@SDT [char](10) 
)
AS
BEGIN
UPDATE dbo.KhachHang set TenKH = @TenKH, NamSinh = @NamSinh, DoiTuong = @DoiTuong, SDT = @SDT Where MaKH = @MaKH
END;
GO

------------------------------------------------------------- The Loai -------------------------------------------

Create proc sp_ThemTheLoai(
	@MaTL [char](10)  ,
	@TenTL [nvarchar](50) ,
	@MaNCC [char](10)
)
AS
BEGIN
INSERT INTO dbo.TheLoai values (
	@MaTL ,
	@TenTL ,
	@MaNCC 
)
END;
GO

Create proc sp_XoaTheLoai(
	@MaTL [char](10)
)
AS
BEGIN
DELETE FROM dbo.TheLoai where MaTL = @MaTL
END;
GO

Create proc sp_CapNhatTheLoai(
	@MaTL [char](10)  ,
	@TenTL [nvarchar](50) ,
	@MaNCC [char](10)
)
AS
BEGIN
UPDATE dbo.TheLoai set 
	TenTL = @TenTL  where MaNCC = @MaNCC And MaTL = @MaTL 
END;
GO

--------------------------------------------------------  Nha Cung Cap -------------------------------------------

Create proc sp_ThemNhaCungCap(
	@MaNCC [char](10),
	@TenNXB [nvarchar](50) ,
	@SDT [char](10) ,
	@SoFax [char](10) ,
	@DiaChi [nvarchar](50) ,
	@NgayNhap [date] ,
	@TongSoLuong [int] ,
	@GiaTien [float] ,
	@MaNV [char](10)
)
AS
BEGIN
INSERT INTO dbo.NhaCungCap values (
	@MaNCC ,
	@TenNXB  ,
	@SDT  ,
	@SoFax ,
	@DiaChi ,
	@NgayNhap ,
	@TongSoLuong ,
	@GiaTien ,
	@MaNV  
)
END;
GO

Create proc sp_XoaNhaCungCap(
	@MaNCC [char](10)
)
AS
BEGIN
DELETE FROM dbo.NhaCungCap where MaNCC = @MaNCC
END;
GO

Create proc sp_CapNhatNhaCungCap(
	@MaNCC [char](10),
	@TenNXB [nvarchar](50) ,
	@SDT [char](10) ,
	@SoFax [char](10) ,
	@DiaChi [nvarchar](50) ,
	@NgayNhap [date] ,
	@TongSoLuong [int] ,
	@GiaTien [float] ,
	@MaNV [char](10)
)
AS
BEGIN
UPDATE dbo.NhaCungCap set 
	TenNXB = @TenNXB ,
	SDT = @SDT ,
	SoFax = @SoFax ,
	DiaChi = @DiaChi ,
	NgayNhap = @NgayNhap ,
	TongSoLuong = @TongSoLuong ,
	GiaTien = @GiaTien ,
	MaNV = @MaNV  
Where MaNCC = @MaNCC
END;
GO

--------------------------------------------------------------  Hoa Don -------------------------------------------
Create proc sp_ThemHoaDon(
	@MaHD char(10),
	@NgayXuatHoaDon date ,
	@TongTien bigint,
	@LoaiHoaDon nvarchar(30) ,
	@MaNV char(10)  ,
	@MaKH char(10) 
)
AS
BEGIN
INSERT INTO dbo.HoaDon values (
	@MaHD ,
	@NgayXuatHoaDon ,
	@TongTien ,
	@LoaiHoaDon ,
	@MaNV ,
	@MaKH
)
END;
GO

Create proc sp_XoaHoaDon(
	@MaHD [char](10)
)
AS
BEGIN
DELETE FROM dbo.HoaDon where MaHD = @MaHD
END;
GO

Create proc sp_CapNhapHoaDon(
	@MaHD [char](10)  ,
	@NgayXuatHoaDon [date] ,
	@TongTien [float] ,
	@LoaiHoaDon [nvarchar](30) ,
	@MaNV [char](10)  ,
	@MaKH [char](10) 
)
AS
BEGIN
UPDATE dbo.HoaDon set 
	 NgayXuatHoaDon = @NgayXuatHoaDon, TongTien = @TongTien, LoaiHoaDon = @LoaiHoaDon  where MaHD = @MaHD And MaKH = @MaKH And MaNV = @MaNV 
END;
GO

------------------------------------------------------------- Chi Tiet Hoa Don -------------------------------------------

Create proc sp_ThemChiTietHoaDon(
	@MaSach [char](10) ,
	@MaHD [char](10) ,
	@SoLuong [int] 
)
AS
BEGIN
INSERT INTO dbo.ChiTietHoaDon values (
	@MaSach ,
	@MaHD ,
	@SoLuong 
)
END;
GO

Create proc sp_XoaChiTietHoaDon(
	@MaSach [char](10) ,
	@MaHD [char](10) 
)
AS
BEGIN
DELETE FROM dbo.ChiTietHoaDon where MaHD = @MaHD and MaSach = @MaSach
END;
GO

Create proc sp_CapNhapChiTietHoaDon(
	@MaSach [char](10) ,
	@MaHD [char](10) ,
	@SoLuong [int] 
)
AS
BEGIN
UPDATE dbo.ChiTietHoaDon set 
	 SoLuong = @SoLuong  where MaHD = @MaHD and MaSach = @MaSach
END;
GO

-------------------------------------------- proc sp_Chuc Nang Ngoai ------------------------------------------

------------------------------------ Lay toan bo thong tin cua cac bang --------------------------------------
Create proc sp_LayThongTinBangKhachHang
AS
BEGIN
Select * from KhachHang
END;
GO

Create proc sp_LayThongTinBangTheLoai
AS
BEGIN
Select * from TheLoai
END;
GO

Create proc sp_LayThongTinBangHoaDon
AS
BEGIN
Select * from HoaDon
END;
GO

Create proc sp_LayThongTinBangChiTietHoaDon
AS
BEGIN
Select * from ChiTietHoaDon
END;
GO


----------------------------  Chuc nang tim kiem khach hang ------------------------------------------------
-------------------- Vua tim co dinh vua loc khach hang theo thong so giong nhat ---------------------------
Create proc sp_TimKhachHang (
	@MaKH [char](10) null ,
	@TenKH [nvarchar](50) null ,
	@DoiTuong [nvarchar](30) null,
	@SDT [char](10) null
)
AS
BEGIN
Select KhachHang.MaKH, KhachHang.TenKH, KhachHang.NamSinh, KhachHang.SDT, KhachHang.DoiTuong
From KhachHang Where MaKH = @MaKH OR TenKH Like @MaKH OR DoiTuong Like @DoiTuong OR SDT = @SDT
END;
GO

-------------------------------- Loc Hoa Don --------------------------------------------------
Create proc sp_TimHoaDon(
	@MaHD char(10) null,
	@MaKH char(10) null,
	@NgayXuatHoaDon date null
)
AS
Begin 
Select * from HoaDon where MaHD = @MaHD or MaKH = @MaKH or NgayXuatHoaDon = @NgayXuatHoaDon
End;
GO

Create proc sp_TimHoaDonTheoKhoangThoiGian (
	@KhoangBatDau [date] ,
	@KhoangKetThuc [date]  
)
AS
BEGIN
Select *
From HoaDon Where NgayXuatHoaDon >= @KhoangBatDau And NgayXuatHoaDon <= @KhoangKetThuc
END;
GO

------------------------- Truy van chi tiet hoa don theo ma hoa don ----------------------------
Create proc sp_LayChiTietHoaTheoMaHoaDon(
	@MaHD char(10)
)
AS
BEGIN
Select *
From ChiTietHoaDon
Inner join HoaDon on ChiTietHoaDon.MaHD = HoaDon.MaHD
END;
GO

Create proc getEndHoaDonID
AS
BEGIN
SELECT TOP 1 * FROM HoaDon ORDER BY HoaDon.MaHD DESC
END
GO

Create proc getGiaSach(
	@MaSach char(10)
)
AS
Begin
Select GiaBan from Sach where MaSach = @MaSach
END
GO












-----------------------------------------------------------------------------------------------------
--------------------------------- Them Du Lieu ------------------------------------------------------

exec sp_ThemKhachHang 'GV20000001','Huynh Duy Quoc','2000-08-14','Giao Vien','0123456789'
exec sp_ThemKhachHang 'GV20000002','Nguyen Van A','2000-08-14','Giao Vien','0870238012'
exec sp_ThemKhachHang 'GV20000003','Pham Thi B','2000-08-14','Giao Vien','0870238011'
exec sp_ThemKhachHang 'GV20000004','Nguyen Thi C','2000-08-14','Giao Vien','0870238013'
exec sp_ThemKhachHang 'GV20000005','Dinh Van D','2000-08-14','Giao Vien','0870238014'

--exec XoaKhachHang 'GV20000001'
exec sp_ThemGH 'GH001','Lich Su',1000
exec sp_ThemGH 'GH002','Toan Hoc',1000
exec sp_ThemGH 'GH003','Khoa Hoc',1000
exec sp_ThemGH 'GH004','Dia Ly',1000
exec sp_ThemGH 'GH005','Van Hoc',1000

exec sp_ThemQuanLy 'QL001','Nhan Vien 6','123456789006','0981700656','Quan Thu Duc'
exec sp_ThemNhanVien 'KS001','Nhan Vien 2','123456789001','0981700653','Quan Thu Duc','GH002','QL001'
exec sp_ThemNhanVien 'NV001','Nhan Vien 1','123456789005','0981700659','Quan Thu Duc','GH001','QL001'
exec sp_ThemNhanVien 'NV003','Nhan Vien 3','123456789002','0981700654','Quan Thu Duc','GH003','QL001'
exec sp_ThemNhanVien 'NV004','Nhan Vien 4','123456789003','0981700655','Quan Thu Duc','GH004','QL001'
exec sp_ThemNhanVien 'NV005','Nhan Vien 5','123456789004','0981700656','Quan Thu Duc','GH005','QL001'
exec sp_ThemNhanVien 'NV0000006','Nhan Vien 7','123456789004','0981700656','Quan Thu Duc','GH005','QL001'
exec sp_ThemNhanVien 'NV00000007','Nhan Vien 8','123456789004','0981700656','Quan Thu Duc','GH005','QL001'

 select * from NhanVien

exec sp_ThemSach 'Sach000001','GH001','LichSu lop 10','GD','NXB A','Bo GD','NV001',10,'2019-8-4','2020-8-4',500,150000
exec sp_ThemSach 'Sach000002','GH001','LichSu lop 11','GD','NXB A','Bo GD','NV001',10,'2019-8-4','2020-08-19',500,150000
exec sp_ThemSach 'Sach000003','GH001','LichSu lop 12','GD','NXB A','Bo GD','NV001',10,'2019-8-4','2020-08-19',500,150000
exec sp_ThemSach 'Sach000004','GH002','LichSu lop 10','GD','NXB A','Bo GD','NV001',10,'2019-8-4','2020-08-19',500,150000
exec sp_ThemSach 'Sach000005','GH002','LichSu lop 10','GD','NXB A','Bo GD','NV001',10,'2019-8-4','2020-08-19',500,150000
exec sp_ThemSach 'Sach000006','GH002','LichSu lop 10','GD','NXB A','Bo GD','NV001',10,'2019-8-4','2020-08-19',500,150000

exec sp_ThemNhaCungCap 'NCC001', 'Kim Dong', '050056789','0908789','Ha Noi','2020-08-19', 1000, 150000,'KS001'

exec sp_ThemTheLoai 'TL001','Giao Duc','NCC001'

Select * from NhaCungCap
select * from TheLoai
exec sp_TruyXuatSach
--exec sp_ThemHoaDon
exec sp_ThemHoaDon 'HD001','2020-12-20',500000,'le','KS001','GV20000001'
exec sp_ThemHoaDon 'HD002','2020-12-21',500000,'le','KS001','GV20000001'
exec sp_ThemHoaDon 'HD003','2020-12-22',500000,'le','KS001','GV20000001'
exec sp_ThemHoaDon 'HD004','2020-12-23',500000,'le','KS001','GV20000001'
exec sp_ThemHoaDon 'HD005','2020-12-23',500000,'le','KS001','GV20000001'
exec sp_ThemHoaDon 'HD006','2020-12-23',500000,'le','NV003','GV20000001'

--exec sp_ThemChiTietHoaDon
exec sp_ThemChiTietHoaDon 'Sach000001', 'HD001','3'
exec sp_ThemChiTietHoaDon 'Sach000002', 'HD001','3'
exec sp_ThemChiTietHoaDon 'Sach000003', 'HD001','3'

Select * from ChiTietHoaDon
select * from HoaDon
select * from NhanVien
select * from KhachHang
--Select * from ChiTietHoaDon
--Inner join HoaDon on ChiTietHoaDon.MaHD = HoaDon.MaHD

exec getEndHoaDonID

--Test 
--Select Sach.GiaBan as 'GIÁ BÁN', ChiTietHoaDon.SoLuong as 'SỐ LƯỢNG', Count(Sach.GiaBan)*(Sach.GiaBan*ChiTietHoaDon.SoLuong) as 'Tong Tien'
--From HoaDon
--Inner Join ChiTietHoaDon
--ON HoaDon.MaHD = ChiTietHoaDon.MaHD
--Inner Join Sach 
--ON ChiTietHoaDon.MaSach = Sach.MaSach
--Group by Sach.GiaBan, ChiTietHoaDon.SoLuong

exec getGiaSach'Sach000001'

select * from HoaDon
select * from ChiTietHoaDon where MaHD = 'HD001'
select * from DangNhap
GO

Create proc sp_ThemDangNhap (@pass char(10),@role bit, @MaNV char(10))
AS
Begin 
Insert into DangNhap Values( @pass, @role,@MaNV)
End
GO


Select * from DangNhap
exec sp_ThemDangNhap '12345',1,'QL001'
exec sp_ThemDangNhap '12345',0,'KS001'