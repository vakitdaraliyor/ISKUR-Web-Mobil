-- CREATE INDEX INDEX_ADI ON TABLO_ADI(KOLON1,KOLON2,...)

-- Index Oluþturma
-- CREATE INDEX KATILIMCI_INX1 ON KATILIMCI(ADI_SOYADI)

-- Index Düþürme
-- DROP INDEX KATILIMCI.KATILIMCI_INX1

-- CREATE INDEX KATILIMCI_INX2 ON KATILIMCI(FIRMA_ADI ASC)

-- Bileþik Index
-- CREATE [UNIQUE] INDEX INDEX_ADI ON TABLO_ADI(KOLON1, KOLON2)
-- Önce az kayýt getiren kolon yazýlýr, sonra diðer kolon
-- CREATE INDEX KATILIMCI_INX3 ON KATILIMCI(FIRMA_ADI, ADI_SOYADI)
-- INSERT INTO KATILIMCI([ADI_SOYADI],[EMAIL],[TELEFON],[FIRMA_ADI],[GOREVI]) VALUES('Dixon','Quisque.ac.libero@dictum.edu','055 1173 2675','Nunc Ac Mattis Corporation','neque. Nullam ut nisi a odio semper cursus. Integer mollis.'),('Wells','sit.amet.orci@tincidunt.ca','07624 929501','Nullam Associates','lacus pede sagittis augue, eu tempor erat neque non quam.'),('Sykes','odio.Aliquam@Utnecurna.com','0927 606 0522','Proin Mi LLP','lacinia mattis. Integer eu lacus. Quisque imperdiet, erat nonummy ultricies'),('Francis','Mauris.magna.Duis@Maecenasmi.com','(01278) 09246','Cubilia Foundation','sit amet diam eu dolor egestas rhoncus. Proin nisl sem,'),('Kirkland','auctor@Quisque.net','(022) 9810 1586','Vel Sapien Imperdiet PC','Mauris vestibulum, neque sed dictum eleifend, nunc risus varius orci,'),('Hammond','consectetuer.adipiscing.elit@nuncsed.ca','07998 564038','Faucibus Orci Limited','magna nec quam. Curabitur vel lectus. Cum sociis natoque penatibus'),('Dale','Phasellus.elit@odioAliquam.co.uk','(01135) 563203','Phasellus At Inc.','quis diam. Pellentesque habitant morbi tristique senectus et netus et'),('Hampton','Nunc.sollicitudin@rhoncus.com','(01973) 180352','Dui Fusce Diam Company','ut, pharetra sed, hendrerit a, arcu. Sed et libero. Proin'),('Hudson','ac@fermentumfermentumarcu.co.uk','076 2091 9874','Eget Ltd','pede ac urna. Ut tincidunt vehicula risus. Nulla eget metus'),('Wright','luctus.ipsum@Sed.co.uk','(0171) 001 4842','Molestie Orci Tincidunt Ltd','commodo at, libero. Morbi accumsan laoreet ipsum. Curabitur consequat, lectus'),('Cruz','ac.eleifend.vitae@mollisduiin.ca','07624 527201','Ipsum Porta Corporation','tempor bibendum. Donec felis orci, adipiscing non, luctus sit amet,'),('Love','fringilla.mi@nectempus.edu','(01335) 88246','Risus Varius Orci LLC','tempus risus. Donec egestas. Duis ac arcu. Nunc mauris. Morbi'),('Ayala','ipsum@velest.net','0845 46 48','Molestie Foundation','tempus risus. Donec egestas. Duis ac arcu. Nunc mauris. Morbi'),('Moon','Etiam@dolor.org','0500 972756','Taciti Sociosqu Ad Associates','Vivamus sit amet risus. Donec egestas. Aliquam nec enim. Nunc'),('Mckinney','amet.diam@dolorsit.com','0845 46 41','Ac Facilisis Associates','et arcu imperdiet ullamcorper. Duis at lacus. Quisque purus sapien,'),('Payne','Nullam.feugiat@eget.edu','(022) 1149 6496','Pellentesque A Facilisis Corp.','ipsum. Suspendisse sagittis. Nullam vitae diam. Proin dolor. Nulla semper'),('Kidd','quam@dignissimtemporarcu.edu','070 4282 4826','Vestibulum Nec Euismod PC','mollis. Integer tincidunt aliquam arcu. Aliquam ultrices iaculis odio. Nam'),('Hanson','imperdiet.ullamcorper@gravida.co.uk','0500 110066','Euismod Ac Institute','massa lobortis ultrices. Vivamus rhoncus. Donec est. Nunc ullamcorper, velit'),('Griffith','metus.Aliquam@ametnulla.ca','0800 497053','Vulputate LLC','sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus'),('Vang','Phasellus.elit@Nunclaoreet.edu','055 7707 9876','Aliquam Tincidunt Limited','quis diam luctus lobortis. Class aptent taciti sociosqu ad litora'),('Love','nulla.In@enim.edu','(024) 0814 3625','Phasellus Fermentum Foundation','Nulla eget metus eu erat semper rutrum. Fusce dolor quam,'),('Rios','ullamcorper.velit@Suspendissealiquet.edu','07747 800535','Risus At Fringilla Company','amet, consectetuer adipiscing elit. Etiam laoreet, libero et tristique pellentesque,'),('Holder','Nulla@faucibusorci.co.uk','0845 46 40','Augue Id Ante Institute','nunc, ullamcorper eu, euismod ac, fermentum vel, mauris. Integer sem'),('Estes','in.molestie.tortor@nequevenenatislacus.com','(01797) 76012','Nisi Dictum Company','et, commodo at, libero. Morbi accumsan laoreet ipsum. Curabitur consequat,'),('Rich','malesuada.ut.sem@sed.org','(01725) 00491','Nulla Facilisi Sed Corp.','consequat enim diam vel arcu. Curabitur ut odio vel est'),('Robinson','vehicula.Pellentesque.tincidunt@fringillami.co.uk','056 3833 1275','Donec Non Justo Corporation','purus gravida sagittis. Duis gravida. Praesent eu nulla at sem'),('Cruz','Nam.nulla.magna@Proin.org','0800 1111','Aenean Eget Metus Associates','Nam ligula elit, pretium et, rutrum non, hendrerit id, ante.'),('Berger','consequat@etmagnisdis.org','(01944) 549241','Convallis Est Industries','a neque. Nullam ut nisi a odio semper cursus. Integer'),('Guerra','eros@euismodetcommodo.edu','0846 734 5095','Tempor Bibendum Donec Inc.','eget odio. Aliquam vulputate ullamcorper magna. Sed eu eros. Nam'),('Levy','adipiscing@Donec.ca','055 0345 7417','Nascetur Ridiculus Inc.','Fusce mi lorem, vehicula et, rutrum eu, ultrices sit amet,'),('Strickland','scelerisque@vehiculaetrutrum.edu','056 1139 2292','Dolor Quisque Tincidunt Consulting','lobortis risus. In mi pede, nonummy ut, molestie in, tempus'),('Tyler','ipsum.porta.elit@lectusjustoeu.org','076 2943 2533','Risus Corp.','at sem molestie sodales. Mauris blandit enim consequat purus. Maecenas'),('Oneill','sapien.Aenean.massa@duinec.net','0500 581270','Orci Ltd','a, malesuada id, erat. Etiam vestibulum massa rutrum magna. Cras'),('Peck','sed@egetmollislectus.edu','0326 694 0539','Mattis Semper Associates','tempor bibendum. Donec felis orci, adipiscing non, luctus sit amet,'),('Hahn','sem.mollis.dui@Proinsedturpis.co.uk','0800 702 2514','At Arcu Vestibulum Associates','enim mi tempor lorem, eget mollis lectus pede et risus.'),('King','nibh.Phasellus@dolortempusnon.com','(016977) 9175','Accumsan Laoreet Ipsum Ltd','viverra. Donec tempus, lorem fringilla ornare placerat, orci lacus vestibulum'),('Beck','arcu.Sed.et@ProindolorNulla.com','(01874) 73829','Donec PC','elit. Etiam laoreet, libero et tristique pellentesque, tellus sem mollis'),('Figueroa','ultrices.posuere.cubilia@In.co.uk','(025) 8692 2642','Sem Consequat Nec Associates','Nulla dignissim. Maecenas ornare egestas ligula. Nullam feugiat placerat velit.'),('Buck','Proin@vulputate.ca','0860 358 9057','Neque Vitae Semper LLP','Nulla eu neque pellentesque massa lobortis ultrices. Vivamus rhoncus. Donec'),('Buck','erat@arcu.org','(01497) 205621','In Faucibus Morbi Industries','nibh sit amet orci. Ut sagittis lobortis mauris. Suspendisse aliquet'),('Franks','id@consectetuercursuset.ca','(01708) 040337','Feugiat Lorem Corporation','id, erat. Etiam vestibulum massa rutrum magna. Cras convallis convallis'),('Conway','lobortis@sagittis.ca','0800 014334','Euismod Mauris Eu PC','Integer id magna et ipsum cursus vestibulum. Mauris magna. Duis'),('Browning','scelerisque.scelerisque@magna.edu','0800 285608','Dui Quis Accumsan Inc.','placerat velit. Quisque varius. Nam porttitor scelerisque neque. Nullam nisl.'),('Foley','Aenean@metussit.ca','07624 642896','Luctus Sit Industries','tincidunt dui augue eu tellus. Phasellus elit pede, malesuada vel,'),('Conway','pellentesque.massa.lobortis@adipiscingfringilla.com','(025) 0841 7752','Lacus Nulla Inc.','mattis semper, dui lectus rutrum urna, nec luctus felis purus'),('Gillespie','tincidunt.neque.vitae@et.org','0812 660 5897','Fusce Mollis Ltd','consectetuer mauris id sapien. Cras dolor dolor, tempus non, lacinia'),('Nielsen','Sed@dictumsapienAenean.com','0845 46 47','Nullam Nisl Maecenas Company','Pellentesque ultricies dignissim lacus. Aliquam rutrum lorem ac risus. Morbi'),('Osborn','quis.diam@pede.org','(0112) 413 7394','Diam PC','netus et malesuada fames ac turpis egestas. Fusce aliquet magna'),('Mccarty','eleifend.egestas@convallis.edu','07228 457408','Dolor Dolor Company','laoreet posuere, enim nisl elementum purus, accumsan interdum libero dui'),('Williamson','auctor.odio@nislelementum.org','(017516) 16328','Aliquam Arcu Aliquam Limited','nunc. In at pede. Cras vulputate velit eu sem. Pellentesque'),('Gibbs','rhoncus@Aeneansed.edu','07975 070891','Enim Industries','sit amet risus. Donec egestas. Aliquam nec enim. Nunc ut'),('Moreno','nisl.sem.consequat@augueacipsum.com','0800 103 1761','Sit Amet Lorem Limited','tellus, imperdiet non, vestibulum nec, euismod in, dolor. Fusce feugiat.'),('Downs','commodo.hendrerit@DuisgravidaPraesent.net','0845 46 41','Lorem Ipsum Dolor Associates','Duis sit amet diam eu dolor egestas rhoncus. Proin nisl'),('Miller','rutrum@venenatisamagna.org','(0114) 139 4441','Quam Ltd','leo. Morbi neque tellus, imperdiet non, vestibulum nec, euismod in,'),('Barnes','eu@fringillaeuismod.com','07075 655307','Sodales Nisi Magna PC','sit amet orci. Ut sagittis lobortis mauris. Suspendisse aliquet molestie'),('Deleon','sem@Proin.org','07624 310527','Cursus Nunc Mauris Company','eu erat semper rutrum. Fusce dolor quam, elementum at, egestas'),('Beard','dapibus.id@velit.net','0958 098 3291','Dui Foundation','Etiam laoreet, libero et tristique pellentesque, tellus sem mollis dui,'),('Black','ut.mi@sitametlorem.com','0877 682 6484','Nostra LLP','condimentum. Donec at arcu. Vestibulum ante ipsum primis in faucibus'),('Caldwell','sapien.Cras@FuscefeugiatLorem.org','(011054) 10617','Curae; Phasellus Corporation','nunc interdum feugiat. Sed nec metus facilisis lorem tristique aliquet.'),('Maddox','eros@ProindolorNulla.co.uk','(0191) 144 3279','Sagittis Lobortis Mauris Foundation','adipiscing lobortis risus. In mi pede, nonummy ut, molestie in,'),('Harvey','risus.In.mi@ametfaucibusut.co.uk','070 5340 3713','Ut Tincidunt Vehicula Limited','augue. Sed molestie. Sed id risus quis diam luctus lobortis.'),('Mcdonald','magnis@necenim.org','(017327) 30804','Neque Limited','erat, in consectetuer ipsum nunc id enim. Curabitur massa. Vestibulum'),('Atkins','semper@Sednulla.com','(016977) 6281','Justo Consulting','metus. Aenean sed pede nec ante blandit viverra. Donec tempus,'),('Cervantes','lacus.Aliquam@lectuspedeet.ca','07352 617954','Feugiat Limited','nec, mollis vitae, posuere at, velit. Cras lorem lorem, luctus'),('Copeland','Nullam@hendreritid.org','0845 46 46','Proin Dolor Nulla Incorporated','vehicula et, rutrum eu, ultrices sit amet, risus. Donec nibh'),('Alston','nec.metus.facilisis@atnisiCum.edu','0305 094 9310','Scelerisque Neque Corporation','ipsum dolor sit amet, consectetuer adipiscing elit. Etiam laoreet, libero'),('Wade','pede.nec.ante@idmagna.edu','070 1928 4818','Congue A Aliquet Incorporated','elit erat vitae risus. Duis a mi fringilla mi lacinia'),('Francis','dolor.dolor.tempus@Maurisnondui.org','0800 107479','Odio Etiam Foundation','sed tortor. Integer aliquam adipiscing lacus. Ut nec urna et'),('Rodriquez','et@ultriciesadipiscingenim.com','(0112) 967 9439','Magna Suspendisse Limited','dictum cursus. Nunc mauris elit, dictum eu, eleifend nec, malesuada'),('Blackwell','facilisis.facilisis.magna@pharetrautpharetra.ca','076 6944 7485','Dui Fusce PC','eu odio tristique pharetra. Quisque ac libero nec ligula consectetuer'),('Mccullough','at.velit@mattissemperdui.ca','070 0335 2997','Risus Company','varius orci, in consequat enim diam vel arcu. Curabitur ut'),('Townsend','lectus.ante.dictum@eratnonummyultricies.org','0335 984 1748','Molestie Arcu Sed Industries','convallis ligula. Donec luctus aliquet odio. Etiam ligula tortor, dictum'),('Rocha','Donec.vitae@nonummy.com','(0191) 620 0383','Risus Industries','adipiscing fringilla, porttitor vulputate, posuere vulputate, lacus. Cras interdum. Nunc'),('Delacruz','In.nec.orci@auguescelerisque.edu','0884 312 0732','Non Bibendum Sed Inc.','Duis dignissim tempor arcu. Vestibulum ut eros non enim commodo'),('Holden','arcu.Nunc.mauris@adipiscingelitAliquam.com','056 3397 7587','Bibendum Ullamcorper Inc.','felis. Nulla tempor augue ac ipsum. Phasellus vitae mauris sit'),('Craig','Ut.nec@Donecestmauris.org','(01176) 435176','Posuere Incorporated','non, luctus sit amet, faucibus ut, nulla. Cras eu tellus'),('Chen','vel@aliquamarcuAliquam.ca','076 3046 2933','Faucibus Ut Consulting','ac tellus. Suspendisse sed dolor. Fusce mi lorem, vehicula et,'),('Ryan','nonummy@loremegetmollis.org','0922 137 4689','Faucibus Associates','erat, in consectetuer ipsum nunc id enim. Curabitur massa. Vestibulum'),('Mitchell','laoreet.ipsum.Curabitur@utcursus.com','(0117) 538 9407','Erat Etiam LLC','Curae; Donec tincidunt. Donec vitae erat vel pede blandit congue.'),('Townsend','dictum@non.ca','0346 698 7714','Eleifend Nec Corporation','orci, consectetuer euismod est arcu ac orci. Ut semper pretium'),('Cantu','lacinia.at.iaculis@malesuadavel.co.uk','07688 185168','Euismod PC','libero. Integer in magna. Phasellus dolor elit, pellentesque a, facilisis'),('Hyde','non@porttitortellus.net','07624 336076','Vel Company','sed pede nec ante blandit viverra. Donec tempus, lorem fringilla'),('Walker','suscipit.est@Duisrisus.com','0800 1111','Per Corporation','eget metus. In nec orci. Donec nibh. Quisque nonummy ipsum'),('Miranda','ipsum.Curabitur.consequat@nibh.org','(016977) 2461','Magna Corporation','diam lorem, auctor quis, tristique ac, eleifend vitae, erat. Vivamus'),('Munoz','Phasellus.vitae.mauris@vitaeodiosagittis.co.uk','(0115) 186 9971','Consectetuer Limited','sit amet ultricies sem magna nec quam. Curabitur vel lectus.'),('Hunt','purus.Nullam@auctor.net','056 9772 3543','Dui Inc.','neque. In ornare sagittis felis. Donec tempor, est ac mattis'),('Wilkerson','amet.nulla@Nullamut.org','0845 46 47','Orci Lacus Vestibulum Incorporated','adipiscing ligula. Aenean gravida nunc sed pede. Cum sociis natoque'),('Waller','Donec.fringilla@arcu.ca','076 4346 5191','Lacus Nulla Company','ut erat. Sed nunc est, mollis non, cursus non, egestas'),('White','semper.erat@velit.edu','(0117) 268 1457','Adipiscing Ltd','Donec tempor, est ac mattis semper, dui lectus rutrum urna,'),('Booth','non.ante.bibendum@nisinibhlacinia.net','07624 685663','Parturient Montes Nascetur LLC','vestibulum lorem, sit amet ultricies sem magna nec quam. Curabitur'),('Hubbard','Phasellus@eteuismodet.net','07624 115304','Et Corporation','adipiscing ligula. Aenean gravida nunc sed pede. Cum sociis natoque'),('Munoz','et@maurissagittis.com','0800 487 9450','Magna Nam Ligula Company','Mauris eu turpis. Nulla aliquet. Proin velit. Sed malesuada augue'),('Baird','malesuada@nulla.org','(016977) 6687','Dapibus Id Blandit Corporation','quis diam luctus lobortis. Class aptent taciti sociosqu ad litora'),('Robertson','eu@musDonecdignissim.org','(029) 5228 9138','Non Arcu Vivamus Limited','et risus. Quisque libero lacus, varius et, euismod et, commodo'),('Guzman','aliquet.magna@semper.org','0500 752915','Eu Corp.','Donec egestas. Aliquam nec enim. Nunc ut erat. Sed nunc'),('Weeks','Sed.eget@musAenean.ca','070 8307 2368','Aliquam Ultrices Iaculis LLC','vel lectus. Cum sociis natoque penatibus et magnis dis parturient'),('Dodson','cursus@enim.net','0800 157 3614','Ridiculus LLC','pede, malesuada vel, venenatis vel, faucibus id, libero. Donec consectetuer'),('Donovan','pretium@risusDonec.org','(015986) 33783','Odio Industries','semper, dui lectus rutrum urna, nec luctus felis purus ac'),('Dickson','ridiculus.mus@cubiliaCurae.ca','0845 46 44','Dictum Ultricies Ligula Corporation','pharetra. Nam ac nulla. In tincidunt congue turpis. In condimentum.'),('Wilkins','arcu@magnaCrasconvallis.ca','076 5265 4892','Augue Sed PC','ornare tortor at risus. Nunc ac sem ut dolor dapibus');

-- Örten Index
-- SELECT ADI_SOYADI FROM KATILIMCI 
-- WHERE ADI_SOYADI = 'Dixon'

-- Index yeniden oluþturma
-- Bir index örnek olarak 67 page yer kaplýyorsa, rebuild yapýldýðýnda 55 page yer kaplar
-- ama reorganize edilirse 67 page yer kaplar, diðer 12 page boþ durur, sonraki iþlemlerde kullanýlýr
-- eðer parçalanma %5 ten büyükse reorganization %30 dan büyükse rebuild yapýlmasý uygun olur

-- ALTER INDEX ALL ON KATILIMCI REBUILD 

-- ALTER INDEX ALL ON KATILIMCI REORGANIZE

-- table usage sql script
-- Get size of all tables in database
/*SELECT 
    t.NAME AS TableName,
    s.Name AS SchemaName,
    p.rows AS RowCounts,
    SUM(a.total_pages) * 8 AS TotalSpaceKB, 
    CAST(ROUND(((SUM(a.total_pages) * 8) / 1024.00), 2) AS NUMERIC(36, 2)) AS TotalSpaceMB,
    SUM(a.used_pages) * 8 AS UsedSpaceKB, 
    CAST(ROUND(((SUM(a.used_pages) * 8) / 1024.00), 2) AS NUMERIC(36, 2)) AS UsedSpaceMB, 
    (SUM(a.total_pages) - SUM(a.used_pages)) * 8 AS UnusedSpaceKB,
    CAST(ROUND(((SUM(a.total_pages) - SUM(a.used_pages)) * 8) / 1024.00, 2) AS NUMERIC(36, 2)) AS UnusedSpaceMB
FROM 
    sys.tables t
INNER JOIN      
    sys.indexes i ON t.OBJECT_ID = i.object_id
INNER JOIN 
    sys.partitions p ON i.object_id = p.OBJECT_ID AND i.index_id = p.index_id
INNER JOIN 
    sys.allocation_units a ON p.partition_id = a.container_id
LEFT OUTER JOIN 
    sys.schemas s ON t.schema_id = s.schema_id
WHERE 
    t.NAME NOT LIKE 'dt%' 
    AND t.is_ms_shipped = 0
    AND i.OBJECT_ID > 255 
GROUP BY 
    t.Name, s.Name, p.Rows
ORDER BY 
    t.Name*/

-- TSQL Nedir?
-- Veri tabaný programlama dilidir.Programlama kalýplarýný(deðiþken tanýmlama, döngüler, karar mekanizmalarý)
-- ve SQL cümlelerini kullanarak kod geliþtirip çalýþtýrýlabilir. Sunucu üzerinde çalýþan kod, yordam ve fonksiyonlardýr

DECLARE @SAYI1 INT = -1;
DECLARE @SAYI2 INT = -2;
DECLARE @TOPLAM INT = 0;

SET @TOPLAM = @SAYI1 + @SAYI2;
PRINT @TOPLAM

GO -- üstteki script alttakinden baðýmsýz
-- 0 ile 100 arasýndaki sayýlarýn toplamý
DECLARE @SAYI1 INT = 0
DECLARE @SAYI2 INT = 100
DECLARE @TOPLAM INT = 0

WHILE(@SAYI1 <= @SAYI2)
BEGIN
	SET @TOPLAM = @TOPLAM + @SAYI1
	SET @SAYI1 = @SAYI1 + 1
END
PRINT @TOPLAM

GO
-- Hangi sayý büyük

DECLARE @SAYI1 INT = 20
DECLARE @SAYI2 INT = 100

IF(@SAYI1 > @SAYI2)
	PRINT 'SAYI1 BUYUK SAYI2'
ELSE IF(@SAYI1 < @SAYI2)
	PRINT 'SAYI2 BUYUK SAYI1'
ELSE
	PRINT 'SAYI1 ESIT SAYI2'

GO 
-- Sayýnýn iþareti
DECLARE @SAYI1 INT = -100

IF(@SAYI1 > 0)
	PRINT 'POZITIF'
ELSE IF(@SAYI1 < 0)
	PRINT 'NEGATIF'
ELSE
	PRINT 'SIFIR'

GO 

DECLARE @SAYI1 INT = 4
DECLARE @BOLEN INT = 2
DECLARE @SONUC VARCHAR(10) = 'ASAL'

WHILE(@BOLEN <= (@SAYI1 / 2))
BEGIN
	IF(@SAYI1 % @BOLEN = 0)
	BEGIN 
		SET @SONUC = 'ASAL DEÐÝL'
		BREAK
	END
	SET @BOLEN = @BOLEN +1
END
PRINT @SONUC

GO
-- 65 ile 90 arasýnda rasTgele sayý üretir
-- SELECT ROUND(65 + RAND() * 25,0)
GO
-- 20 haneli aktivasyon kodu üretme
DECLARE @KOD VARCHAR(20) = ''
DECLARE @SAYI INT = 0
WHILE(@SAYI <= 20)
BEGIN
	SET @KOD = @KOD + CHAR (ROUND(65 + RAND() * 25,0))
	SET @SAYI = @SAYI +1
END
PRINT @KOD
GO

-- Rastgele 10 tane
SELECT TOP 10 * FROM EMAGAZA.dbo.URUN WHERE EMAGAZA.dbo.URUN.INDIRIM_DURUMU = 1
ORDER BY NEWID()

GO

-- SELECT CHARINDEX('a', 'Mustafa', 1)
DECLARE @CUMLE VARCHAR(100) = 'Çaldýðýn o kalbi yerine koy lütfen.Eðer hislerinden pek emin deðilsen.'
DECLARE @KELIME VARCHAR(10) = ' '
DECLARE @ADET INT = 0
DECLARE @YER INT = 0

SET @YER = CHARINDEX(@KELIME, @CUMLE, 1)
WHILE(@YER > 0)
BEGIN
	SET @ADET = @ADET + 1
	SET @YER = CHARINDEX(@KELIME, @CUMLE, @YER + 1)
END
PRINT @ADET

GO

SELECT SUBSTRING('YILDIRIM BEYAZIT', 1, 8) -- YILDIRIM

SELECT LEN('YILDIRIM BEYAZIT') AS UZUNLUK -- 16

SELECT LEFT('YILDIRIM BEYAZIT', 3) AS SOLDAN -- YIL
SELECT RIGHT('YILDIRIM BEYAZIT', 3) AS SAGDAN -- ZIT

SELECT LEN(LTRIM('           YILDIRIM BEYAZIT')) AS SOLDANTRIM -- 16
SELECT LEN(RTRIM('YILDIRIM BEYAZIT           ')) AS SAGDANTRIM -- 16
SELECT LEN(LTRIM(RTRIM('           YILDIRIM BEYAZIT          '))) AS SAGLISOLLU --16

SELECT LOWER('YILDIRIM BEYAZIT') AS KUCULT -- yýldýrým beyazýt
SELECT UPPER('yýldýrým beyazýt') AS BUYULT -- YILDIRIM BEYAZIT

SELECT CEILING(10.4) AS YUKARIYUVARLA -- 11
SELECT FLOOR(10.4) AS ASAGIYUVARLA -- 10

-- Yuvarlamadan sayýnýn küsüratýný kesme
SELECT ROUND(123.456, 1, 1) -- 123.400
SELECT ROUND(123.456, -2) -- 123.500
SELECT ROUND(123.456, -1) -- 120.000
SELECT ROUND(123.456, -0) -- 123.000
SELECT ROUND(123.456, 1) -- 123.500
SELECT ROUND(123.456, 2) -- 123.460

GO

-- Yordam Nasýl Oluþturulur
 CREATE PROC usp_TOPLA(@SAYI1 INT, @SAYI2 INT)
 AS
 BEGIN
	DECLARE @TOPLAM INT = 0
	SET @TOPLAM = @SAYI1 + @SAYI2
	PRINT @TOPLAM
END
GO

EXEC dbo.usp_TOPLA @SAYI1=10, @SAYI2=20
DROP PROC usp_URUNLER
GO

CREATE PROC usp_URUNLER
AS
BEGIN
	SELECT * FROM EMAGAZA.dbo.URUN
END

GO
EXEC usp_URUNLER

GO

CREATE PROC usp_URUNLER2(@REFNO INT)
AS
BEGIN
	SELECT * FROM EMAGAZA.dbo.URUN WHERE URUN_REFNO = @REFNO
END

GO
EXEC usp_URUNLER2 5097

GO

ALTER PROC usp_URUNLER3(@URUN_ADI VARCHAR(100))
AS
BEGIN
	SELECT * FROM EMAGAZA.dbo.URUN WHERE URUN_ADI LIKE '%' + @URUN_ADI + '%'
	SELECT * FROM EMAGAZA.dbo.KATEGORI
END

GO

EXEC usp_URUNLER3 'as'

GO

-- Fonksiyon nasýl yazýlýr
-- Tek deðer döndüren fonksiyon
CREATE FUNCTION fnc_TOPLA(@SAYI1 INT, @SAYI2 INT) RETURNS INT
AS
BEGIN
	RETURN @SAYI1 + @SAYI2
END

GO

SELECT dbo.fnc_TOPLA(10, 10)
SELECT dbo.fnc_TOPLA(EMAGAZA.dbo.URUN.FIYATI, 10) ZAMLI_FIYAT FROM EMAGAZA.dbo.URUN

GO

-- Tablo Döndüren fonksiyon
-- Tek satýrlýk (Inline Table Valued Function)
CREATE FUNCTION fnc_URUNLER() RETURNS TABLE
AS
	RETURN SELECT * FROM EMAGAZA.dbo.URUN 
GO

SELECT * FROM dbo.fnc_URUNLER()

GO

-- Table Values Function(Tablo döndüren fonksiyon)
CREATE FUNCTION fnc_URUNLER2() RETURNS @TABLO TABLE(ADI_SOYADI VARCHAR(20), ADRES VARCHAR(100))
AS
BEGIN
	INSERT INTO @TABLO VALUES('Ramazan', 'Ankara')
	INSERT INTO @TABLO VALUES('Osman', 'Ankara')
	INSERT INTO @TABLO VALUES('Mustafa', 'Ankara')
	INSERT INTO @TABLO VALUES('Soner', 'Ankara')
	RETURN
END

GO

SELECT * FROM dbo.fnc_URUNLER2()