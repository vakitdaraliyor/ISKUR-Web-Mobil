-- TAKSITLENDIR PROCEDURE -- START --
ALTER PROC usp_TAKSITLENDIR(@KATILIMCI_REFNO INT, @TUTAR INT, @ADET INT)
AS
BEGIN
	DECLARE @SAYAC INT = 0
	DECLARE @TAKSIT_TUTAR INT
	SET @TAKSIT_TUTAR = @TUTAR / @ADET

	WHILE(@SAYAC < @ADET)
	BEGIN
		INSERT INTO TAKSIT (KATILIMCI_REFNO, BORC, ODENEN, TARIH)
		VALUES(@KATILIMCI_REFNO, @TAKSIT_TUTAR, 0, DATEADD(MONTH, @SAYAC, GETDATE()))
		SET @SAYAC = @SAYAC + 1
	END
END
-- TAKSITLENDIR PROCEDURE -- END --
GO

EXEC usp_TAKSITLENDIR 1, 1000, 10
SELECT * FROM TAKSIT

GO

DECLARE @SAYAC INT = 1001
WHILE(@SAYAC <= 1000000)
BEGIN
	INSERT INTO KATILIMCI(ADI_SOYADI, TC_KIMLIK, ADRES, CEP_TEL, EMAIL)
	VALUES('Ad�Soyad�' + CAST(@SAYAC AS varchar), @SAYAC, 'Adres' + CAST(@SAYAC AS varchar), @SAYAC, 'RAMAZAN@HOTMAIL.COM'+CAST(@SAYAC AS varchar))
	SET @SAYAC = @SAYAC + 1
END

GO

-- TAKSIT ODE PROCEDURE -- START -- 
ALTER PROC usp_TAKSITODE(@KATILIMCI_REFNO INT, @TUTAR INT)
AS
BEGIN

DECLARE imlec CURSOR FOR SELECT TAKSIT_REFNO, BORC, ODENEN FROM TAKSIT WHERE KATILIMCI_REFNO = @KATILIMCI_REFNO AND BORC > ODENEN
DECLARE @TAKSIT_REFNO INT
DECLARE @BORC INT
DECLARE @ODENEN INT

OPEN imlec

FETCH NEXT FROM imlec INTO @TAKSIT_REFNO, @BORC, @ODENEN
WHILE(@@FETCH_STATUS=0)
BEGIN
	IF(@TUTAR > @BORC - @ODENEN)
	BEGIN
		UPDATE TAKSIT SET ODENEN=BORC WHERE TAKSIT_REFNO = @TAKSIT_REFNO
		SET @TUTAR=@TUTAR-(@BORC-@ODENEN)
	END
	ELSE
	BEGIN
		UPDATE TAKSIT SET ODENEN=ODENEN + @TUTAR WHERE TAKSIT_REFNO = @TAKSIT_REFNO
		SET @TUTAR=0
	END
	FETCH NEXT FROM imlec INTO @TAKSIT_REFNO, @BORC, @ODENEN
END
 
CLOSE imlec
DEALLOCATE imlec

END
-- TAKSIT ODE PROCEDURE -- END --
GO

EXEC usp_TAKSITODE 1, 115
UPDATE TAKSIT SET ODENEN = 0
SELECT * FROM TAKSIT