-- SELECT * FROM university.student;
-- SELECT DISTINCT COUNT(name) FROM university.student
-- SELECT 'English' as Language FROM university.instructor
-- SELECT id, name, salary/12 as aylikucret from university.instructor
-- SELECT ID, name FROM instructor WHERE dept_name = 'English'
-- SELECT ID, name, dept_name, salary FROM instructor WHERE (dept_name = 'Comp. Sci.' OR dept_name = 'English') AND salary > 80000
-- SELECT * FROM instructor, teaches
-- SELECT * FROM instructor
-- SELECT name, course_id FROM instructor as i, teaches as t WHERE i.ID = t.ID  AND i.dept_name = 'Accounting'
-- SELECT name, grade, year FROM student as s, takes as t WHERE s.ID = t.ID AND s.ID = '1000' AND t.year = 2006
-- SELECT name FROM instructor WHERE name LIKE '________o' ORDER BY name ASC
-- SELECT * FROM instructor ORDER BY dept_name, name
-- SELECT name, salary FROM instructor WHERE salary BETWEEN 80000 AND 90000
-- SELECT AVG(salary) FROM instructor

-- Find courses that ran in Fall 2009 or in Spring 2010(Birleşim)
-- (SELECT course_id FROM section WHERE semester = 'Fall' AND year = 2009) 
-- UNION
-- (SELECT course_id FROM section WHERE semester = 'Spring' AND year = 2010)

-- Find courses that ran in Fall 2009 and in Spring 2010(Kesişim)
-- SELECT course_id FROM section WHERE semester = 'Fall' AND year = 2009
-- AND course_id 
-- NOT IN (SELECT course_id FROM section WHERE semester = 'Spring' AND year = 2010)

-- Find the salaries of all instructors that are less than the largest salary
-- SELECT DISTINCT T.salary
-- FROM instructor as T, instructor as S
-- WHERE T.salary < S.salary

-- Find all salaries
-- SELECT DISTINCT salary FROM instructor

-- Find max salary
-- SELECT MAX(salary) FROM instructor

-- Find max salary
-- SELECT DISTINCT salary FROM instructor
-- WHERE salary NOT IN (SELECT DISTINCT T.salary FROM instructor as T, instructor as S WHERE T.salary < S.salary)

-- is null
-- SELECT name FROM instructor WHERE salary is null

-- MIN AVG
-- SELECT MIN(salary) FROM instructor
-- SELECT AVG(salary) FROM instructor
-- SELECT MIN(salary) FROM instructor WHERE dept_name = 'Comp. Sci.'

-- Find the total number of instructors who teach a course in the Spring 2010 semester
-- SELECT COUNT(DISTINCT ID)
-- FROM teaches
-- Where semester = 'Fall' AND year = 2010

-- Find the number of tuples in the course relation
-- SELECT COUNT(course_id)
-- FROM course

-- Find the avarage salary of instructors in each department
-- SELECT dept_name, AVG(salary) as avarage_salary
-- FROM instructor
-- GROUP BY dept_name

-- Attributes in select clause outside of aggregate functions must appear in group by
-- SELECT dept_name, ID, AVG(salary) as avarage_salary
-- FROM instructor
-- GROUP BY dept_name

-- Find the names and avarage salaries of all dept. whose avarage salary is greather than 42000
-- SELECT dept_name, AVG(salary)
-- FROM instructor
-- GROUP BY dept_name
-- HAVING AVG(salary) > 100000

-- Total all salaries
-- SELECT SUM(salary)
-- FROM instructor

-- Find courses offered in Fall 2009 and in Spring 2010
/*SELECT DISTINCT course_id
FROM section
WHERE semester = 'Fall' AND year = 2010 AND
	course_id in (SELECT course_id
				  FROM section
                  WHERE semester = 'Spring' AND year = 2010)*/

-- Find the total number of (distinct) students who have 
-- taken course sections taught by the instructor with 10101
/*SELECT COUNT(DISTINCT ID)
FROM takes
WHERE (course_id, sec_id, semester, year) IN
					(SELECT course_id, sec_id, semester, year
                     FROM teaches
                     WHERE teaches.ID = 10101)*/
                     
-- Find names of instructors with salary greater than thatof some
-- (at least one) instructor in the Biology department
/*SELECT DISTINCT T.name
FROM instructor as T, instructor as S
WHERE T.salary > S.salary AND S.dept_name = 'Biology'*/ 

-- 1)Öğrencilerin total kredisi 100'den daha büyük olanların id ve isimlerini listeleyen sorguyu yazınız
-- SELECT ID, name FROM student WHERE tot_cred > 100 

-- 2)Öğrencilerin total kredisi 90 ile 100 arasında olanları listeleyiniz
-- SELECT * FROM student WHERE tot_cred BETWEEN 90 AND 100  

-- 3)En yüksek krediyi alan öğrencinin departmanını gösteren sorguyu yazınız
-- SELECT dept_name FROM student WHERE tot_cred = (SELECT MAX(tot_cred) FROM student)

-- 4)'Comp. Sci' ya da 'English' departmanındaki hocaların bilgilerini gösteren sorguyu yazınız
-- SELECT * FROM instructor WHERE dept_name = 'Comp. Sci.' OR dept_name = 'English'

-- 5)Departmanları bütçelerine göre sıralayınız
-- SELECT dept_name FROM department ORDER BY budget ASC

-- 6)(section tablosu) 145 numaralı sınıfta verilen derslerin ismini tekrar etmeden gösteren sorguyu yazınız
-- SELECT DISTINCT title FROM course 
-- WHERE (course_id) IN (SELECT course_id FROM section WHERE room_number = 145)

-- SELECT DISTINCT title FROM course as c, section s WHERE c.course_id = s.course_id  AND s.room_number = 145

-- 7)İsmi 'Ki' ile başlayan öğrencilerin isimlerini tekrar etmeden bulan sorguyu yazınız
-- SELECT DISTINCT name FROM student
-- WHERE name LIKE 'Ki%'

-- 8)İsmi 3 harfli olan öğrencilerin isimlerini tekrar etmeden listeleyen sorguyu yazınız
-- SELECT DISTINCT name FROM student
-- WHERE name LIKE '___'

-- 9)İsmi 7 harf veya daha fazla olan öğrencilerin isimlerini tekrar etmeden listeleyen sorguyu yazınız
-- SELECT DISTINCT name FROM student
-- WHERE name LIKE '_______%'

-- 10)Departmanının içinde 'Eng.' geçen (yani mühendislik okuyan) öğrencilerin tüm bilgilerini gösteren sorguyu yazınız
-- SELECT DISTINCT * FROM student
-- WHERE dept_name LIKE '%Eng%'

-- 11)Departmanları bütçelerine göre büyükten küçüğe doğru sıralayan sorguyu yazınız
-- SELECT dept_name, budget FROM department
-- ORDER BY budget DESC

-- 12)Bütçesi en fazla olan departmanı gösteren sorguyu yazınız
-- SELECT dept_name, budget FROM department WHERE budget = (SELECT MAX(budget) FROM department)

-- 13)Departmanların bütçesinin ortalamasını bulan sorguyu yazınız
-- SELECT AVG(budget) FROM department

-- 14)Mühendislik öğrencilerinin (departmanının içinde 'Eng.' geçen) sayısını gösteren sorguyu yazınız
-- SELECT COUNT(DISTINCT ID) FROM student
-- WHERE dept_name LIKE '%Eng%'
 
-- 15)Öğrencilerin departmanlara göre ortalama kredilerini gösteren sorguyu yazınız
-- SELECT dept_name, AVG(tot_cred) FROM student GROUP BY dept_name
 
-- 16)Ortalama alınan kredisi 80 in üstünde olan departmanların isimlerini ve ortalama kredilerini gösteren sorguyu yazınız
-- SELECT dept_name, AVG(tot_cred) FROM student
-- GROUP BY dept_name 
-- HAVING AVG(tot_cred) > 70

-- SELECT T.dept_name, T.Av
-- FROM(SELECT dept_name, AVG(tot_cred) as Av FROM student GROUP BY dept_name) as T
-- WHERE T.Av > 70

-- 17)Binalara göre gruplayarak sınıfların toplam kapasitesini gösteren sorguyu yazınız
-- SELECT building, SUM(capacity)
-- FROM classroom
-- GROUP BY building

-- 18)11101 id'li öğrencinin danışmanını(advisor) ismini gösteren sorguyu yazınız
-- SELECT name FROM instructor 
-- WHERE (ID) IN (SELECT i_ID FROM advisor WHERE s_ID = '11101')

-- 19)324 id'li dersin ismini ve prerequest olan ders/derslerin ismini gösteren sorguyu yazınız
-- SELECT title FROM course WHERE course_id IN (SELECT prereq_id FROM prereq WHERE course_id = '324')

-- 20)Bölümlerin toplam ders kredilerini büyükten küçüğe doğru sıralı gösteren sorguyu yazınız
-- SELECT dept_name, SUM(credits)
-- FROM course
-- GROUP BY dept_name
-- ORDER BY SUM(credits) DESC 
 
-- 21) 2006 Fall döneminde C, C+ ve C- alan öğrencilerin toplam sayısını bulan sorguyu yazınız
 /*SELECT COUNT(*) FROM takes
 WHERE (semester = 'Fall' AND year = 2006) AND ((grade = 'C') OR (grade = 'C+') OR (grade = 'C-'))*/

-- SELECT COUNT(*) FROM takes WHERE year = 2006 AND semester = 'Fall' AND grade LIKE 'C%'

-- 22) Öğrencilerin toplamda aldıkları ders sayılarını bulan sorguyu yazınız
 /*SELECT ID as student_id, COUNT(DISTINCT course_id) AS number_of_course
 FROM takes
 GROUP BY ID*/
 
-- Find the names of all instructors whose salary is greater
-- than the salary of all the instructors in the Biology department
-- SELECT name FROM instructor WHERE salary > all (SELECT salary from instructor WHERE dept_name = 'Biology') 

-- Yet another way of specifying the query
-- "Find all courses taught in both the Fall 2009 semester and in the Spring 2010 semester
/*SELECT course_id FROM section as S
WHERE semester = 'Fall' and year = 2009 and
		exists(SELECT * FROM section as T
			   WHERE semester = 'Spring' AND year = 2010
			   AND S.course_id = T.course_id)*/
               
/*SELECT C.course_id FROM course as C
WHERE UNIQUE(SELECT S.course_id FROM section as S WHERE C.course_id = S.course_id AND S.year = 2009)*/

/*SELECT T.dept_name, T.avg_salary
FROM(SELECT dept_name, AVG(salary) AS avg_salary FROM instructor GROUP BY dept_name) as T
WHERE T.avg_salary > 42000*/

/*SELECT dept_name, avg_salary
FROM(SELECT dept_name, avg(salary) FROM instructor GROUP BY dept_name) as dept_avg(dept_name, avg_salary)
WHERE avg_salary > 42000*/

-- Find all departments with the  maximum budget
-- WITH max_budget(value) AS (SELECT MAX(budget) FROM department)
-- SELECT department.dept_name FROM department, max_budget
-- WHERE department.budget = max_budget.value

-- Find all departments where the total salary is greater than
-- the avarage of the total salary at alldepartments
/*WITH dept_total(dept_name, value) AS
	(SELECT dept_name SUM(salary)
	FROM instructor
	GROUP BY dept_name),
dept_total_avg(value) AS
	(SELECT AVG(value)
	FROM dep_total)
SELECT dept_name
FROM dept_total, dept_total_avg
WHERE dept_total.value > dept_total_avg.value*/

-- List all departments along with the number of instructor in each department
/*SELECT dept_name,
		(SELECT COUNT(*) FROM instructor WHERE department.dept_name = instructor.dept_name) AS num_instructor
FROM department*/

-- 1) Comp. Sci departmanındaki çalışanların maaşlarını %10 artıran sorguyu yazınız.
-- UPDATE instructor SET salary = salary * 1.01 WHERE dept_name = 'Comp. Sci.';

-- 2) Hiç açılmayan dersleri silen sorguyu yazınız.
-- SELECT COUNT(course_id) FROM course  
-- DELETE FROM course WHERE (course_id) NOT IN (SELECT course_id FROM takes)
 
-- 3) tot_cred değeri 100'den büyük olan bütün öğrencileri aynı departmanda 10.000 maaşla instructor olarak ekleyiniz.
-- INSERT INTO instructor
-- SELECT ID, name, dept_name, 30000
-- FROM student WHERE tot_cred > 100

-- 4) 'Notlar' isimli, 'id' (not null) ve 'not' bilgisinden oluşan bir tablo oluşturun
/*CREATE TABLE Notlar(
	id INT NOT NULL AUTO_INCREMENT,
    nott INT,
    PRIMARY KEY(id)
);*/

-- 5) Notlar tablosuna kayıt ekleme
-- Bu tabloya id'si 1 notu 90 olan kayıdı ekleyen sorguyu yazınız 
-- Bu tabloya id'si 2 notu 80 olan kayıdı ekleyen sorguyu yazınız 
-- Bu tabloya id'si 3 notu 75 olan kayıdı ekleyen sorguyu yazınız 
-- Bu tabloya id'si 4 notu 95 olan kayıdı ekleyen sorguyu yazınız 
-- Bu tabloya id'si 5 notu 60 olan kayıdı ekleyen sorguyu yazınız 
-- Bu tabloya id'si 6 notu 40 olan kayıdı ekleyen sorguyu yazınız 
-- Bu tabloya id'si 7 notu null olan kayıdı ekleyen sorguyu yazınız 

-- INSERT INTO notlar VALUES(2,80), (3,75), (4,95), (5,60),(6,40)
-- INSERT INTO notlar VALUES(7, null), (8, null)

-- 6) Notlar tablosundaki öğrencilerin id ve harfNotlarini gösteren sorgu yazınız
-- not < 50  --> F
-- not < 70  --> C
-- not < 85  --> B
-- not >=85  --> A

/*SELECT id, 
(case
	WHEN nott is null THEN null
	WHEN nott < 50 THEN 'F'
    WHEN nott < 70 THEN 'C'
    WHEN nott < 85 THEN 'B'
    ELSE 'A'
    END) as harf
FROM notlar*/

-- 7) Not değeri null olan kaydı silen sorguyu yazınız
-- DELETE FROM notlar WHERE id IN (SELECT id FROM notlar WHERE nott is null)
 
-- 8) Her harf notundan kaç öğrenci olduğunu gösteren sorguyu yazınız

/*WITH harfNotuTablosu(id, harfNotu) AS (
SELECT id,
(case
	WHEN nott is null THEN null
	WHEN nott < 50 THEN 'F'
    WHEN nott < 70 THEN 'C'
    WHEN nott < 85 THEN 'B'
    ELSE 'A'
    END) as harf
FROM notlar)
SELECT harfNotu, COUNT(id)
FROM harfNotuTablosu
GROUP BY harfNotu*/
