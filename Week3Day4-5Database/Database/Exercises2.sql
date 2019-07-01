-- Joins
-- Inner join
-- SELECT * FROM course NATURAL INNER JOIN prereq

-- Outer join veri kaybinin önlenmesi
-- course_id ile prereq_id esit olmayan veriler kaybolur
-- SELECT * FROM course, prereq WHERE course.course_id = prereq.prereq_id

-- Left outer join (soldaki tablonun verilerini korur)
-- SELECT * FROM course NATURAL LEFT OUTER JOIN prereq

-- Right outer join (sagdaki tablonun verilerini korur)
-- SELECT * FROM course NATURAL RIGHT OUTER JOIN prereq

-- Full outer join (Iki tablonun da verilerini korur)
-- SELECT * FROM course NATURAL FULL OUTER JOIN prereq

-- Iki sorgu ayni sonucu gosterir
-- SELECT * FROM course, prereq WHERE course.course_id = prereq.prereq_id
-- SELECT * FROM course JOIN prereq ON course.course_id = prereq.prereq_id

-- Views
-- Data yi kullanicidan saklama
-- Tablonun sanal bir versiyonunu olusturuyoruz
-- CREATE VIEW v AS <query expression>
-- sanal olarak faculty tablosu olusturuldu
-- CREATE VIEW faculty AS SELECT ID, name, dept_name FROM instructor
-- faculty tablosunun bilgileri
-- SELECT * FROM faculty
-- UPDATE faculty SET dept_name = 'Computer Science'  WHERE dept_name = 'Comp. Sci.'
-- faculty de eklenen veri instructor tablosuna da eklenir
-- INSERT INTO faculty VALUES ('1900', 'Osman', 'Comp. Sci.')
-- SELECT * FROM instructor

-- CREATE VIEW instructor_info as SELECT ID, name, building FROM instructor, department WHERE instructor.dept_name = department.dept_name
-- INSERT INTO instructor_info VALUES ('69987', 'While', 'Taylor')
-- SELECT * FROM instructor_info
  
-- CONSTRAINTS (Kisitlamalar)
-- INTEGRITY CONSTRAINTS
-- not null
-- primary key (null olamaz)
-- unique (null olabilir)
-- check

-- REFERENTIAL INTEGRITY
-- Tablolarin birbirleri ile ilişkisi (foreign key)
-- on delete cascade => silme islemi yapmak istedigimde,
-- ana tablodan bir veri silersem bu verinin bagli oldugu child tablodaki veriler otomatik silinir
-- SELECT * FROM faculty

 SELECT instructor.ID, name, COUNT(takes.sec_id) AS numberOfSection FROM instructor LEFT OUTER JOIN takes ON instructor.ID = takes.ID GROUP BY instructor.name ORDER BY name ASC