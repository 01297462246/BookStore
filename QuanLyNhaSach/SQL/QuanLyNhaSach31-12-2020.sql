USE [master]
GO
Drop Database QuanLyNhaSach
GO
/****** Object:  Database [QuanLyNhaSach]    Script Date: 31-Dec-20 7:15:16 AM ******/
CREATE DATABASE [QuanLyNhaSach] 
GO
ALTER DATABASE [QuanLyNhaSach] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyNhaSach] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyNhaSach] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyNhaSach] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyNhaSach] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyNhaSach] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyNhaSach] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyNhaSach] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyNhaSach] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyNhaSach] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyNhaSach] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyNhaSach] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyNhaSach] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyNhaSach] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyNhaSach] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyNhaSach] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyNhaSach] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyNhaSach] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyNhaSach] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyNhaSach] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyNhaSach] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyNhaSach] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyNhaSach] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyNhaSach] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyNhaSach] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyNhaSach] SET DB_CHAINING OFF 
GO
USE [QuanLyNhaSach]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaSach] [char](10) NOT NULL,
	[MaHD] [char](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_SachHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC,
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[Password] [nvarchar](30) NULL,
	[PhanQuyen] [bit] NULL,
	[MaNV] [char](10) NOT NULL,
 CONSTRAINT [PK_DangNhap] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GianHang]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GianHang](
	[MaGH] [char](10) NOT NULL,
	[TenGH] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_GianHang] PRIMARY KEY CLUSTERED 
(
	[MaGH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [char](10) NOT NULL,
	[NgayXuatHoaDon] [date] NULL,
	[TongTien] [float] NULL,
	[LoaiHoaDon] [nvarchar](30) NULL,
	[MaNV] [char](10) NOT NULL,
	[MaKH] [char](10) NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [char](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[NamSinh] [date] NULL,
	[DoiTuong] [nvarchar](30) NULL,
	[SDT] [char](10) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [char](10) NOT NULL,
	[TenNXB] [nvarchar](50) NULL,
	[SDT] [char](10) NULL,
	[SoFax] [char](10) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[NgayNhap] [date] NULL,
	[TongSoLuong] [int] NULL,
	[GiaTien] [float] NULL,
	[MaNV] [char](10) NOT NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [char](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[CMND] [char](12) NULL,
	[SDT] [char](13) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[MaGH] [char](10) NULL,
	[MaQL] [char](10) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [char](10) NOT NULL,
	[TenSach] [nvarchar](50) NULL,
	[TheLoai] [nvarchar](30) NULL,
	[GiaBan] [float] NULL,
	[TenNXB] [nvarchar](50) NULL,
	[TacGia] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[NgayXuatBan] [date] NULL,
	[NgayNhap] [date] NULL,
	[GiamGia] [int] NULL,
	[MaNV] [char](10) NOT NULL,
	[MaGH] [char](10) NOT NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[MaTL] [char](10) NOT NULL,
	[TenTL] [nvarchar](30) NULL,
	[MaNCC] [char](10) NULL,
 CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED 
(
	[MaTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_ChiTietHoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_HoaDon_ChiTietHoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_Sach_ChiTietHoaDon] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_Sach_ChiTietHoaDon]
GO
ALTER TABLE [dbo].[DangNhap]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_DangNhap] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[DangNhap] CHECK CONSTRAINT [FK_NhanVien_DangNhap]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_HoaDon] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_KhachHang_HoaDon]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_HoaDon] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_NhanVien_HoaDon]
GO
ALTER TABLE [dbo].[NhaCungCap]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_NhaCungCap] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[NhaCungCap] CHECK CONSTRAINT [FK_NhanVien_NhaCungCap]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_GianHang_NhanVien] FOREIGN KEY([MaGH])
REFERENCES [dbo].[GianHang] ([MaGH])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_GianHang_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_QuanLy_NhanVien] FOREIGN KEY([MaQL])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_QuanLy_NhanVien]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_GianHang_Sach] FOREIGN KEY([MaGH])
REFERENCES [dbo].[GianHang] ([MaGH])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_GianHang_Sach]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_Sach] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_NhanVien_Sach]
GO
ALTER TABLE [dbo].[TheLoai]  WITH CHECK ADD  CONSTRAINT [FK_NXB_TheLoai] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[TheLoai] CHECK CONSTRAINT [FK_NXB_TheLoai]
GO
/****** Object:  StoredProcedure [dbo].[sp_KhachHang]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_KhachHang]
AS
BEGIN
	SELECT * FROM KhachHang;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDangNhap]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LayDangNhap]
AS
BEGIN
	SELECT * FROM DangNhap
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDangNhapNV]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LayDangNhapNV](@MANV char(10),@PASSWORD nvarchar(30), @TYPE bit)
AS 
BEGIN
	SELECT * FROM DangNhap
	WHERE @MANV = MaNV AND @PASSWORD = [Password] AND @TYPE = PhanQuyen; 
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaGH]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	PROC [dbo].[sp_SuaGH](@MAGH char(10), @TENGH nvarchar(30), @SOLUONG int)
AS
BEGIN
	UPDATE GianHang
	SET TenGH = @TENGH, SoLuong = @SOLUONG
	WHERE  GianHang.MaGH = @MAGH 
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaKhachHang]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_SuaKhachHang](@MAKH char(10),@TENKH nvarchar(50), @NAMSINH Datetime, @DOITUONG nvarchar(30),@SDT char(10))
AS
BEGIN 
	UPDATE KhachHang
	SET TenKH = @TENKH, NamSinh = @NAMSINH, DoiTuong = @DOITUONG, SDT = @SDT;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaNhanVien]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_SuaNhanVien]( @MANV char(10), @TENNV nvarchar(50), @CMND char(12), @SDT char(11), @DC nvarchar(50), @MAGH char(10), @MAQL char(10))
AS
BEGIN
	UPDATE NhanVien
	SET TenNV = @TENNV, CMND = @CMND, SDT = @SDT, DiaChi = @DC, MaGH = @MAGH, MaQL = @MAQL
	WHERE MaNV = @MANV
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaQuanLy]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_SuaQuanLy]( @MANV char(10), @TENNV nvarchar(50), @CMND char(12), @SDT char(11), @DC nvarchar(50))
AS
BEGIN
	UPDATE NhanVien
	SET TenNV = @TENNV, CMND = @CMND, SDT = @SDT, DiaChi = @DC
	WHERE MaNV = @MANV
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaSach]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_SuaSach](
 @MASACH char(10)
,@TENSACH nvarchar(50)
, @THELOAI nvarchar(30)
, @GIABAN float
, @TENNXB nvarchar(50)
, @TACGIA nvarchar(50)
, @SOLUONG int
, @NXB date
, @NGAYNHAP date
, @GIAMGIA int
, @MANV char(10)
, @MAGH char(10))
AS
BEGIN
	 UPDATE Sach
	 SET MaGH = @MAGH, TenSach = @TENSACH, TheLoai = @THELOAI, TenNXB = @TENNXB, TacGia = @TACGIA, MaNV = @MANV, GiamGia = @GIAMGIA, NgayXuatBan = @NXB, NgayNhap = @NGAYNHAP, SoLuong = @SOLUONG, GiaBan = @GIABAN
	 WHERE MaSach = @MASACH
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_TheLoai]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------------
--The loai
CREATE PROC [dbo].[sp_TheLoai]
AS
BEGIN
	SELECT* FROM TheLoai 
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemGH]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ThemGH](@MAGH char(10), @TENGH nvarchar(30), @SOLUONG int)
AS
BEGIN
	INSERT INTO GianHang
	VALUES(@MAGH, @TENGH, @SOLUONG)
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemKhachHang]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ThemKhachHang](@MAKH char(10),@TENKH nvarchar(50), @NAMSINH Datetime, @DOITUONG nvarchar(30),@SDT char(10))
AS
BEGIN 
	INSERT INTO KhachHang(MaKH, TenKH, NamSinh, DoiTuong, SDT)
	VALUES(@MAKH, @TENKH, @NAMSINH, @DOITUONG, @SDT);
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemNhanVien]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ThemNhanVien](@MANV char(10), @TENNV nvarchar(50), @CMND char(12), @SDT char(11), @DC nvarchar(50), @MAGH char(10), @MaQL char(10))
AS
BEGIN
	INSERT INTO NhanVien(MaNV, TenNV, CMND, SDT, DiaChi, MaGH, MaQL)
	VALUES(@MANV, @TENNV, @CMND, @SDT, @DC, @MAGH, @MaQL)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemQuanLy]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ThemQuanLy](@MANV char(10), @TENNV nvarchar(50), @CMND char(12), @SDT char(11), @DC nvarchar(50))
AS 
BEGIN
	INSERT INTO NhanVien(MaNV, TenNV, CMND, SDT, DiaChi)
	VALUES(@MANV, @TENNV, @CMND, @SDT, @DC)
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemSach]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--THEM 
CREATE PROC [dbo].[sp_ThemSach](@MASACH char(10), @MAGH char(10), @TENSACH nvarchar(50)
, @THELOAI nvarchar(30), @TENNXB nvarchar(50), @TACGIA nvarchar(50)
, @MANV char(10), @GIAMGIA int, @NXB date
, @NGAYNHAP date, @SOLUONG int, @GIABAN float)
AS
BEGIN
	 INSERT INTO Sach(MaSach, MaGH, TenSach, TheLoai, TenNXB, TacGia, MaNV, GiamGia, NgayXuatBan, NgayNhap, SoLuong, GiaBan)
	 VALUES(@MASACH, @MAGH, @TENSACH, @THELOAI, @TENNXB, @TACGIA, @MANV, @GIAMGIA, @NXB, @NGAYNHAP, @SOLUONG, @GIABAN)
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemTheLoai]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_ThemTheLoai](@MATL char(10),@TENTL nvarchar(30), @MANCC char(10))
AS
BEGIN
	INSERT INTO TheLoai
	VALUES(@MATL, @TENTL, @MANCC) 
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_TruyXuatGH]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_TruyXuatGH]
AS
BEGIN
	SELECT * 
	FROM GianHang
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_TruyXuatNhanVien]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_TruyXuatNhanVien]
AS
BEGIN
	SELECT*
	FROM NhanVien;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_TruyXuatSach]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TRUY XUAT SACH "@MASACH", "@MAGH", "@TENSACH", "@THELOAI", "@TENNCC", "@TACGIA", "@MANV", "@GIAMGIA", "@NXB", "@NGAYNHAP", "@SOLUONG", "GIAMGIA"
CREATE PROC [dbo].[sp_TruyXuatSach]
AS
BEGIN
	SELECT *
	FROM Sach
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaGH]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	PROC [dbo].[sp_XoaGH](@MAGH char(10))
AS
BEGIN
	DELETE FROM GianHang
	WHERE  GianHang.MaGH = @MAGH 
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaKhachHang]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_XoaKhachHang](@MAKH char(10))
AS
BEGIN 
	DELETE FROM KhachHang
	WHERE @MAKH = KhachHang.MaKH
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaNhanVien]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--XOA NHAN VIEN
CREATE PROC [dbo].[sp_XoaNhanVien]( @MANV char(10))
AS
BEGIN
	DELETE FROM NhanVien
	WHERE MaNV = @MANV
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaSach]    Script Date: 31-Dec-20 7:15:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--XOA
CREATE PROC [dbo].[sp_XoaSach](@MASACH char(10))
AS
BEGIN
	 DELETE FROM Sach
	 WHERE MaSach = @MASACH
END;
GO
USE [master]
GO
ALTER DATABASE [QuanLyNhaSach] SET  READ_WRITE 
GO
