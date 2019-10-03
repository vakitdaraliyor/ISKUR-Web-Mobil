-- Ýki kelimeyi araya boþluk býrakarak birleþtiren fonksiyonu yazýnýz
ALTER FUNCTION fnc_BIRLESTIR(@KELIME1 VARCHAR(100), @KELIME2 VARCHAR(100)) RETURNS VARCHAR(201)
AS
BEGIN
	RETURN @KELIME1 + ' ' + @KELIME2
END

GO

SELECT dbo.fnc_BIRLESTIR('Ramazan', 'Mercan') as BirlesikKelime
GO

-- EMAGAZA veritabanýnda stoktaki ürünlerin toplam fiyatlarýný bulan fonksiyonu yazýn

CREATE FUNCTION fnc_EMAGAZASTOKTOPLAM() RETURNS DECIMAL
AS
BEGIN
	DECLARE @TOPLAM DECIMAL
	SELECT @TOPLAM = SUM(FIYATI*ADET) FROM URUN
	RETURN @TOPLAM
END

GO

SELECT dbo.fnc_EMAGAZASTOKTOPLAM() AS STOKTAKI_URUNLERIN_TOPLAM_FIYATI

GO

-- NEDEN YORDAM VE FONKSIYON KULLANILIR?
-- Derlendiklerinde içerdikleri kodlarýn çalýþma planý hazýrlanýr
-- ve hep bu çalýþma planý uygulanýr
-- Execution planlar hafýzada kaldýðý için bi daha execution planý çýkarmaz. Stored procedure in içeriði ayný kalýr.
-- Network trafiðini azaltýr. Stored procedure ile 50000 kiþinin hesabýný yapmak daha kolaydýr

-- Urun fiyatýna X oranýnda zam yapan yordamý yazýnýz

CREATE PROC usp_URUNEZAM(@ORAN INT)
AS
BEGIN
	UPDATE URUN SET FIYATI = FIYATI*@ORAN
END

GO 

EXEC usp_URUNEZAM 5

GO

-- Sipariþ DURUMU 0 olan sipariþleri silen procedure(yordam) yazýnýz
ALTER PROC usp_SIPARIS_SIL(@SAYI INT OUT)
AS
BEGIN
	DELETE FROM SIPARIS WHERE DURUMU_REFNO = 0
	SET @SAYI = @@ROWCOUNT
END

GO

DECLARE @SAYI INT
EXEC usp_SIPARIS_SIL @SAYI OUT
PRINT @SAYI

GO
-------------------------------------------------------
-- CURSOR Nedir?(Göstergeç ya da Ýmleç denir)
-- Hangi satýrda olduðumuzu gösterir.Satýrý iþaret eder.

-- imlec tanýmandý
DECLARE imlec CURSOR FOR SELECT URUN_REFNO, URUN_ADI, FIYATI FROM URUN
-- imlec ile elde edilecek veriler için deðiþkenler tanýmlandý
DECLARE @URUN_REFNO INT
DECLARE @URUN_ADI VARCHAR(100)
DECLARE @FIYATI DECIMAL

OPEN imlec -- imlec açýlýr

-- ilk satýr elde ediliyor
FETCH NEXT FROM imlec INTO @URUN_REFNO, @URUN_ADI, @FIYATI
WHILE(@@FETCH_STATUS = 0)
BEGIN
	PRINT @URUN_ADI
	FETCH NEXT FROM imlec INTO @URUN_REFNO, @URUN_ADI, @FIYATI
END

CLOSE imlec -- imlec kapanýr
DEALLOCATE imlec -- imlec hafýzadan atýlýr

GO

-- INDEX DUZENLEME TSQL SCRIPT I
CREATE PROC INDEX_DUZENLE
AS
BEGIN
	DECLARE imlec CURSOR FOR SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES
	DECLARE @TABLE_NAME VARCHAR(100)

	OPEN imlec

	FETCH NEXT FROM imlec INTO @TABLE_NAME

	WHILE(@@FETCH_STATUS = 0)
	BEGIN
	-- deðiþken sql sorgularýný çalýþtýrmak için EXECUTE(SQL) kullanýlýr
		 EXECUTE ('ALTER INDEX ALL ON ' + @TABLE_NAME + ' REBUILD' ) -- *** ÇOK ÝÞE YARAR
		 PRINT @TABLE_NAME + ' tablosundaki indexler düzenlendi'
		 FETCH NEXT FROM imlec INTO @TABLE_NAME
	END
	CLOSE imlec
	DEALLOCATE imlec
END