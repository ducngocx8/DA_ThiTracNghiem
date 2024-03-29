drop Procedure [dbo].[SP_KiemTraGiangVienDangKy]
go

SET QUOTED_IDENTIFIER ON
go
SET ANSI_NULLS ON
go
CREATE PROCEDURE [dbo].[SP_KiemTraGiangVienDangKy]  
@MALOP VARCHAR(8), @MAMH VARCHAR(8), @LAN SmallInt
AS 
BEGIN  
DECLARE @Result VARCHAR(1)
SET @RESULT = 'N'

IF EXISTS (SELECT MALOP, MAMH, LAN FROM LINK1.TN.dbo.GIAOVIEN_DANGKY WHERE @MALOP = MALOP AND @MAMH = MAMH AND @LAN = LAN)
BEGIN
	SET @RESULT = 'Y'
END
ELSE IF EXISTS (SELECT MALOP, MAMH, LAN FROM LINK2.TN.dbo.GIAOVIEN_DANGKY WHERE @MALOP = MALOP AND @MAMH = MAMH AND @LAN = LAN)
BEGIN
	SET @RESULT = 'Y'
END
SELECT RESULT = @RESULT 
END 
go
