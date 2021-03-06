USE [master]
GO
/****** Object:  Database [Hotel_Manager]    Script Date: 8/2/2021 11:57:07 AM ******/
CREATE DATABASE [Hotel_Manager]
GO
ALTER DATABASE [Hotel_Manager] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hotel_Manager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hotel_Manager] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hotel_Manager] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hotel_Manager] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hotel_Manager] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hotel_Manager] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hotel_Manager] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Hotel_Manager] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hotel_Manager] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hotel_Manager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hotel_Manager] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hotel_Manager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hotel_Manager] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hotel_Manager] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hotel_Manager] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hotel_Manager] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Hotel_Manager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hotel_Manager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hotel_Manager] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hotel_Manager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hotel_Manager] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hotel_Manager] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hotel_Manager] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hotel_Manager] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Hotel_Manager] SET  MULTI_USER 
GO
ALTER DATABASE [Hotel_Manager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hotel_Manager] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hotel_Manager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hotel_Manager] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hotel_Manager] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Hotel_Manager] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Hotel_Manager] SET QUERY_STORE = OFF
GO
USE [Hotel_Manager]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 8/2/2021 11:57:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[Taikhoan] [nvarchar](50) NOT NULL,
	[Matkhau] [nvarchar](50) NULL,
	[FullName] [nvarchar](50) NULL,
	[Email] [varchar](50) NULL,
	[phanquyen] [int] NULL,
	[trangthai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Taikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hoadon]    Script Date: 8/2/2021 11:57:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoadon](
	[id_hoadon] [nvarchar](50) NOT NULL,
	[MaPhong] [nvarchar](50) NULL,
	[Makh] [nvarchar](50) NULL,
	[Manv] [nvarchar](50) NULL,
	[Ngaydatphong] [date] NULL,
	[Ngaynhanphong] [date] NULL,
	[Ngaytraphong] [date] NULL,
	[soluongnguoi] [int] NULL,
	[phiphong] [real] NULL,
	[phiphuthu] [real] NULL,
	[thanhtien] [real] NULL,
	[trangthai] [nvarchar](50) NULL,
 CONSTRAINT [PK__Hoadon__F9F51331D9F46EA8] PRIMARY KEY CLUSTERED 
(
	[id_hoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khachhang]    Script Date: 8/2/2021 11:57:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khachhang](
	[MaKh] [nvarchar](50) NOT NULL,
	[Tenkh] [nvarchar](50) NULL,
	[Ngaysinh] [date] NULL,
	[gioitinh] [nvarchar](10) NULL,
	[sdt] [nvarchar](15) NULL,
	[Cmnd] [nvarchar](30) NULL,
	[Email] [nvarchar](500) NULL,
 CONSTRAINT [PK__Khachhan__2725CF7E959C02AE] PRIMARY KEY CLUSTERED 
(
	[MaKh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khohang]    Script Date: 8/2/2021 11:57:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khohang](
	[Maitem] [nvarchar](15) NOT NULL,
	[TenItem] [nvarchar](500) NULL,
	[gianhap] [real] NULL,
	[soluong] [int] NULL,
	[giaban] [real] NULL,
PRIMARY KEY CLUSTERED 
(
	[Maitem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LPhong]    Script Date: 8/2/2021 11:57:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LPhong](
	[loaiphong] [nvarchar](50) NOT NULL,
	[mota] [nvarchar](50) NULL,
	[giaphong] [real] NULL,
PRIMARY KEY CLUSTERED 
(
	[loaiphong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 8/2/2021 11:57:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhanvien](
	[Manv] [nvarchar](50) NOT NULL,
	[Tennv] [nvarchar](50) NULL,
	[Ngaysinh] [date] NULL,
	[gioitinh] [nvarchar](10) NULL,
	[sdt] [nvarchar](15) NULL,
	[Cmnd] [nvarchar](30) NULL,
	[Email] [nvarchar](500) NULL,
 CONSTRAINT [PK__Nhanvien__2724CB02802E95C6] PRIMARY KEY CLUSTERED 
(
	[Manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhapKho]    Script Date: 8/2/2021 11:57:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhapKho](
	[Id_hd] [nvarchar](15) NOT NULL,
	[sanpham] [nvarchar](500) NULL,
	[ngaynhap] [date] NULL,
	[Thanhtien] [real] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_hd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 8/2/2021 11:57:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [nvarchar](50) NOT NULL,
	[TenPhong] [nvarchar](50) NULL,
	[loaiphong] [nvarchar](50) NULL,
	[Mota] [nvarchar](1000) NULL,
	[songtoida] [int] NULL,
	[trangthai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__Phong__20BD5E5BC2911111] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phuthu]    Script Date: 8/2/2021 11:57:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phuthu](
	[MaPhu] [nvarchar](15) NOT NULL,
	[MaKh] [nvarchar](50) NULL,
	[Maitem] [nvarchar](15) NULL,
	[tensp] [nvarchar](500) NULL,
	[giaban] [real] NULL,
	[soluong] [int] NULL,
	[trangthai] [int] NULL,
	[thanhtien] [real] NULL,
 CONSTRAINT [PK__Phuthu__3AE0AA1138EEFA06] PRIMARY KEY CLUSTERED 
(
	[MaPhu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DangNhap] ([Taikhoan], [Matkhau], [FullName], [Email], [phanquyen], [trangthai]) VALUES (N' ', N'123456', N'Trần Hữu Anh', N'anh@gmail.com', 1, 1)
INSERT [dbo].[DangNhap] ([Taikhoan], [Matkhau], [FullName], [Email], [phanquyen], [trangthai]) VALUES (N'nguoidung', N'123456', N'Ngô Khai Anh', N'anhkh@gmail.com', 3, 1)
INSERT [dbo].[DangNhap] ([Taikhoan], [Matkhau], [FullName], [Email], [phanquyen], [trangthai]) VALUES (N'nguoidung2', N'123456', N'Trần Hữu Anh', N'anhkh@gmail.com', 3, 0)
INSERT [dbo].[DangNhap] ([Taikhoan], [Matkhau], [FullName], [Email], [phanquyen], [trangthai]) VALUES (N'quanly', N'123456', N'Trần Mạnh Hùng', N'hung@gmail.com', 2, 1)
GO
INSERT [dbo].[Hoadon] ([id_hoadon], [MaPhong], [Makh], [Manv], [Ngaydatphong], [Ngaynhanphong], [Ngaytraphong], [soluongnguoi], [phiphong], [phiphuthu], [thanhtien], [trangthai]) VALUES (N'hd01', N'ph01', N'kh01', N'nv03', NULL, CAST(N'2021-07-07' AS Date), CAST(N'2021-07-10' AS Date), 3, 1800000, 420000, 2220000, N'Da Tra Phong')
INSERT [dbo].[Hoadon] ([id_hoadon], [MaPhong], [Makh], [Manv], [Ngaydatphong], [Ngaynhanphong], [Ngaytraphong], [soluongnguoi], [phiphong], [phiphuthu], [thanhtien], [trangthai]) VALUES (N'hd02', N'ph02', N'kh06', N'nv02', CAST(N'2021-07-10' AS Date), CAST(N'2021-07-07' AS Date), CAST(N'2021-07-10' AS Date), 2, 900000, 280000, 1180000, N'Da Tra Phong')
GO
INSERT [dbo].[Khachhang] ([MaKh], [Tenkh], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email]) VALUES (N'kh01', N'Đoàn Duy Khanh', CAST(N'1993-02-03' AS Date), N'Nam', N'386123242', N'146582362', N'khach@gmail.com')
INSERT [dbo].[Khachhang] ([MaKh], [Tenkh], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email]) VALUES (N'kh02', N'Trần Doãn Mạnh', CAST(N'1992-12-05' AS Date), N'Nam', N'386427880', N'146582895', N'manh@gmail.com')
INSERT [dbo].[Khachhang] ([MaKh], [Tenkh], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email]) VALUES (N'kh03', N'Trần Văn Minh', CAST(N'1996-09-11' AS Date), N'Nam', N'366421315', N'146582662', N'Minh@gmail.com')
INSERT [dbo].[Khachhang] ([MaKh], [Tenkh], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email]) VALUES (N'kh04', N'Trần Hoài Nam', CAST(N'1999-01-14' AS Date), N'Nam', N'976445444', N'146582321', N'Namhh@gmail.com')
INSERT [dbo].[Khachhang] ([MaKh], [Tenkh], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email]) VALUES (N'kh05', N'Nguyen Van A', CAST(N'2000-12-18' AS Date), N'Nam', N'1234568', N'123456456', N'ancom@gamil.com')
INSERT [dbo].[Khachhang] ([MaKh], [Tenkh], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email]) VALUES (N'kh06', N'Đoàn Thị Liên', CAST(N'2000-10-07' AS Date), N'Nữ', N'123456789', N'1234568', N'Liendien@gmail.com')
GO
INSERT [dbo].[Khohang] ([Maitem], [TenItem], [gianhap], [soluong], [giaban]) VALUES (N'it01', N'Cocacola', 6000, 2000, 10000)
INSERT [dbo].[Khohang] ([Maitem], [TenItem], [gianhap], [soluong], [giaban]) VALUES (N'it02', N'Khăn giương', 10000, 200, 20000)
INSERT [dbo].[Khohang] ([Maitem], [TenItem], [gianhap], [soluong], [giaban]) VALUES (N'it04', N'xe đạp', 50000, 20, 100000)
INSERT [dbo].[Khohang] ([Maitem], [TenItem], [gianhap], [soluong], [giaban]) VALUES (N'it05', N'Khăn mặt', 10000, 200, 20000)
INSERT [dbo].[Khohang] ([Maitem], [TenItem], [gianhap], [soluong], [giaban]) VALUES (N'it06', N'BimBims', 8000, 500, 10000)
GO
INSERT [dbo].[LPhong] ([loaiphong], [mota], [giaphong]) VALUES (N'Deluxe', N'Phòng trung cấp', 500000)
INSERT [dbo].[LPhong] ([loaiphong], [mota], [giaphong]) VALUES (N'Standard', N'Phòng bình dân', 300000)
INSERT [dbo].[LPhong] ([loaiphong], [mota], [giaphong]) VALUES (N'Superior', N'Phòng thường', 400000)
INSERT [dbo].[LPhong] ([loaiphong], [mota], [giaphong]) VALUES (N'VIP', N'Phòng cao cấp', 600000)
GO
INSERT [dbo].[Nhanvien] ([Manv], [Tennv], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email]) VALUES (N'nv01', N'Trần Hữu Anh', CAST(N'1996-08-25' AS Date), N'Nam', N'0386143805', N'145715186', N'anhth.hh@gmail.com')
INSERT [dbo].[Nhanvien] ([Manv], [Tennv], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email]) VALUES (N'nv02', N'Trần Văn Hiệp', CAST(N'1998-12-15' AS Date), N'Nam', N'0366524687', N'145715189', N'hieptr.hh@gmail.com')
INSERT [dbo].[Nhanvien] ([Manv], [Tennv], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email]) VALUES (N'nv03', N'Hoang Van Nam', CAST(N'1999-03-02' AS Date), N'Nam', N'0385145235', N'145715125', N'namhv.hh@gmail.com')
INSERT [dbo].[Nhanvien] ([Manv], [Tennv], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email]) VALUES (N'nv04', N'Trần Thị Linh', CAST(N'2000-06-07' AS Date), N'Nữ', N'0366888521', N'154862123', N'linhtt.hh@gmail.com')
GO
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [loaiphong], [Mota], [songtoida], [trangthai]) VALUES (N'ph01', N'6001', N'VIP', N'Phòng đẹp, rộng 5*15m, có cửa sổ, view đẹp nhìn ra biển', 4, N'Da Dat')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [loaiphong], [Mota], [songtoida], [trangthai]) VALUES (N'ph02', N'4001', N'Standard', N'Phòng đẹp, rộng 4*6m, có cửa sổ, view hồ ', 2, N'Trong')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [loaiphong], [Mota], [songtoida], [trangthai]) VALUES (N'ph03', N'4002', N'Superior ', N'Phòng đẹp, rộng 10*4m, có cửa sổ, view đẹp nhìn ra biển', 4, N'Da Dat')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [loaiphong], [Mota], [songtoida], [trangthai]) VALUES (N'ph04', N'4003', N'Deluxe', N'Phòng đẹp, rộng 3*8m, có cửa sổ, view đẹp nhìn ra biển', 4, N'Trong')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [loaiphong], [Mota], [songtoida], [trangthai]) VALUES (N'ph05', N'4004', N'Standard', N'Phòng đẹp, rộng 4*6m, có cửa sổ, view đẹp nhìn ra biển', 2, N'Trống')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [loaiphong], [Mota], [songtoida], [trangthai]) VALUES (N'ph06', N'4005', N'Standard', N'Phòng đẹp, rộng 4*6m, có cửa sổ, view đẹp nhìn ra biển', 2, N'Trống')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [loaiphong], [Mota], [songtoida], [trangthai]) VALUES (N'ph07', N'4006', N'Superior', N'Phòng đẹp, rộng 10*4m, có cửa sổ, view đẹp nhìn ra biển', 4, N'Trong')
GO
INSERT [dbo].[Phuthu] ([MaPhu], [MaKh], [Maitem], [tensp], [giaban], [soluong], [trangthai], [thanhtien]) VALUES (N'ph01', N'kh01', N'it01', N'BimBims', 10000, 10, 1, 100000)
INSERT [dbo].[Phuthu] ([MaPhu], [MaKh], [Maitem], [tensp], [giaban], [soluong], [trangthai], [thanhtien]) VALUES (N'ph02', N'kh01', N'it02', N'Khăn giương', 20000, 1, 1, 20000)
INSERT [dbo].[Phuthu] ([MaPhu], [MaKh], [Maitem], [tensp], [giaban], [soluong], [trangthai], [thanhtien]) VALUES (N'ph03', N'kh06', N'it06', N'BimBims', 10000, 3, 0, 30000)
INSERT [dbo].[Phuthu] ([MaPhu], [MaKh], [Maitem], [tensp], [giaban], [soluong], [trangthai], [thanhtien]) VALUES (N'ph04', N'kh06', N'it06', N'BimBims', 10000, 5, 0, 50000)
INSERT [dbo].[Phuthu] ([MaPhu], [MaKh], [Maitem], [tensp], [giaban], [soluong], [trangthai], [thanhtien]) VALUES (N'ph05', N'kh06', N'it04', N'xe d?p', 100000, 2, 0, 200000)
INSERT [dbo].[Phuthu] ([MaPhu], [MaKh], [Maitem], [tensp], [giaban], [soluong], [trangthai], [thanhtien]) VALUES (N'ph06', N'kh01', N'it04', N'xe d?p', 100000, 3, 0, 300000)
INSERT [dbo].[Phuthu] ([MaPhu], [MaKh], [Maitem], [tensp], [giaban], [soluong], [trangthai], [thanhtien]) VALUES (N'ph07', N'kh05', N'it04', N'xe d?p', 100000, 3, 0, 300000)
INSERT [dbo].[Phuthu] ([MaPhu], [MaKh], [Maitem], [tensp], [giaban], [soluong], [trangthai], [thanhtien]) VALUES (N'ph08', N'kh05', N'it06', N'BimBims', 10000, 2, 0, 20000)
GO
ALTER TABLE [dbo].[Hoadon]  WITH CHECK ADD  CONSTRAINT [FK__Hoadon__Makh__48CFD27E] FOREIGN KEY([Makh])
REFERENCES [dbo].[Khachhang] ([MaKh])
GO
ALTER TABLE [dbo].[Hoadon] CHECK CONSTRAINT [FK__Hoadon__Makh__48CFD27E]
GO
ALTER TABLE [dbo].[Hoadon]  WITH CHECK ADD  CONSTRAINT [FK__Hoadon__Manv__4AB81AF0] FOREIGN KEY([Manv])
REFERENCES [dbo].[Nhanvien] ([Manv])
GO
ALTER TABLE [dbo].[Hoadon] CHECK CONSTRAINT [FK__Hoadon__Manv__4AB81AF0]
GO
ALTER TABLE [dbo].[Hoadon]  WITH CHECK ADD  CONSTRAINT [FK__Hoadon__MaPhong__49C3F6B7] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[Hoadon] CHECK CONSTRAINT [FK__Hoadon__MaPhong__49C3F6B7]
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK__Phong__loaiphong__3E52440B] FOREIGN KEY([loaiphong])
REFERENCES [dbo].[LPhong] ([loaiphong])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK__Phong__loaiphong__3E52440B]
GO
ALTER TABLE [dbo].[Phuthu]  WITH CHECK ADD  CONSTRAINT [FK__Phuthu__Maitem__45F365D3] FOREIGN KEY([Maitem])
REFERENCES [dbo].[Khohang] ([Maitem])
GO
ALTER TABLE [dbo].[Phuthu] CHECK CONSTRAINT [FK__Phuthu__Maitem__45F365D3]
GO
ALTER TABLE [dbo].[Phuthu]  WITH CHECK ADD  CONSTRAINT [FK__Phuthu__MaKh__44FF419A] FOREIGN KEY([MaKh])
REFERENCES [dbo].[Khachhang] ([MaKh])
GO
ALTER TABLE [dbo].[Phuthu] CHECK CONSTRAINT [FK__Phuthu__MaKh__44FF419A]
GO
USE [master]
GO
ALTER DATABASE [Hotel_Manager] SET  READ_WRITE 
GO
