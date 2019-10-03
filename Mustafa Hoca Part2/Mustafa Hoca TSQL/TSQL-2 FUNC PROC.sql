-- �ki kelimeyi araya bo�luk b�rakarak birle�tiren fonksiyonu yaz�n�z
ALTER FUNCTION fnc_BIRLESTIR(@KELIME1 VARCHAR(100), @KELIME2 VARCHAR(100)) RETURNS VARCHAR(201)
AS
BEGIN
	RETURN @KELIME1 + ' ' + @KELIME2
END

GO

SELECT dbo.fnc_BIRLESTIR('Ramazan', 'Mercan') as BirlesikKelime
GO

-- EMAGAZA veritaban�nda stoktaki �r�nlerin toplam fiyatlar�n� bulan fonksiyonu yaz�n

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
-- Derlendiklerinde i�erdikleri kodlar�n �al��ma plan� haz�rlan�r
-- ve hep bu �al��ma plan� uygulan�r
-- Execution planlar haf�zada kald��� i�in bi daha execution plan� ��karmaz. Stored procedure in i�eri�i ayn� kal�r.
-- Network trafi�ini azalt�r. Stored procedure ile 50000 ki�inin hesab�n� yapmak daha kolayd�r

-- Urun fiyat�na X oran�nda zam yapan yordam� yaz�n�z

CREATE PROC usp_URUNEZAM(@ORAN INT)
AS
BEGIN
	UPDATE URUN SET FIYATI = FIYATI*@ORAN
END

GO 

EXEC usp_URUNEZAM 5

GO

-- Sipari� DURUMU 0 olan sipari�leri silen procedure(yordam) yaz�n�z
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
-- CURSOR Nedir?(G�sterge� ya da �mle� denir)
-- Hangi sat�rda oldu�umuzu g�sterir.Sat�r� i�aret eder.

-- imlec tan�mand�
DECLARE imlec CURSOR FOR SELECT URUN_REFNO, URUN_ADI, FIYATI FROM URUN
-- imlec ile elde edilecek veriler i�in de�i�kenler tan�mland�
DECLARE @URUN_REFNO INT
DECLARE @URUN_ADI VARCHAR(100)
DECLARE @FIYATI DECIMAL

OPEN imlec -- imlec a��l�r

-- ilk sat�r elde ediliyor
FETCH NEXT FROM imlec INTO @URUN_REFNO, @URUN_ADI, @FIYATI
WHILE(@@FETCH_STATUS = 0)
BEGIN
	PRINT @URUN_ADI
	FETCH NEXT FROM imlec INTO @URUN_REFNO, @URUN_ADI, @FIYATI
END

CLOSE imlec -- imlec kapan�r
DEALLOCATE imlec -- imlec haf�zadan at�l�r

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
	-- de�i�ken sql sorgular�n� �al��t�rmak i�in EXECUTE(SQL) kullan�l�r
		 EXECUTE ('ALTER INDEX ALL ON ' + @TABLE_NAME + ' REBUILD' ) -- *** �OK ��E YARAR
		 PRINT @TABLE_NAME + ' tablosundaki indexler d�zenlendi'
		 FETCH NEXT FROM imlec INTO @TABLE_NAME
	END
	CLOSE imlec
	DEALLOCATE imlec
END