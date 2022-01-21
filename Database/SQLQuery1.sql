use QLBANHANGPIZZA
go

--if OBJECT_ID('tr_CheckAgeEmp', 'TR') is not null
--	drop trigger tr_CheckAgeEmp
--go

--create trigger tr_CheckAgeEmp
--on [dbo].[EMPLOYEE] after insert
--as
--	declare @birthYear int
--	select @birthYear = year(i.[DateOfBirth]) from inserted i
--	if YEAR(getdate()) - @birthYear < 10
--	begin
--		raiserror(N'Không chấp nhận nhân viên chưa đủ 18 tuổi', 16, 10)
--		rollback transaction
--	end
--go

--TẠO PROC LẤY GIÁ TRỊ CUỐI CÙNG CỦA BẢNG BILL
IF OBJECT_ID('sp_getLastEmp', 'P') IS NOT NULL
	DROP PROC sp_getLastEmp
GO

CREATE PROC sp_getLastEmp
AS
	SELECT TOP 1 * FROM dbo.EMPLOYEE ORDER BY ID_Emp DESC
GO

--TẠO PROC LẤY số lượng nhân viên hiện tại CỦA BẢNG emp
IF OBJECT_ID('sp_getQuantityEmp1', 'P') IS NOT NULL
	DROP PROC sp_getQuantityEmp1
GO

CREATE PROC sp_getQuantityEmp1
AS
	SELECT count(ID_Emp) FROM EMPLOYEE WHERE ID_Emp != 'Admin' group by ID_Emp
GO
