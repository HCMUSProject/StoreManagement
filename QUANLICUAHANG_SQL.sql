﻿create database QuanLyCuaHang
use QuanLyCuaHang

CREATE TABLE LOAISANPHAM
(
	ID_MALOAI INT IDENTITY(0,1) NOT NULL,
	TENLOAI NVARCHAR(45) NOT NULL,
	ISDELETED BIT NOT NULL,
	PRIMARY KEY(ID_MALOAI)
)

CREATE TABLE SANPHAM
(
	ID_MASP INT IDENTITY(0,1) NOT NULL,
	ID_MALOAI INT NOT NULL,
	ID_HANGSX INT NOT NULL,
	TENSP NVARCHAR(45) NOT NULL,
	SOLUONG INT NOT NULL,
	DONGIA INT NOT NULL,
	ISDELETED BIT NOT NULL,
	HINHANH IMAGE NOT NULL,
	PRIMARY KEY(ID_MASP)
)

CREATE TABLE CHITIETCAUHINH
(
	ID_CHITIETCAUHINH INT IDENTITY(0,1) NOT NULL,
	ID_MASP INT NOT NULL,
	CPU NVARCHAR(30) NULL,
	GPU NVARCHAR(30) NULL,
	RAM NVARCHAR(30) NULL,
	BONHO NVARCHAR(30) NULL,
	MANHINH NVARCHAR(30) NULL,
	CAMERA NVARCHAR(30) NULL,
	PIN NVARCHAR(30) NULL,
	HEDIEUHANH NVARCHAR(30) NULL,
	KHAC NVARCHAR(60) NULL,
	ISDELETED BIT NOT NULL,
	PRIMARY KEY(ID_CHITIETCAUHINH),
	FOREIGN KEY(ID_MASP) REFERENCES SANPHAM(ID_MASP)
)

CREATE TABLE HANGSANXUAT
(
	ID_HANGSX INT IDENTITY(0,1) NOT NULL,
	TENHANG NVARCHAR(45) NOT NULL,
	ISDELETED BIT NOT NULL,
	PRIMARY KEY(ID_HANGSX)
)


CREATE TABLE LICHSUNHAPKHO
(
	ID_LICHSU INT IDENTITY(0,1) NOT NULL,
	ID_MASP INT NULL,
	SOLUONG INT NULL,
	DONGIA INT NULL,
	NGAYNHAP DATE,
	PRIMARY KEY(ID_LICHSU),
	CONSTRAINT LICHSUNHAPKHO_FK_SANPHAM FOREIGN KEY(ID_MASP) REFERENCES SANPHAM(ID_MASP)
)


CREATE TABLE LICHSUBANHANG
(
	ID_LICHSUBANHANG INT IDENTITY(0,1) NOT NULL,
	NGAYBAN DATE NOT NULL,
	TONGTIEN INT NOT NULL,

	TENKHACHHANG NVARCHAR(50) NULL,
	CMND NVARCHAR(20) NULL,
	SODIENTHOAI NVARCHAR(20) NULL,
	DIACHI NVARCHAR(100) NULL,

	ISDELETED BIT NOT NULL,
	PRIMARY KEY(ID_LICHSUBANHANG),
)


CREATE TABLE CHITIETDONHANG
(
	ID_CHITIET INT IDENTITY(0,1) NOT NULL,
	ID_LICHSUBANHANG INT NOT NULL,
	ID_MASP INT NOT NULL,
	SOLUONG INT NOT NULL,
	DONGIA INT NOT NULL,
	ISDELETED BIT NOT NULL,
	PRIMARY KEY(ID_CHITIET),
	CONSTRAINT CHITIETLICHSUBANHANG_FK_LICHSUBANHANG FOREIGN KEY(ID_LICHSUBANHANG) REFERENCES LICHSUBANHANG(ID_LICHSUBANHANG),
	CONSTRAINT CHITIETLICHSUBANHANG_FK_SANPHAM FOREIGN KEY(ID_MASP) REFERENCES SANPHAM(ID_MASP),
)

CREATE TABLE CHITIETKHUYENMAI
(
	ID_CHITIETKHUYENMAI INT IDENTITY(0,1) NOT NULL,
	ID_LICHSUBANHANG INT NOT NULL,
	ID_KHUYENMAI INT NULL,
	CONSTRAINT CHITIETKHUYENMAI_PK PRIMARY KEY(ID_CHITIETKHUYENMAI),
	CONSTRAINT CHITIETKHUYENMAI_FK_LICHSUBANHANG FOREIGN KEY(ID_LICHSUBANHANG) REFERENCES LICHSUBANHANG(ID_LICHSUBANHANG),
	CONSTRAINT CHITIETKHUYENMAI_FK_KHUYENMAI FOREIGN KEY(ID_KHUYENMAI) REFERENCES KHUYENMAI(ID_KHUYENMAI)
)


CREATE TABLE KHUYENMAI
(
	ID_KHUYENMAI INT IDENTITY(0,1) NOT NULL,
	TENKHUYENMAI NVARCHAR(100) NOT NULL,
	PHANTRAM INT NOT NULL,
	TIENTOIDA INT NULL,
	NGAYBATDAU DATETIME NULL,
	NGAYKETTHUC DATETIME NULL,
	ISDELETED BIT NOT NULL,
	CONSTRAINT KHUYENMAI_PK PRIMARY KEY(ID_KHUYENMAI)
)


ALTER TABLE SANPHAM
ADD CONSTRAINT SANPHAM_FK_LOAISANPHAM FOREIGN KEY(ID_MALOAI) REFERENCES LOAISANPHAM(ID_MALOAI)

ALTER TABLE SANPHAM
ADD CONSTRAINT SANPHAM_FK_HANGSANXUAT FOREIGN KEY(ID_HANGSX) REFERENCES HANGSANXUAT(ID_HANGSX)

-- //////////////////////////////////////////////////////////////////////
--		PROCEDURE

create procedure GetLoaiSanPham
as
	SELECT ID_MALOAI, TENLOAI FROM LOAISANPHAM where ISDELETED=0
	return


create procedure GetSanPhamTheoLoai
@MaLoai int
as
	if (@MaLoai = -1)
		SELECT * FROM SANPHAM WHERE ISDELETED=0 ORDER BY ID_MASP DESC
	else
		SELECT * FROM SANPHAM WHERE ISDELETED=0 and SANPHAM.ID_MALOAI=@MaLoai ORDER BY ID_MASP DESC
	return


CREATE PROCEDURE TimKiemSanPham
@Chuoi NVARCHAR(100)
AS
	SELECT ID_MASP, TENSP, SANPHAM.ID_HANGSX, ID_MALOAI, SOLUONG, DONGIA, HINHANH FROM SANPHAM, HANGSANXUAT 
	WHERE SANPHAM.ISDELETED = 0 AND SANPHAM.ID_HANGSX = HANGSANXUAT.ID_HANGSX 
		AND (TENSP LIKE '%' + @Chuoi + '%' OR HANGSANXUAT.TENHANG LIKE '%' + @Chuoi + '%' )


create procedure GetSoLuongSanPhamTheoDanhMuc
@MaLoai int
as
	if (@MaLoai = -1)
		SELECT COUNT(*) FROM SANPHAM where ISDELETED=0
	else
		SELECT COUNT(*) FROM SANPHAM where ISDELETED=0 and SANPHAM.ID_MALOAI=@MaLoai
	return

create procedure GetThongTinSanPhamBangID
@MaSP int
as
	SELECT SANPHAM.TENSP, HANGSANXUAT.TENHANG, SANPHAM.SOLUONG, SANPHAM.DONGIA, SANPHAM.HINHANH 
	FROM SANPHAM,LOAISANPHAM,HANGSANXUAT 
	WHERE SANPHAM.ISDELETED=0 AND SANPHAM.ID_MASP=@MaSP AND LOAISANPHAM.ID_MALOAI=SANPHAM.ID_MALOAI AND SANPHAM.ID_HANGSX=HANGSANXUAT.ID_HANGSX
	return

create procedure GetCauHinhSanPham
@MaSP int
as
	SELECT * FROM CHITIETCAUHINH WHERE ID_MASP=@MaSP AND ISDELETED=0
	return

create procedure XoaSanPhamBangID
@MaSP int
as
	UPDATE SANPHAM SET ISDELETED=1 WHERE ID_MASP=@MaSP

CREATE PROCEDURE GetHangSanXuat
AS
	SELECT ID_HANGSX, TENHANG FROM HANGSANXUAT WHERE ISDELETED=0


CREATE PROCEDURE ThemMoiSanPham
@MaLoai INT, @MaHangSX INT, @TenSP NVARCHAR(45), @DonGia INT, @SoLuong INT, @HinhAnh IMAGE
AS
	INSERT INTO SANPHAM(ID_MALOAI,ID_HANGSX,TENSP,SOLUONG,DONGIA,ISDELETED,HINHANH) VALUES(@MaLoai,@MaHangSX,@TenSP,@SoLuong,@DonGia, 0 ,@HinhAnh)

CREATE PROCEDURE GetSanPhamTheoTenVaMaLoai
@TenSP NVARCHAR(45), @MaLoai int
AS
	SELECT * FROM SANPHAM WHERE ISDELETED=0 AND TENSP=@TenSP AND ID_MALOAI=@MaLoai


CREATE PROCEDURE ThemChiTietCauHinhSanPham
@MaSP INT, @CPU NVARCHAR(30), @GPU NVARCHAR(30), @RAM NVARCHAR(30), @BoNho NVARCHAR(30), @ManHinh NVARCHAR(30), @Camera NVARCHAR(30), 
@Pin NVARCHAR(30), @HeDieuHanh NVARCHAR(30), @Khac NVARCHAR(100)
AS
	INSERT INTO CHITIETCAUHINH(ID_MASP,CPU,GPU,RAM,BONHO,MANHINH,CAMERA,PIN,HEDIEUHANH,KHAC, ISDELETED) 
		VALUES(@MaSP,@CPU,@GPU,@RAM,@BoNho,@ManHinh,@Camera,@Pin,@HeDieuHanh,@Khac, 0)

CREATE PROCEDURE GetTatCaThongTinSanPhamBangID
@MaSP INT
AS
	SELECT SP.ID_MALOAI, SP.ID_MASP, SP.TENSP, SP.ID_HANGSX, SP.DONGIA, SP.SOLUONG, SP.HINHANH, 
	CT.ID_CHITIETCAUHINH, CT.CPU, CT.GPU, CT.RAM, CT.BONHO, CT.MANHINH, CT.CAMERA, CT.PIN, CT.HEDIEUHANH, CT.PIN, CT.KHAC
	 FROM SANPHAM SP LEFT JOIN CHITIETCAUHINH CT ON SP.ID_MASP = CT.ID_MASP
	 WHERE SP.ID_MASP=@MaSP AND SP.ISDELETED = 0

	 
CREATE PROCEDURE GetThongTinSanPhamTheoLoaiVaCachSapXep
@MaLoai INT, @CachSapXep INT
AS
	-- 0: GIA TANG DAN | 1: GIA GIAM DAN | 2: HANGSX
	 IF (@MaLoai = -1)
		 BEGIN
			IF (@CachSapXep = 1)	
				SELECT * FROM SANPHAM WHERE ISDELETED=0 ORDER BY DONGIA ASC
			IF (@CachSapXep = 2)	
				SELECT * FROM SANPHAM WHERE ISDELETED=0 ORDER BY DONGIA DESC
			IF (@CachSapXep = 3)	
				SELECT * FROM SANPHAM WHERE ISDELETED=0 ORDER BY ID_HANGSX ASC
		 END
	ELSE
		BEGIN
			IF (@CachSapXep = 1)	
				SELECT * FROM SANPHAM WHERE ISDELETED=0 AND ID_MALOAI=@MaLoai ORDER BY DONGIA ASC
			IF (@CachSapXep = 2)	
				SELECT * FROM SANPHAM WHERE ISDELETED=0 AND ID_MALOAI=@MaLoai ORDER BY DONGIA DESC
			IF (@CachSapXep = 3)	
				SELECT * FROM SANPHAM WHERE ISDELETED=0 AND ID_MALOAI=@MaLoai ORDER BY ID_HANGSX ASC
		 END


		 
CREATE PROCEDURE ThemLichSuNhapKho
@MaSP INT, @SoLuong INT, @DonGia INT, @NgayNhap DATE
AS
	-- nếu tồn tại sp thì cập nhật giá và số lượng
	IF (EXISTS(SELECT * FROM SANPHAM WHERE ID_MASP=@MaSP AND ISDELETED=0))
		BEGIN
			-- cập nhật giá và số lượng
			DECLARE @SoLuongHienTai INT
			SELECT @SoLuongHienTai = SOLUONG FROM SANPHAM WHERE ID_MASP=@MaSP AND ISDELETED = 0

			DECLARE @TongSoLuong INT

			SET @TongSoLuong = @SoLuong + @SoLuongHienTai

			IF (NOT EXISTS(SELECT * FROM LICHSUNHAPKHO WHERE ID_MASP=@MaSP))
				BEGIN
					INSERT INTO LICHSUNHAPKHO VALUES(@MaSP,@SoLuongHienTai,@DonGia,@NgayNhap)
				END
			ELSE
				BEGIN
					INSERT INTO LICHSUNHAPKHO VALUES(@MaSP,@SoLuong,@DonGia,@NgayNhap)

					UPDATE SANPHAM SET SOLUONG = @TongSoLuong WHERE ID_MASP=@MaSP
					UPDATE SANPHAM SET DONGIA = @DonGia WHERE ID_MASP=@MaSP
				END
		END
		
		

CREATE PROCEDURE UpdateThongTinVaCauHinhSanPham
@MaSP INT, @MaLoai INT, @MaHangSX INT, @TenSP NVARCHAR(45), @DonGia INT, @HinhAnh IMAGE,
@Id_ChiTietCauHinh INT, @CPU NVARCHAR(30), @GPU NVARCHAR(30), @RAM NVARCHAR(30), @BoNho NVARCHAR(30), @ManHinh NVARCHAR(30), @Camera NVARCHAR(30), 
@Pin NVARCHAR(30), @HeDieuHanh NVARCHAR(30), @Khac NVARCHAR(100)
AS
	UPDATE SANPHAM SET ID_MALOAI=@MaLoai, ID_HANGSX=@MaHangSX, TENSP=@TenSP, DONGIA=@DonGia, HINHANH=@HinhAnh
		WHERE ID_MASP=@MaSP AND ISDELETED=0
	UPDATE CHITIETCAUHINH SET CPU=@CPU, GPU=@GPU, RAM=@RAM, BONHO=@BoNho, MANHINH=@ManHinh, CAMERA=@Camera, PIN=@Pin,  HEDIEUHANH=@HeDieuHanh, KHAC=@Khac
		WHERE ID_CHITIETCAUHINH=@Id_ChiTietCauHinh

CREATE PROCEDURE CapNhatSoLuongSanPhamSauKhiBan
@MaSP INT, @SoLuongDaBan INT
AS
	DECLARE @SoLuongConLai INT

	SELECT @SoLuongConLai = SOLUONG FROM SANPHAM WHERE ISDELETED = 0 AND ID_MASP = @MaSP

	IF (@SoLuongConLai >= @SoLuongDaBan)
	BEGIN
		SET @SoLuongConLai = @SoLuongConLai - @SoLuongDaBan
		UPDATE SANPHAM SET SOLUONG = @SoLuongConLai WHERE ID_MASP=@MaSP AND ISDELETED = 0
	END


-- NEW PROCEDURE

CREATE PROCEDURE ThemLichSuBanHang
@NgayBan DATE, @TongTien INT, @TenKH NVARCHAR(50), @CMND NVARCHAR(20), @SDT NVARCHAR(20), @DiaChi NVARCHAR(20) 
AS
	BEGIN
		INSERT INTO LICHSUBANHANG VALUES(@NgayBan, @TongTien, @TenKH, @CMND, @SDT, @DiaChi, 0)
	END

	

CREATE PROCEDURE GetTatCaLichSuBanHang	
AS
	SELECT * FROM LICHSUBANHANG WHERE ISDELETED=0

CREATE PROCEDURE GetLichSuBanHangTheoNgay
@NgayBan DATE
AS
	SELECT * FROM LICHSUBANHANG WHERE ISDELETED = 0 AND NGAYBAN = @NgayBan ORDER BY ID_LICHSUBANHANG DESC

	
CREATE PROCEDURE ThemChiTietDonHang
@ID_LichSuBanHang INT, @ID_MaSP INT, @SoLuong INT, @DonGia INT
AS
	BEGIN
		INSERT INTO CHITIETDONHANG VALUES(@ID_LichSuBanHang, @ID_MaSP, @SoLuong, @DonGia, 0)
	END


	--- ////////////////////////////// KHUYẾN MÃI  ///////////////////////////////
CREATE PROCEDURE GetTatCaKhuyenMaiHienCo
@NgayHienTai DATETIME
AS
	SELECT * FROM KHUYENMAI WHERE ISDELETED = 0 AND (@NgayHienTai BETWEEN NGAYBATDAU AND NGAYKETTHUC) 

CREATE PROCEDURE GetTatCaCacKhuyenMaiChuaXoa
AS
	SELECT * FROM KHUYENMAI WHERE ISDELETED = 0

CREATE PROCEDURE ThemChiTietKhuyenMai
@MaLichSuBanHang INT, @MaKhuyenMai INT
AS
	INSERT INTO CHITIETKHUYENMAI VALUES(@MaLichSuBanHang, @MaKhuyenMai)

CREATE PROCEDURE ThemKhuyenMaiMoi
@TenKM NVARCHAR(100), @PhanTram INT, @TienToiDa INT, @NgayBatDau DATETIME, @NgayKetThuc DATETIME
AS
	INSERT INTO KHUYENMAI VALUES(@TenKM, @PhanTram, @TienToiDa, @NgayBatDau, @NgayKetThuc, 0)


CREATE PROCEDURE SuaKhuyenMai
@MaKM INT, @TenKM NVARCHAR(100), @PhanTram INT, @TienToiDa INT, @NgayBatDau DATETIME, @NgayKetThuc DATETIME
AS
	UPDATE KHUYENMAI SET TENKHUYENMAI=@TenKM, PHANTRAM=@PhanTram, TIENTOIDA=@TienToiDa, NGAYBATDAU = @NgayBatDau, NGAYKETTHUC=@NgayKetThuc
		WHERE ID_KHUYENMAI = @MaKM AND ISDELETED = 0

CREATE PROCEDURE XoaKhuyenMai
@MaKM INT
AS
	UPDATE KHUYENMAI SET ISDELETED = 1 WHERE ID_KHUYENMAI = @MaKM AND ISDELETED = 0


CREATE PROCEDURE GetCacSanPhamGanHetTheoLoaiSP
@MaLoai INT
AS
	SELECT ID_MASP, TENSP, SOLUONG FROM SANPHAM WHERE ISDELETED = 0 AND ID_MALOAI=@MaLoai ORDER BY SOLUONG ASC

	
CREATE PROCEDURE GetSanPhamDaBanTheoNam
@Nam INT, @MaLoai INT
AS
	SELECT SANPHAM.ID_MASP, SANPHAM.TENSP, COUNT(SANPHAM.ID_MASP) AS SOLUONG FROM SANPHAM, LICHSUBANHANG, CHITIETDONHANG
	WHERE SANPHAM.ID_MASP=CHITIETDONHANG.ID_MASP AND LICHSUBANHANG.ID_LICHSUBANHANG = CHITIETDONHANG.ID_LICHSUBANHANG 
		AND YEAR(LICHSUBANHANG.NGAYBAN) = @Nam AND SANPHAM.ID_MALOAI=@MaLoai
	GROUP BY SANPHAM.ID_MASP, SANPHAM.TENSP

CREATE PROCEDURE GetSanPhamDaBanTheoThang
@Nam INT, @Thang INT, @MaLoai INT
AS
	SELECT SANPHAM.ID_MASP, SANPHAM.TENSP, COUNT(SANPHAM.ID_MASP) AS SOLUONG FROM SANPHAM, LICHSUBANHANG, CHITIETDONHANG
	WHERE SANPHAM.ID_MASP=CHITIETDONHANG.ID_MASP AND LICHSUBANHANG.ID_LICHSUBANHANG = CHITIETDONHANG.ID_LICHSUBANHANG 
		AND SANPHAM.ID_MALOAI=@MaLoai AND YEAR(LICHSUBANHANG.NGAYBAN) = @Nam AND MONTH(LICHSUBANHANG.NGAYBAN) = @Thang
	GROUP BY SANPHAM.ID_MASP, SANPHAM.TENSP


CREATE PROCEDURE GetSanPhamDaBanTheoTuan
@Nam INT, @Tuan INT, @MaLoai INT
AS
	SELECT SANPHAM.ID_MASP, SANPHAM.TENSP, COUNT(SANPHAM.ID_MASP) AS SOLUONG FROM SANPHAM, LICHSUBANHANG, CHITIETDONHANG
	WHERE SANPHAM.ID_MASP=CHITIETDONHANG.ID_MASP AND LICHSUBANHANG.ID_LICHSUBANHANG = CHITIETDONHANG.ID_LICHSUBANHANG 
		AND SANPHAM.ID_MALOAI=@MaLoai AND YEAR(LICHSUBANHANG.NGAYBAN) = @Nam AND DATEPART(wk,LICHSUBANHANG.NGAYBAN) = @Tuan
	GROUP BY SANPHAM.ID_MASP, SANPHAM.TENSP
	

CREATE PROCEDURE GetSanPhamDaBanTheoNgay
@Nam INT, @Thang INT, @Ngay INT, @MaLoai INT
AS
	SELECT SANPHAM.ID_MASP, SANPHAM.TENSP, COUNT(SANPHAM.ID_MASP) AS SOLUONG FROM SANPHAM, LICHSUBANHANG, CHITIETDONHANG
	WHERE SANPHAM.ID_MASP=CHITIETDONHANG.ID_MASP AND LICHSUBANHANG.ID_LICHSUBANHANG = CHITIETDONHANG.ID_LICHSUBANHANG 
		AND SANPHAM.ID_MALOAI=@MaLoai AND YEAR(LICHSUBANHANG.NGAYBAN) = @Nam AND MONTH(LICHSUBANHANG.NGAYBAN) = @Thang 
		AND DAY(LICHSUBANHANG.NGAYBAN) = @Ngay
	GROUP BY SANPHAM.ID_MASP, SANPHAM.TENSP

CREATE PROCEDURE GetSanPhamDaBanTheoTuyChon
@MaLoai INT, @TuNgay DATE, @DenNgay DATE
AS
	SELECT SANPHAM.ID_MASP, SANPHAM.TENSP, COUNT(SANPHAM.ID_MASP) AS SOLUONG FROM SANPHAM, LICHSUBANHANG, CHITIETDONHANG
	WHERE SANPHAM.ID_MASP=CHITIETDONHANG.ID_MASP AND LICHSUBANHANG.ID_LICHSUBANHANG = CHITIETDONHANG.ID_LICHSUBANHANG 
		AND SANPHAM.ID_MALOAI=@MaLoai AND NGAYBAN >= @TuNgay AND NGAYBAN <= @DenNgay
	GROUP BY SANPHAM.ID_MASP, SANPHAM.TENSP

-- DANH SÁCH SẢN PHẨM NHẬP
CREATE PROCEDURE GetDanhSachSanPhamNhapTrongNam
@MaLoai INT, @Nam INT
AS
	SELECT LICHSUNHAPKHO.ID_LICHSU, LICHSUNHAPKHO.SOLUONG, LICHSUNHAPKHO.DONGIA FROM LICHSUNHAPKHO, SANPHAM 
		WHERE LICHSUNHAPKHO.ID_MASP = SANPHAM.ID_MASP AND SANPHAM.ID_MALOAI = @MaLoai AND YEAR(NGAYNHAP) = @Nam
	

CREATE PROCEDURE GetDanhSachSanPhamNhapTrongThang
@MaLoai INT, @Nam INT, @Thang INT
AS
	SELECT LICHSUNHAPKHO.ID_LICHSU, LICHSUNHAPKHO.SOLUONG, LICHSUNHAPKHO.DONGIA FROM LICHSUNHAPKHO, SANPHAM 
		WHERE LICHSUNHAPKHO.ID_MASP = SANPHAM.ID_MASP AND SANPHAM.ID_MALOAI = @MaLoai AND YEAR(NGAYNHAP) = @Nam AND MONTH(NGAYNHAP) = @Thang
	
	
CREATE PROCEDURE GetDanhSachSanPhamNhapTrongTuan
@MaLoai INT, @Nam INT, @Tuan INT
AS
	SELECT LICHSUNHAPKHO.ID_LICHSU, LICHSUNHAPKHO.SOLUONG, LICHSUNHAPKHO.DONGIA FROM LICHSUNHAPKHO, SANPHAM 
		WHERE LICHSUNHAPKHO.ID_MASP = SANPHAM.ID_MASP AND SANPHAM.ID_MALOAI = @MaLoai
			AND YEAR(NGAYNHAP) = @Nam AND DATEPART(wk, NGAYNHAP) = @Tuan
	
	
CREATE PROCEDURE GetDanhSachSanPhamNhapTrongNgay
@MaLoai INT, @Nam INT, @Thang INT, @Ngay INT
AS
	SELECT LICHSUNHAPKHO.ID_LICHSU, LICHSUNHAPKHO.SOLUONG, LICHSUNHAPKHO.DONGIA FROM LICHSUNHAPKHO, SANPHAM 
		WHERE LICHSUNHAPKHO.ID_MASP = SANPHAM.ID_MASP AND SANPHAM.ID_MALOAI = @MaLoai AND YEAR(NGAYNHAP) = @Nam AND MONTH(NGAYNHAP) = @Thang
			AND DAY(NGAYNHAP) = @Ngay
	
	
CREATE PROCEDURE GetDanhSachSanPhamNhapTuyChon
@MaLoai INT, @TuNgay DATE, @DenNgay DATE
AS
	SELECT LICHSUNHAPKHO.ID_LICHSU, LICHSUNHAPKHO.SOLUONG, LICHSUNHAPKHO.DONGIA FROM LICHSUNHAPKHO, SANPHAM 
		WHERE LICHSUNHAPKHO.ID_MASP = SANPHAM.ID_MASP AND SANPHAM.ID_MALOAI = @MaLoai AND NGAYNHAP BETWEEN @TuNgay AND @DenNgay
	

-- DANH SÁCH SẢN PHẨM ĐƯỢC BÁN
CREATE PROCEDURE GetDanhSachSanPhamXuatTrongNam
@MaLoai INT, @Nam INT
AS
	SELECT LICHSUBANHANG.ID_LICHSUBANHANG, LICHSUBANHANG.TONGTIEN FROM CHITIETDONHANG, SANPHAM, LICHSUBANHANG
		WHERE CHITIETDONHANG.ID_MASP = SANPHAM.ID_MASP AND SANPHAM.ID_MALOAI = @MaLoai AND LICHSUBANHANG.ID_LICHSUBANHANG = CHITIETDONHANG.ID_LICHSUBANHANG
		AND YEAR(NGAYBAN) = @Nam
	

CREATE PROCEDURE GetDanhSachSanPhamXuatTrongThang
@MaLoai INT, @Nam INT, @Thang INT
AS
	SELECT LICHSUBANHANG.ID_LICHSUBANHANG, LICHSUBANHANG.TONGTIEN FROM CHITIETDONHANG, SANPHAM, LICHSUBANHANG
		WHERE CHITIETDONHANG.ID_MASP = SANPHAM.ID_MASP AND SANPHAM.ID_MALOAI = @MaLoai AND LICHSUBANHANG.ID_LICHSUBANHANG = CHITIETDONHANG.ID_LICHSUBANHANG
		AND YEAR(NGAYBAN) = @Nam AND MONTH(NGAYBAN) = @Thang
	


CREATE PROCEDURE GetDanhSachSanPhamXuatTrongTuan
@MaLoai INT, @Nam INT, @Tuan INT
AS
		SELECT LICHSUBANHANG.ID_LICHSUBANHANG, LICHSUBANHANG.TONGTIEN FROM CHITIETDONHANG, SANPHAM, LICHSUBANHANG
		WHERE CHITIETDONHANG.ID_MASP = SANPHAM.ID_MASP AND SANPHAM.ID_MALOAI = @MaLoai AND LICHSUBANHANG.ID_LICHSUBANHANG = CHITIETDONHANG.ID_LICHSUBANHANG
		AND YEAR(NGAYBAN) = @Nam AND DATEPART(wk, NGAYBAN) = @Tuan

	

CREATE PROCEDURE GetDanhSachSanPhamXuatTrongNgay
@MaLoai INT, @Nam INT, @Thang INT, @Ngay INT
AS
		SELECT LICHSUBANHANG.ID_LICHSUBANHANG, LICHSUBANHANG.TONGTIEN FROM CHITIETDONHANG, SANPHAM, LICHSUBANHANG
		WHERE CHITIETDONHANG.ID_MASP = SANPHAM.ID_MASP AND SANPHAM.ID_MALOAI = @MaLoai AND LICHSUBANHANG.ID_LICHSUBANHANG = CHITIETDONHANG.ID_LICHSUBANHANG
		AND YEAR(NGAYBAN) = @Nam AND MONTH(NGAYBAN) = @Thang AND DAY(NGAYBAN) = @Ngay
	

CREATE PROCEDURE GetDanhSachSanPhamXuatTuyChon
@MaLoai INT, @TuNgay DATE, @DenNgay DATE
AS
	SELECT LICHSUBANHANG.ID_LICHSUBANHANG, LICHSUBANHANG.TONGTIEN FROM CHITIETDONHANG, SANPHAM, LICHSUBANHANG
		WHERE CHITIETDONHANG.ID_MASP = SANPHAM.ID_MASP AND SANPHAM.ID_MALOAI = @MaLoai AND LICHSUBANHANG.ID_LICHSUBANHANG = CHITIETDONHANG.ID_LICHSUBANHANG
		AND NGAYBAN BETWEEN @TuNgay AND @DenNgay
	



--		INSERT DATA

INSERT INTO LOAISANPHAM VALUES(N'Tất cả', 0)
INSERT INTO LOAISANPHAM VALUES(N'Điện thoại',0)
INSERT INTO LOAISANPHAM VALUES(N'Laptop',0)


INSERT INTO HANGSANXUAT VALUES(N'Apple',0)
INSERT INTO HANGSANXUAT VALUES(N'Dell',0)
INSERT INTO HANGSANXUAT VALUES(N'Asus',0)
INSERT INTO HANGSANXUAT VALUES(N'Acer',0)
INSERT INTO HANGSANXUAT VALUES(N'HP',0)
INSERT INTO HANGSANXUAT VALUES(N'LG',0)
INSERT INTO HANGSANXUAT VALUES(N'Sony',0)
INSERT INTO HANGSANXUAT VALUES(N'Lenovo',0)
INSERT INTO HANGSANXUAT VALUES(N'Huawei',0)
INSERT INTO HANGSANXUAT VALUES(N'Xiaomi',0)
INSERT INTO HANGSANXUAT VALUES(N'Oppo',0)


INSERT INTO KHUYENMAI VALUES(N'Black Friday', 10, 200000, '2019-01-11', '2019-01-14', 0)
INSERT INTO KHUYENMAI VALUES(N'Tết nguyên đán', 5, 100000, '2019-01-12', '2019-01-13', 0)

SELECT * FROM KHUYENMAI

-- /////////////////////////////////////////////////// TEST

exec GetLoaiSanPham
select * from LOAISANPHAM
select * from HANGSANXUAT
select * from SANPHAM

select * from CHITIETCAUHINH

select * from LICHSUNHAPKHO

select * from LICHSUBANHANG


select * from CHITIETDONHANG
select * from SANPHAM
select * from CHITIETKHUYENMAI

select * from SANPHAM

select * from CHITIETDONHANG



delete SANPHAM