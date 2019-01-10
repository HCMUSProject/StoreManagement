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
	KHAC NVARCHAR(30) NULL,
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
@Pin NVARCHAR(30), @HeDieuHanh NVARCHAR(30), @Khac NVARCHAR(30)
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

			-- UPDATE SANPHAM SET SOLUONG = @TongSoLuong WHERE ID_MASP=@MaSP

			UPDATE SANPHAM SET DONGIA = @DonGia WHERE ID_MASP=@MaSP

			INSERT INTO LICHSUNHAPKHO VALUES(@MaSP,@SoLuong,@DonGia,@NgayNhap)
		END

	

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




-- /////////////////////////////////////////////////// TEST

exec GetLoaiSanPham

select * from SANPHAM
select * from LOAISANPHAM
select * from HANGSANXUAT
select * from CHITIETCAUHINH

select * from LICHSUNHAPKHO

delete SANPHAM

select * from CHITIETCAUHINH


DROP DATABASE QuanLyCuaHang

