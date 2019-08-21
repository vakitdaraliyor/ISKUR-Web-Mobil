using System;
using System.Linq;

namespace LinqExample
{

    static class Other
    {
        public static string Name = "Osman";

    }

    public class Student
    {
        public int StudentID;
        public string Name;
    }

    public class CourseStudent
    {
        public int StudentID;
        public string CourseName;
    }
    class Program
    {

        /* LINQ(Language Integrated Query): Dil Tabanli Sorgu
         * Veritabanlarini, XML dosyalarini ya da kendi olusturdugumuz collection ya da arrayleri
         * sorgulamaya yarayan sorgu dilidir.
         * 
         * SQL sorgularina oldukca benzerlik gosterir
         */

        static void Main(string[] args)
        {
            // Anonymous Type
            // Anonym turler local(yerel) degiskendir
            // Herhangi bir class'in uyesi olamazlar
            // Herhangi bir tur belirtmediimiz icin var anahtar kelimsei ile kullanilir
            // Herhangi bir property'de de kullanilamaz


            var student = new { Name = "Ahmet", Age = 19, Major = "Tarih" };
            string major = "Fizik";
            var student2 = new { Other.Name, Age = 19, Major = major };
            Console.WriteLine($"Adı: {student.Name} Yas: {student.Age} Bolum: {student.Major}");
            Console.WriteLine($"Adı: {student2.Name} Yas: {student2.Age} Bolum: {student2.Major}");

            // Array de butun elemanlar ayni yapida olmalidir
            var studentArr = new[]
            {
                new {Name = "Ramazan", Age = 21, Major = "Web"},
                new {Name = "Osman", Age = 26, Major = "Iskur"},
                new {Name = "Soner", Age = 24, Major = "Muhasebe"}
            };

            // LINQ Query Example
            // var query = from (her bir elamana ne ad verdigim)
            //             in (hangi tablodan ya da array den)

            var query = from item in studentArr select item;
            foreach(var i in query)
            {
                Console.WriteLine($"{i.Name}, {i.Age}, {i.Major}");
            }

            // LINQ Sorgularinda 2 cesit sorgu yontemi mevcuttur
            // 2 yontemin performans olarak farkı yoktur
            // Microsoft Query Syntax'ını kullanmayi onerir.
            // Cunku daha anlasilir ve daha az hatayasebep olur.
            // Bazi operatorler sadece fonksiyonel sorgularda kullanilir.
            /*
             * 1. Query(Sorgu) Syntax: SQL sorgularina benzer bir yapisi vardir
             * Tanimlayici bir sorgu bicimidir. Sorgu olusturuldugunda calismaz sadece kaydedilir.
             * Daha sonra sorgunun icerigi gosterilmek istenildiginde sorgu calistirilir
             * 
             * 2. Method(Fonksiyon) Syntax: Sorgulari fonksiyonlar kullanarak yapar
             * Etkilesimli bir sorgu bicimidir. Sorgu olusturuldugunda calistirilir.
             */

            var query2 = (from item in studentArr select item).Count();
            Console.WriteLine(query2);

            /* QUERY SYNTAX
             * 
             * FROM ile baslar (Zorunludur)
             * FROM ... LET ... WHERE (optionel)
             * ORDERBY (optionel)
             * SELECT ... GROUP (zorunlu)
             * sorgu devami INTO (optionel)
             * 
             */

            int[] myArr = { 1, 10, 2, 6, 15 };

            // 8 den buyuk elemanlari gosteren sorguyu yazmak istedigimizde
            var query3 = from item in myArr
                         where item > 8
                         select item;

            foreach(var item in query3)
            {
                Console.WriteLine(item.ToString());
            }

            // -------------------------------------------------------
            //                  JOIN EXAMPLE
            // -------------------------------------------------------
            Student[] sArr = new Student[]
            {
                new Student{Name = "Ramazan", StudentID = 1},
                new Student{Name = "Osman", StudentID = 2},
                new Student{Name = "Mustafa", StudentID = 3}
            };

            CourseStudent[] cArr = new CourseStudent[]
            {
                new CourseStudent{StudentID = 1, CourseName = "Tarih"},
                new CourseStudent{StudentID = 2, CourseName = "Tarih"},
                new CourseStudent{StudentID = 3, CourseName = "Tarih"},
                new CourseStudent{StudentID = 1, CourseName = "Matematik"},
                new CourseStudent{StudentID = 2, CourseName = "Fizik"}
            };

            // Matematik dersini alan ogrencilerin ismini getiren sorgu
            var joinQuery = from s in sArr
                            join c in cArr on s.StudentID equals c.StudentID
                            where c.CourseName == "Matematik"
                            select s.Name;

            foreach(var item in joinQuery)
            {
                Console.WriteLine(item);
            }

            // KARTEZYEN BIRLESTIRME
            var groupA = new[] { 1, 3, 5, 7 };
            var groupB = new[] { 2, 4, 6, 8 };

            var cartesianQuery = from a in groupA
                                 from b in groupB
                                 let sum = a + b
                                 where sum > 10
                                 orderby b descending
                                 select new { a, b, sum };

            foreach(var item in cartesianQuery)
            {
                Console.WriteLine(item.a + " + " + item.b + " = " + item.sum);
            }

            // GROUP BY 
            var groupQuery = from s in studentArr
                             group s by s.Major;

            foreach(var grup in groupQuery)
            {
                Console.WriteLine(grup.Key);
                foreach (var st in grup)
                {
                    Console.WriteLine($"    {st.Name}, {st.Age}");
                }
            }

            // METHOD SYNTAX 
            int[] intArr = {1, 2, 4, 6, 5, 8};
            int total = intArr.Sum();
            int howMany = intArr.Count();

            Console.WriteLine(total + " " + howMany);
            // Where() -> Query syntax taki gibi elemanlari filtrelemeyi saglar
            // Select()
            // Join()
            // OrderBy()
            // Reverse()
            // Distinct()

            // ToArray() -> yapiyi array'e cevirmeyi saglar
            // ToDictionary() -> yapiyi dictionary'e cevirmeyi saglar
            // ToList()

            // First()
            // Last()
            // Min()
            // Max()
            // Sum()
            // Average()
            // Contains()

            // public static int Count<T>(this IEnumarable<T> source,
            //                            Func<T, bool> predicate)

            int oddNumbers = intArr.Count(n => n % 2 == 1);
            Console.WriteLine("Number of Odd Numbers: " + oddNumbers);

            var temp = intArr.Where(n => n > 2);
            foreach (var i in temp)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
