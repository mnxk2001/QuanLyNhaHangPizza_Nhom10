CREATE DATABASE QLBANHANGPIZZA
GO
USE QLBANHANGPIZZA
GO

--DROP QLBANHANGPIZZA

--TABLE CUSTOMER
CREATE TABLE CUSTOMER
( 
   ID_CUS		CHAR(11) NOT NULL,
   NAME_CUS		NVARCHAR(50) NOT NULL,
   SEX			NVARCHAR(3) NOT NULL,
   DATEOFBIRTH	DATE NOT NULL,
   PHONE		CHAR(11) NOT NULL,
   ADDRESS_CUS	NVARCHAR(100) NOT NULL,
   CONSTRAINT PK_CUS PRIMARY KEY (ID_CUS)
)
GO

--TABLE EMPLOYEE
CREATE TABLE EMPLOYEE
(
   ID_Emp		CHAR(11) NOT NULL,
   Name_Emp		NVARCHAR(50) NOT NULL,
   Sex			NVARCHAR(3) NOT NULL,
   DateOfBirth	DATE NOT NULL,
   Phone		CHAR(11) NOT NULL,
   Address_Emp	NVARCHAR(100) NOT NULL,
   Position		NVARCHAR(50) NOT NULL,   
   STATUS_EMP	NVARCHAR(100) NULL,
   CONSTRAINT PK_Emp PRIMARY KEY (ID_Emp)
)
GO

--TABLE EMPLOYEE_WORK
CREATE TABLE EMPLOYEE_WORK
(
	ID_Emp		CHAR(11) NOT NULL,
	Work_Date	DATE NOT NULL,
	Work_Shift	NVARCHAR(10) NOT NULL
	CONSTRAINT PK_EMPWORK PRIMARY KEY CLUSTERED (ID_Emp)
	WITH (IGNORE_DUP_KEY = ON) ON [PRIMARY]
)
GO

--TABLE CATEGORIES 
CREATE TABLE CATEGORIES
(
    ID_CATE		CHAR(11) NOT NULL,
	NAME_CATE	NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_IDCATE PRIMARY KEY(ID_CATE)
)
GO

--TABLE Products 
CREATE TABLE PRODUCTS
(
   ID_PRO			CHAR(11) NOT NULL,
   NAMEPRO			NVARCHAR(50) NOT NULL,
   ID_CATE			CHAR(11) NOT NULL,
   QUANTITY			CHAR(11) NOT NULL,
   UNIT				NVARCHAR(5) NOT NULL,
   PICTURE			VARCHAR(50) NOT NULL,
   UNITPRICEPRO		CHAR(11) NOT NULL,
   STATUS_PRO		NVARCHAR(100) NULL,
   CONSTRAINT PK_SP PRIMARY KEY (ID_PRO)
)
GO

CREATE TABLE BILL
(
	ID_Bill			CHAR(11) NOT NULL,
	ID_Cus			CHAR(11) NOT NULL,
	ID_Emp			CHAR(11) NOT NULL,
	DateFounded		DATE NOT NULL,
    TotalMoney		CHAR(11) NULL,
	BillNotes		NTEXT NULL,
	CONSTRAINT PK_Bill PRIMARY KEY(ID_Bill),
	
)
GO

--TABLE BILLDETAIL
CREATE TABLE BILLDETAIL
(
  ID_Bill		CHAR(11) NOT NULL,
  ID_Pro		CHAR(11) NOT NULL,
  Quantity		CHAR(11) NOT NULL,
  UnitPrice		CHAR(11) NOT NULL,
  IntoMoney		CHAR(11) NOT NULL,
  CONSTRAINT PK_BillDet PRIMARY KEY ( ID_Bill, ID_Pro)
)
GO

--TABLE ACCOUNT
CREATE TABLE ACCOUNT
(
   ID_Emp	CHAR (11) NOT NULL,
   ID_User	CHAR (11) NOT NULL,
   PASS		VARCHAR(20) NOT NULL,
   CONSTRAINT PK_Account PRIMARY KEY(ID_User)
)
GO

--DỮ LIỆU TABLE CUSTOMER
INSERT INTO DBO.CUSTOMER
VALUES
(    'A111',        -- ID_Cus - char(10)
    N'Trần Mai Lan',       -- Name_Cus - nvarchar(100)
    N'Nữ',       -- Sex - nvarchar(3)
     '19990521', -- DateOfBirth - date
     '0235645892',        -- Phone - char(10)
    N'Quận Gò Vấp, TP. Hồ Chí Minh'        -- Address_Cus - nvarchar(100)
),
(    'A112',        -- ID_Cus - char(10)
    N'Nguyễn Đức',       -- Name_Cus - nvarchar(100)
    N'Nam',       -- Sex - nvarchar(3)
	 '19970125', -- DateOfBirth - date
    '0235698458',        -- Phone - char(10)
    N'Biên Hòa, Tỉnh Đồng Nai'        -- Address_Cus - nvarchar(100)
),
(    'A113',        -- ID_Cus - char(10)
    N'Nguyễn Trần Lan Anh',       -- Name_Cus - nvarchar(100)
    N'Nữ',       -- Sex - nvarchar(3)
     '20010225', -- DateOfBirth - date
     '0456982651',        -- Phone - char(10)
    N'Quận Gò Vấp, TP. Hồ Chí Minh'        -- Address_Cus - nvarchar(100)
),
(    'A114',        -- ID_Cus - char(10)
    N'Ngô Thành Trung',       -- Name_Cus - nvarchar(100)
    N'Nam',       -- Sex - nvarchar(3)
     '20020527', -- DateOfBirth - date
     '0523695147',        -- Phone - char(10)
    N'Quận 1, TP. Hồ Chí Minh'        -- Address_Cus - nvarchar(100)
),
(    'A115',        -- ID_Cus - char(10)
    N'Hoàng An Nhiên',       -- Name_Cus - nvarchar(100)
    N'Nữ',       -- Sex - nvarchar(3)
     '20030422', -- DateOfBirth - date
     '0725364594',        -- Phone - char(10)
    N'Quận 9, TP. Thủ Đức'        -- Address_Cus - nvarchar(100)
),
(    'A116',        -- ID_Cus - char(10)
    N'Nguyễn Đức Tài',       -- Name_Cus - nvarchar(100)
    N'Nữ',       -- Sex - nvarchar(3)
     '19980521', -- DateOfBirth - date
     '0594562135',        -- Phone - char(10)
    N'Biên Hòa, Tỉnh Đồng Nai'        -- Address_Cus - nvarchar(100)
),
(    'A117',        -- ID_Cus - char(10)
    N'Trần Phi Hùng',       -- Name_Cus - nvarchar(100)
     'Nam',       -- Sex - nvarchar(3)
     '19900721', -- DateOfBirth - date
     '0321562135',        -- Phone - char(10)
    N'Quận Phú Thạnh, TP. Bình Dương'        -- Address_Cus - nvarchar(100)
),
(    'A118',        -- ID_Cus - char(10)
    N'Mai Phi Long',       -- Name_Cus - nvarchar(100)
     'Nam',       -- Sex - nvarchar(3)
     '19970123', -- DateOfBirth - date
     '0315624578',        -- Phone - char(10)
    N'Quận Phú Thứ, TP. Bình Dương'        -- Address_Cus - nvarchar(100)
),
(   
     'A119',        -- ID_Cus - char(10)
    N'Ngô Đồng Thiên',       -- Name_Cus - nvarchar(100)
     'Nam',       -- Sex - nvarchar(3)
     '19970120', -- DateOfBirth - date
     '0213654872',        -- Phone - char(10)
    N'Quận Tân Phú, TP. Hồ Chí Minh'        -- Address_Cus - nvarchar(100)
), 
(   
     'A120',        -- ID_Cus - char(10)
    N'Nguyễn Thị Mai',       -- Name_Cus - nvarchar(100)
     N'Nữ',       -- Sex - nvarchar(3)
     '20010829', -- DateOfBirth - date
     '0125642135',        -- Phone - char(10)
    N'Quận Tân Bình, TP. Hồ Chí Minh'        -- Address_Cus - nvarchar(100)
)
GO

--DỮ LIỆU TABLE Employee
INSERT INTO DBO.EMPLOYEE
VALUES
(   'Admin',       -- ID_Emp - char(11)
    'Admin',      -- Name_Emp - nvarchar(50)
    N'Nam',      -- Sex - nvarchar(3)
    '20200301',       -- DateOfBirth - date
    '0234568451',       -- Phone - char(11)
    'Admin',      -- Address_Cus - nvarchar(100)
    'Admin',      -- Position - nvarchar(50)
	NULL
),
(   'NV01',       -- ID_Emp - char(11)
    N'Trần Thị Ngọc Bích',      -- Name_Emp - nvarchar(50)
    N'Nữ',      -- Sex - nvarchar(3)
    '20010303',       -- DateOfBirth - date
    '0702374606',       -- Phone - char(11)
    N'Quận Gò Vấp, TP. Hồ Chí Minh',      -- Address_Cus - nvarchar(100)
    N'Nhân viên',      -- Position - nvarchar(50)
	NULL
),
(   'NV02',       -- ID_Emp - char(11)
    N'Mai Nguyễn Xuân Kiều',      -- Name_Emp - nvarchar(50)
    N'Nữ',      -- Sex - nvarchar(3)
    '20010829',       -- DateOfBirth - date
    '0315264856',       -- Phone - char(11)
    N'Quận Tân Phú, TP. Hồ Chí Minh',      -- Address_Cus - nvarchar(100)
    N'Nhân viên',      -- Position - nvarchar(50)
	NULL
),
(   'NV03',       -- ID_Emp - char(11)
    N'Đinh Thục Thanh',      -- Name_Emp - nvarchar(50)
    N'Nữ',      -- Sex - nvarchar(3)
    '20011029',       -- DateOfBirth - date
    '0458965214',       -- Phone - char(11)
    N'Quận Bình Thạnh, TP. Hồ Chí Minh',      -- Address_Cus - nvarchar(100)
    N'Nhân viên',      -- Position - nvarchar(50)
	NULL
),
(   'NV04',       -- ID_Emp - char(11)
    N'Phan Đình Long',      -- Name_Emp - nvarchar(50)
    'Nam',      -- Sex - nvarchar(3)
    '19990310',       -- DateOfBirth - date
    '0158965412',       -- Phone - char(11)
    N'Quận Bình Chánh, TP. Hồ Chí Minh',      -- Address_Cus - nvarchar(100)
    N'Nhân viên',      -- Position - nvarchar(50)
	NULL
)
GO

--TABLE EMPLOYEE_WORK
INSERT INTO dbo.EMPLOYEE_WORK
VALUES
(   'NV04',        -- ID_Emp - char(11)
    '20211212', -- Work_Date - date
    N'Ca sáng'        -- Work_Shift - nvarchar(10)
    ),
(   'NV04',        -- ID_Emp - char(11)
    '20211213', -- Work_Date - date
    N'Ca sáng'        -- Work_Shift - nvarchar(10)
    )
GO

--TABLE CATEGORIES
INSERT INTO DBO.CATEGORIES
(
    ID_CATE,
    NAME_CATE
)
VALUES
(   'PZ', -- ID_Cate - char(11)
    'Pizza' -- Name_Cate - nvarchar(50)
),
(   'Drink', -- ID_Cate - char(11)
    N'Thức uống' -- Name_Cate - nvarchar(50)
)
GO

--DỮ LIỆU TABLE Products 
INSERT INTO DBO.PRODUCTS
VALUES
(   '110', -- MaSP - char(10)
    N'Pizza Gà nướng 3 vị', -- TenSP - nvarchar(50)
    'PZ', -- MaLoai - char(10)
    '20', -- SoLuong - char(11)
    N'Cái', -- DonViTinh - nvarchar(5)
    'pizzaGa.png', -- HinhAnh - varchar(20)
    '159.000',  -- DonGia - char(11)
	NULL
), 
(   '111', -- MaSP - char(10)
    N'Pizza Thịt Nguội', -- TenSP - nvarchar(50)
    'PZ', -- MaLoai - char(10)
    '35', -- SoLuong - char(11)
    N'Cái', -- DonViTinh - nvarchar(5)
    'pizzaThitNguoi.png', -- HinhAnh - varchar(20)
    '139.000',  -- DonGia - char(11)
	NULL
),
(   '112', -- MaSP - char(10)
    N'Pizza Cá Ngừ Thanh Cua', -- TenSP - nvarchar(50)
    'PZ', -- MaLoai - char(10)
    '45', -- SoLuong - char(11)
    N'Cái', -- DonViTinh - nvarchar(5)
    'pizzaCaNgu.png', -- HinhAnh - varchar(20)
    '199.000',  -- DonGia - char(11)
	NULL
),
(   '113', -- MaSP - char(10)
    N'Pizza Hải Sản', -- TenSP - nvarchar(50)
    'PZ', -- MaLoai - char(10)
    '32', -- SoLuong - char(11)
    N'Cái', -- DonViTinh - nvarchar(5)
    'pizzaHaiSan.png', -- HinhAnh - varchar(20)
    '139.000',  -- DonGia - char(11)
	NULL
),
(   '114', -- MaSP - char(10)
    N'Pizza Bắp Phô Mai', -- TenSP - nvarchar(50)
    'PZ', -- MaLoai - char(10)
    '29', -- SoLuong - char(11)
    N'Cái', -- DonViTinh - nvarchar(5)
    'pizzaBap.png', -- HinhAnh - varchar(20)
    '149.000',  -- DonGia - char(11)
	NULL
),
(   '115', -- MaSP - char(10)
    N'Pizza Phô Mai', -- TenSP - nvarchar(50)
    'PZ', -- MaLoai - char(10)
    '41', -- SoLuong - char(11)
    N'Cái', -- DonViTinh - nvarchar(5)
    'pizzaPhoMai.png', -- HinhAnh - varchar(20)
    '119.000',  -- DonGia - char(11)
	NULL
),
(   '116', -- MaSP - char(10)
    N'Pizza Hải Sản Rau Củ', -- TenSP - nvarchar(50)
    'PZ', -- MaLoai - char(10)
    '27', -- SoLuong - char(11)
    N'Cái', -- DonViTinh - nvarchar(5)
    'pizzaRauCu.png', -- HinhAnh - varchar(20)
    '149.000',  -- DonGia - char(11)
	NULL
),
(   '117', -- MaSP - char(10)
    N'Pizza Mì Tôm', -- TenSP - nvarchar(50)
    'PZ', -- MaLoai - char(10)
    '31', -- SoLuong - char(11)
    N'Cái', -- DonViTinh - nvarchar(5)
    'pizzaMiTom.png', -- HinhAnh - varchar(20)
    '99.000',  -- DonGia - char(11)
	NULL
),
(   '118', -- MaSP - char(10)
    N'Nước Suối', -- TenSP - nvarchar(50)
    'Drink', -- MaLoai - char(10)
    '32', -- SoLuong - char(11)
    'Chai', -- DonViTinh - nvarchar(5)
    'NuocSuoi.png', -- HinhAnh - varchar(20)
    '15.000',  -- DonGia - char(11)
	NULL
),
(   '119', -- MaSP - char(10)
    N'Cheese Hạt chia ', -- TenSP - nvarchar(50)
    'Drink', -- MaLoai - char(10)
    '21', -- SoLuong - char(11)
    'Ly', -- DonViTinh - nvarchar(5)
    'HatChia_Cheese.png', -- HinhAnh - varchar(20)
    '70.000',  -- DonGia - char(11)
	NULL
), 
('120', -- MaSP - char(10)
    N'Trà Đào', -- TenSP - nvarchar(50)
    'Drink', -- MaLoai - char(10)
    '25', -- SoLuong - char(11)
    'Ly', -- DonViTinh - nvarchar(5)
    'TraDao.png', -- HinhAnh - varchar(20)
    '65.000',  -- DonGia - char(11)
	NULL
),
(   '122', -- MaSP - char(10)
    'Cocktail Whiskey Sour', -- TenSP - nvarchar(50)
    'Drink', -- MaLoai - char(10)
    '35', -- SoLuong - char(11)
    'Ly', -- DonViTinh - nvarchar(5)
    'CocktailWhiskeySour.png', -- HinhAnh - varchar(20)
    '89.000',  -- DonGia - char(11)
	NULL
),
(   '123', -- MaSP - char(10)
    'Cocktail Negroni', -- TenSP - nvarchar(50)
    'Drink', -- MaLoai - char(10)
    '20', -- SoLuong - char(11)
    'Ly', -- DonViTinh - nvarchar(5)
    'cocktailNegroni.png', -- HinhAnh - varchar(20)
    '89.000',  -- DonGia - char(11)
	NULL
),
(   '124', -- MaSP - char(10)
    'Cocktail Mojito', -- TenSP - nvarchar(50)
    'Drink', -- MaLoai - char(10)
    '18', -- SoLuong - char(11)
    'Ly', -- DonViTinh - nvarchar(5)
    'CocktailMojito.png', -- HinhAnh - varchar(20)
    '89.000',  -- DonGia - char(11)
	NULL
)
GO

--DỮ LIỆU TABLE Bill
INSERT INTO dbo.Bill
VALUES
(   '1111',        -- ID_Bill - char(10)
    'A111',        -- ID_Cus - char(10)
    'NV01',        -- ID_Emp - char(10)
    '20211121', -- DateFounded - date
    '448.000',        -- TotalMoney - int(20)
    N'Đã thanh toán'        -- BillNotes - ntext
),
(   '1112',        -- MAHD - char(10)
    'A112',        -- MAKH - char(10)
    'NV01',        -- MANV - char(10)
    '20211122', -- NGAYLAP - date
    '1.628.000',        -- TONGTIEN - int(20)
    N'Đã thanh toán'        -- GHICHU - ntext
),
(   '1113',        -- MAHD - char(10)
    'A113',        -- MAKH - char(10)
    'NV01',        -- MANV - char(10)
    '20211123', -- NGAYLAP - date
    '1.823.000',        -- TONGTIEN - int(20)
    N'Đã thanh toán'        -- GHICHU - ntext
),
(   '1114',        -- MAHD - char(10)
    'A114',        -- MAKH - char(10)
    'NV01',        -- MANV - char(10)
    '20211124', -- NGAYLAP - date
    '591.000',        -- TONGTIEN - int(20)
    N'Đã thanh toán'        -- GHICHU - ntext
),
(   '1115',        -- MAHD - char(10)
    'A115',        -- MAKH - char(10)
    'NV01',        -- MANV - char(10)
    '20211125', -- NGAYLAP - date
    '2.185.000',        -- TONGTIEN - int(20)
    N'Đã thanh toán'        -- GHICHU - ntext
),
(   '1116',        -- MAHD - char(10)
    'A116',        -- MAKH - char(10)
    'NV02',        -- MANV - char(10)
    '20211202', -- NGAYLAP - date
    '736.000',        -- TONGTIEN - int(20)
    N'Đã thanh toán'        -- GHICHU - ntext
),
(   '1117',        -- MAHD - char(10)
    'A117',        -- MAKH - char(10)
    'NV03',        -- MANV - char(10)
    '20211203', -- NGAYLAP - date
    '260.000',        -- TONGTIEN - int(20)
    N'Đã thanh toán'        -- GHICHU - ntext
),
(   '1118',        -- MAHD - char(10)
    'A118',        -- MAKH - char(10)
    'NV04',        -- MANV - char(10)
    '20211204', -- NGAYLAP - date
    '178.000',        -- TONGTIEN - int(20)
    N'Đã thanh toán'        -- GHICHU - ntext
),
(   '1119',        -- MAHD - char(10)
    'A119',        -- MAKH - char(10)
    'NV01',        -- MANV - char(10)
    '20211205', -- NGAYLAP - date
    '1.230.000',        -- TONGTIEN - int(20)
    N'Đã thanh toán'        -- GHICHU - ntext
),
(   '1120',        -- MAHD - char(10)
    'A120',        -- MAKH - char(10)
    'NV02',        -- MANV - char(10)
    '20211206', -- NGAYLAP - date
    '606.000',        -- TONGTIEN - int(20)
    N'Đã thanh toán'        -- GHICHU - ntext
),
(   '1121',        -- MAHD - char(10)
    'A112',        -- MAKH - char(10)
    'NV03',        -- MANV - char(10)
    '20210207', -- NGAYLAP - date
    '260.000',        -- TONGTIEN - int(20)
    N'Đã thanh toán'        -- GHICHU - ntext
),
(   '1122',        -- MAHD - char(10)
    'A113',        -- MAKH - char(10)
    'NV04',        -- MANV - char(10)
    '20210207', -- NGAYLAP - date
    '260.000',        -- TONGTIEN - int(20)
    N'Đã thanh toán'        -- GHICHU - ntext
),
(   '1123',        -- MAHD - char(10)
    'A114',        -- MAKH - char(10)
    'NV03',        -- MANV - char(10)
    '20210207', -- NGAYLAP - date
    '951.000',        -- TONGTIEN - int(20)
    N'Đã thanh toán'        -- GHICHU - ntext
),
(   '1124',        -- MAHD - char(10)
    'A115',        -- MAKH - char(10)
    'NV04',        -- MANV - char(10)
    '20210208', -- NGAYLAP - date
    '2.885.000',        -- TONGTIEN - int(20)
    N'Đã thanh toán'        -- GHICHU - ntext
)
GO

-- DỮ LIỆU TABLE BILLDETAIL
INSERT INTO DBO.BILLDETAIL
(
    ID_Bill,
    ID_Pro,
    Quantity,
    UnitPrice,
    IntoMoney
)
VALUES
(   
    '1111', -- ID_Bill - char(11)
    '110', -- ID_Pro - char(11)
    '2', -- Quantity - char(11)
    '159.000', -- UnitPrice - char(11)
    '318.000'  -- IntoMoney - char(11)
),
(   
    '1111', -- ID_Bill - char(11)
    '120', -- ID_Pro - char(11)
    '2', -- Quantity - char(11)
    '65.000', -- UnitPrice - char(11)
    '130.000'  -- IntoMoney - char(11)
),
(   
    '1112', -- ID_Bill - char(11))
    '115', -- ID_Pro- char(11)
    '4', -- Quantity - char(11)
    '119.000', -- UnitPrice - char(11)
    '476.000'  -- IntoMoney - char(11)
),
(   
    '1112', -- ID_Bill - char(11)
    '112', -- ID_Pro - char(11)
    '4', -- Quantity - char(11)
    '199.000', -- UnitPrice - char(11)
    '796.000'  -- IntoMoney - char(11)
),
(   
    '1112', -- ID_Bill - char(11)
    '123', -- ID_Pro - char(11)
    '4', -- Quantity - char(11)
    '89.000', -- UnitPrice - char(11)
    '356.000'  -- IntoMoney - char(11)
),
(  
    '1113', -- ID_Bill - char(11)
    '111', -- MaSP - char(11)
    '7', -- SoLuong - char(11)
    '139.000', -- DonGia - char(11)
    '973.000'  -- ThanhTien - char(11)
),
(   
    '1113', -- ID_Bill - char(11)
    '116', -- MaSP - char(11)
    '5', -- SoLuong - char(11)
    '149.000', -- DonGia - char(11)
    '745.000'  -- ThanhTien - char(11)
),
(  
    '1113', -- ID_Bill - char(11)
    '118', -- MaSP - char(11)
    '7', -- SoLuong - char(11)
    '15.000', -- DonGia - char(11)
    '105.000'  -- ThanhTien - char(11)
),
(   
    '1114', -- ID_Bill - char(11)
    '114', -- MaSP - char(11)
    '3', -- SoLuong - char(11)
    '149.000', -- DonGia - char(11)
    '447.000'  -- ThanhTien - char(11)
),
(   
    '1114', -- ID_Bill - char(11)
    '117', -- MaSP - char(11)
    '1', -- SoLuong - char(11)
    '99.000', -- DonGia - char(11)
    '99.000'  -- ThanhTien - char(11)
),
(   
    '1114', -- ID_Bill - char(11)
    '118', -- MaSP - char(11)
    '3', -- SoLuong - char(11)
    '15.000', -- DonGia - char(11)
    '45.000'  -- ThanhTien - char(11)
),
(   
    '1115', -- ID_Bill - char(11)
    '113', -- MaSP - char(11)
    '5', -- SoLuong - char(11)
    '139.000', -- DonGia - char(11)
    '695.000'  -- ThanhTien - char(11)
),
(   
    '1115', -- ID_Bill - char(11)
    '114', -- MaSP - char(11)
    '10', -- SoLuong - char(11)
    '149.000', -- DonGia - char(11)
    '1.490.000'  -- ThanhTien - char(11)
),
(   
    '1116', -- ID_Bill - char(11)
    '115', -- MaSP - char(11)
    '4', -- SoLuong - char(11)
    '119.000', -- DonGia - char(11)
    '476.000'  -- ThanhTien - char(11)
),
(   
    '1116', -- ID_Bill - char(11)
    '120', -- MaSP - char(11)
    '4', -- SoLuong - char(11)
    '65.000', -- DonGia - char(11)
    '260.000'  -- ThanhTien - char(11)
),
(   
    '1117', -- ID_Bill - char(11)
    '120', -- MaSP - char(11)
    '4', -- SoLuong - char(11)
    '65.000', -- DonGia - char(11)
    '260.000'  -- ThanhTien - char(11)
),
(   
    '1118', -- ID_Bill - char(11)
    '123', -- MaSP - char(11)
    '2', -- SoLuong - char(11)
    '89.000', -- DonGia - char(11)
    '178.000'  -- ThanhTien - char(11)
),
(   
    '1119', -- ID_Bill - char(11)
    '117', -- MaSP - char(11)
    '4', -- SoLuong - char(11)
    '99.000', -- DonGia - char(11)
    '396.000'  -- ThanhTien - char(11)
),
(   
    '1119', -- MaHD - char(11)
    '111', -- MaSP - char(11)
    '6', -- SoLuong - char(11)
    '139.000', -- DonGia - char(11)
    '834.000'  -- ThanhTien - char(11)
),
(   
    '1120', -- ID_Bill - char(11)
    '115', -- MaSP - char(11)
    '4', -- SoLuong - char(11)
    '119.000', -- DonGia - char(11)
    '476.000'  -- ThanhTien - char(11)
),
(   
    '1120', -- ID_Bill - char(11)
    '120', -- MaSP - char(11)
    '2', -- SoLuong - char(11)
    '65.000', -- DonGia - char(11)
    '130.000'  -- ThanhTien - char(11)
),
(   
    '1121', -- ID_Bill - char(11)
    '120', -- MaSP - char(11)
    '4', -- SoLuong - char(11)
    '65.000', -- DonGia - char(11)
    '260.000'  -- ThanhTien - char(11)
),
(   
    '1122', -- ID_Bill - char(11)
    '120', -- MaSP - char(11)
    '4', -- SoLuong - char(11)
    '65.000', -- DonGia - char(11)
    '260.000'  -- ThanhTien - char(11)
),
(   
    '1123', -- ID_Bill - char(11)
    '123', -- MaSP - char(11)
    '4', -- SoLuong - char(11)
    '89.000', -- DonGia - char(11)
    '356.000'  -- ThanhTien - char(11)
),
(   
    '1123', -- ID_Bill - char(11)
    '115', -- MaSP - char(11)
    '5', -- SoLuong - char(11)
    '119.000', -- DonGia - char(11)
    '595.000'  -- ThanhTien - char(11)
),
(   
    '1124', -- ID_Bill - char(11)
    '116', -- MaSP - char(11)
    '15', -- SoLuong - char(11)
    '149.000', -- DonGia - char(11)
    '2.235.000'  -- ThanhTien - char(11)
),
(  
    '1124', -- ID_Bill - char(11)
    '120', -- MaSP - char(11)
    '10', -- SoLuong - char(11)
    '65.000', -- DonGia - char(11)
    '650.000'  -- ThanhTien - char(11)
)
GO

--DỮ LIỆU TABLE ACCOUNT
INSERT INTO DBO.ACCOUNT
VALUES
(   
    'Admin', -- ID_EMP - CHAR(11)
	'ADMIN', -- ID_USER - CHAR(11)
    'ADMIN'  -- PASSWORD - VARCHAR(20)
),
(   
    'NV01', -- ID_EMP - CHAR(11)
	'BICHNV01', -- ID_USER - CHAR(11)
    'BICHNV01'  -- PASSWORD - VARCHAR(20)
),
(   
    'NV02', -- ID_EMP - CHAR(11)
	'KIEUNV02', -- ID_USER - CHAR(11)
    'KIEUNV02'  -- PASSWORD - VARCHAR(20)
	
),
(   
    'NV03', -- ID_EMP - CHAR(11)
	'THANHNVO3', -- ID_USER - CHAR(11)
    'THANHNV03'  -- PASSWORD - VARCHAR(20)
),
(   
    'NV04', -- ID_EMP - CHAR(11)
	'LONGNVO4', -- ID_USER - CHAR(11)
    'LONGNV04'  -- PASSWORD - VARCHAR(20)
)
GO


-------CÁC RÀNG BUỘC--------
--Account
ALTER TABLE dbo.Account 
	ADD CONSTRAINT FK_Account_Employee
	FOREIGN KEY (ID_Emp) 
	REFERENCES dbo.Employee (ID_Emp)
GO
--Products
ALTER TABLE dbo.Products 
	ADD CONSTRAINT FK_Products_Categories
	FOREIGN KEY (ID_Cate) 
	REFERENCES dbo.Categories(ID_Cate)
GO

--Bill
ALTER TABLE dbo.Bill 
	ADD CONSTRAINT FK_Bill_Cus 
	FOREIGN KEY (ID_Cus) 
	REFERENCES dbo.Customer (ID_Cus)
GO

ALTER TABLE dbo.Bill 
	ADD CONSTRAINT FK_Bill_Emp 
	FOREIGN KEY (ID_Emp) 
	REFERENCES dbo.EMPLOYEE (ID_Emp)
GO

--BillDetail
ALTER TABLE dbo.BillDetail 
	ADD CONSTRAINT FK_BillDetail 
	FOREIGN KEY (ID_Pro) 
	REFERENCES dbo.Products (ID_Pro)
GO

ALTER TABLE dbo.BILLDETAIL
	ADD CONSTRAINT FK_BILLDETAIL_BILL
	FOREIGN KEY (ID_Bill)
	REFERENCES dbo.BILL(ID_Bill)
GO

--Employee_Work
ALTER TABLE dbo.EMPLOYEE_WORK
	ADD CONSTRAINT FK_EMPWORK_EMP
	FOREIGN KEY (ID_Emp)
	REFERENCES dbo.EMPLOYEE (ID_Emp)
GO

------------------------------
--------------------------------