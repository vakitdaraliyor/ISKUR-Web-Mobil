/*UPDATE pers_har
SET alacak = alacak*0.97
WHERE tarih > '2014-06-30'*/

/*UPDATE pers_har
SET alacak = alacak*0.50
WHERE tarih > '2014-06-30'*/

/*UPDATE pers_har 
SET alacak = alacak + alacak*0.25
WHERE tarih > '2014-06-30'*/

-- 8.	Çalışan Personel Listesini alınız.(son maaşlara göre)
-- SELECT adi_soyadi, telefon, maas, gorev_adi, dept_adi FROM personel NATURAL LEFT OUTER JOIN gorev NATURAL LEFT OUTER JOIN departman

-- 9.	Personele ödenecek toplam aylık maaşı bulan SQL kodunu yazınız.
-- SELECT tarih, SUM(alacak) as toplam_aylik FROM pers_har GROUP BY tarih

-- 10.	Şu ana kadar, hangi personele toplam ne kadar para ödendi ve daha ne kadar para ödenecek SQL'ini yazınız.
-- SELECT adi_soyadi, SUM(borc) AS odenen, SUM(borc - alacak) AS odenecek FROM personel, pers_har
-- WHERE personel.personel_id = pers_har.personel_id group by adi_soyadi

-- 11.	Firmanın şu ana kadar ödediği toplam ücret ve ödeyeceği toplam ücreti bulan SQL kodunu yazınız.
-- SELECT SUM(borc) AS toplam_odeme, (SUM(alacak-borc)) AS toplam_odenecek FROM pers_har

-- 12.	Aldığı ücret 2000 TL'nin üstünde olan personelin listesini bulunuz.
-- SELECT adi_soyadi, telefon, maas, gorev_adi, dept_adi FROM personel NATURAL LEFT OUTER JOIN gorev NATURAL LEFT OUTER JOIN departman
-- WHERE maas > 2000

-- 13.	Herbir departmandaki ortalama maaşı bulan SQL'i yazınız.
-- SELECT dept_adi, AVG(maas)
-- FROM personel NATURAL LEFT OUTER JOIN departman
-- WHERE dept_adi is not null
-- GROUP BY dept_adi

-- 14.	Herhangi bir departmanda çalışmayan personel listesini bulunuz.
-- SELECT adi_soyadi, telefon, maas, gorev_adi, dept_adi
-- FROM personel NATURAL LEFT OUTER JOIN gorev NATURAL LEFT OUTER JOIN departman
-- WHERE dept_adi is null
-- GROUP BY adi_soyadi

-- 15.	Recai Tüfekçi kriz nedeniyle 2014 yılı sonunda işten çıkartılıyor. Gerekli güncellemeleri yapınız.
-- UPDATE personel
-- SET durum = 0, ayrilis_tarihi = '2019-07-02', dept_id = null
-- WHERE adi_soyadi = 'Refai Tüfekçi'

-- 15.	Çalışanı olmayan departmanların listesini bulunuz.
-- SELECT dept_adi as departman_adi FROM departman NATURAL LEFT OUTER JOIN personel
-- WHERE personel_id is null
-- GROUP BY dept_adi

-- 16.	Hangi departmanda ne kadar personel var listesini bulunuz
/*SELECT
(CASE WHEN dept_adi IS NULL THEN '-'
ELSE dept_adi END) AS departman_adi,
COUNT(personel_id) AS personel_sayisi
FROM personel NATURAL LEFT OUTER JOIN departman
WHERE durum = 1
GROUP BY dept_adi 
ORDER BY departman_adi ASC*/

-- 17.	Ortalama Maaşı 1250 TL nin üzerinde olan departmanların listesini bulunuz.
/*SELECT dept_adi AS departman_adi, AVG(maas) AS ortalama_maas
FROM departman NATURAL LEFT OUTER JOIN personel
GROUP BY dept_adi
HAVING AVG(maas) > 1250*/

-- 18.	Hangi eleman kaç aydır çalışıyor listesiniz bulunuz
-- SELECT adi_soyadi, TIMESTAMPDIFF(MONTH, giris_tarihi, '2019-07-02') AS Ay FROM personel

-- 19.	Bütün Personel ve Bütün departmanların listesini bulunuz.
/*SELECT(CASE WHEN adi_soyadi IS NULL THEN '-'
ELSE adi_soyadi END) AS adi_soyadi, departman_adi
FROM personel NATURAL RIGHT JOIN departman UNION ALL
SELECT(CASE WHEN dept_adi IS NULL THEN '-'
ELSE dept_adi END) AS adi_soyadi, departman_adi 
FROM personel NATURAL LEFT OUTER JOIN departman*/