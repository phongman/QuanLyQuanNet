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
Create  PROCEDURE ThongTin_May 
AS
BEGIN
	SELECT * from May
END
GO

Create  PROCEDURE [dbo].[Insert_May] 
	@idMay varchar(10),
	@tenMay varchar(20),
	@trangThai bit,
	@giaTien float
AS
BEGIN
	Insert May(MaMay,TenMay,TrangThai,Gia)
	Values(@idMay,
			@tenMay,
			@trangThai,
			@giaTien
			)
END

GO

Create  PROCEDURE [dbo].[Delete_May] 
	@idMay varchar(10)
AS
BEGIN
	Delete from  May where MaMay=@idMay
END

GO

Create  PROCEDURE [dbo].[Update_May] 
	@idMay varchar(10),
	@tenMay varchar(20),
	@trangThai bit,
	@giaTien float
AS
BEGIN
	Update May set TenMay=@tenMay,TrangThai=@trangThai,Gia=@giaTien
	where MaMay=@idMay
END

GO

select TaiKhoan,Tien,GioVao,dv.MaDV,dvtk.SoLuong,dv.TenDV,dvtk.SoLuong*dv.DonGia as PhiDV
from DichVu as dv,KhachHang  as kh,May as m ,TaiKhoanMay as tkm ,DichVuTaiKhoan as dvtk
where 
tkm.MaMay=m.MaMay AND tkm.MaKH=kh.MaKH AND tkm.TaiKhoanMay=dvtk.TaiKhoanMay AND dvtk.MaDV=dv.MaDV AND m.TrangThai=1
GO


Alter  PROCEDURE [dbo].[ThongTin_TaiKhoanMay_HoatDong] 
	@idMay varchar(10),
	@thoigian datetime
AS
BEGIN
	select kh.MaKH,kh.Tien, tkm.GioVao,DATEDIFF(minute,tkm.GioVao,@thoigian) as ThoiGianSuDung
	from KhachHang  as kh,May as m ,TaiKhoanMay as tkm 
	where tkm.MaMay=m.MaMay and tkm.MaKH=kh.MaKH  AND tkm.MaKH=kh.MaKH AND m.TrangThai=1  And tkm.MaMay=@idMay
END

GO

Alter PROCEDURE [dbo].[ThongTin_TaiKhoanDichVu_HoatDong] 
	@idMay varchar(10)
AS
BEGIN
	select  dv.TenDV,dv.DonGia,dvtk.SoLuong,dvtk.SoLuong*dv.DonGia as TongTien
	from TaiKhoanMay as tkm ,DichVuTaiKhoan as dvtk,DichVu as dv,May as m
	where tkm.TaiKhoanMay=dvtk.TaiKhoanMay AND tkm.MaMay=m.MaMay AND dvtk.MaDV=dv.MaDV AND m.TrangThai=1 AND tkm.MaMay=@idMay

END

GO





 

 

