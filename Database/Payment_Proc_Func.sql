USE QLBANHANGPIZZA
GO


--TẠO PROC LẤY GIÁ TRỊ CUỐI CÙNG CỦA BẢNG BILL
IF OBJECT_ID('sp_getLastBill', 'P') IS NOT NULL
	DROP PROC sp_getLastBill
GO

CREATE PROC sp_getLastBill
AS
	SELECT TOP 1 * FROM dbo.BILL ORDER BY ID_Bill DESC
GO
--
--

--
--KIỂM TRA BILL ID CÓ TỒN TẠI TRONG BẢNG BILL KHÔNG
IF OBJECT_ID('sp_CheckIDPro_BillDetail', 'P') IS NOT NULL
	DROP PROC sp_CheckIDPro_BillDetail
GO

CREATE PROC sp_CheckIDPro_BillDetail 
	@idBill CHAR(11), 
	@idPro CHAR(11)	
AS
BEGIN
	IF EXISTS(SELECT * FROM dbo.BILLDETAIL WHERE ID_Bill = @idBill AND ID_Pro = @idPro)
		SELECT 1
	ELSE
		SELECT 0
END
GO
--
--
--
--
--KIỂM TRA PRODUCT ID CÓ GIỐNG TRONG BẢNG PRODUCT KHÔNG
IF OBJECT_ID('sp_CheckIDPro_Product', 'P') IS NOT NULL
	DROP PROC sp_CheckIDPro_Product
GO

CREATE PROC sp_CheckIDPro_Product 
	@idPro CHAR(11)	
AS
BEGIN
	IF EXISTS(SELECT * FROM dbo.PRODUCTS WHERE ID_Pro = @idPro)
		SELECT 1
	ELSE
		SELECT 0
END
GO
--
--
--
--TẠO PROC CẬP NHẬT SỐ LƯỢNG SẢN PHẨM Ở BẢNG PRODUCT SAU KHI THÊM/SỬA/XÓA THÀNH CÔNG VÀO BẢNG BILL DETAIL
IF OBJECT_ID('sp_updateQuantityProduct', 'P') IS NOT NULL
	DROP PROC sp_updateQuantityProduct
GO

CREATE PROC sp_updateQuantityProduct
	@idPro CHAR(11),
	@quantity CHAR(11)
AS
	UPDATE dbo.PRODUCTS SET QUANTITY = @quantity WHERE ID_PRO = @idPro
GO
--
--
--
--TẠO PROC CẬP NHẬT SỐ TIỀN Ở BẢNG BILL SAU KHI THÊM/SỬA/XÓA THÀNH CÔNG VÀO BẢNG BILL DETAIL
IF OBJECT_ID('sp_updateTotalMoney', 'P') IS NOT NULL
	DROP PROC sp_updateTotalMoney
GO

CREATE PROC sp_updateTotalMoney
	@idBill CHAR(11),
	@totalMoney CHAR(11)
AS
	UPDATE dbo.BILL SET TotalMoney = @totalMoney WHERE ID_Bill = @idBill
GO