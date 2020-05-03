-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER  PROCEDURE ThongTin_May 
AS
BEGIN
	SELECT * from May
END
GO

ALTER  PROCEDURE [dbo].[Insert_May] 
	@idMay varchar(10),
	@tenMay varchar(20),
	@trangThai bit,
	@giaTien float
AS
BEGIN
	Insert May(MaMay,TenMay,TrangThai,GiaTien)
	Values(@idMay,
			@tenMay,
			@trangThai,
			@giaTien
			)
END

GO

ALTER  PROCEDURE [dbo].[Delete_May] 
	@idMay varchar(10)
AS
BEGIN
	Delete from  May where MaMay=@idMay
END

GO

ALTER  PROCEDURE [dbo].[Update_May] 
	@idMay varchar(10),
	@tenMay varchar(20),
	@trangThai bit,
	@giaTien float
AS
BEGIN
	Update May set TenMay=@tenMay,TrangThai=@trangThai,GiaTien=@giaTien
	where MaMay=@idMay
END

GO






