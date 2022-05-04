CREATE TRIGGER UPDATE_MONEY ON PHIEU_THU
FOR INSERT 
AS 
DECLARE @TIEN FLOAT 
SELECT @TIEN = SOTIEN FROM INSERTED
UPDATE PHIEU_XUAT SET SoTienDaTra = PHIEU_XUAT.SoTienDaTra + @TIEN
FROM INSERTED WHERE PHIEU_XUAT.SOPX = INSERTED.SOPX 

INSERT PHIEU_THU VALUES('CT8', '2022-10-10', 18000, N'PHU E ACH', 'PX2')