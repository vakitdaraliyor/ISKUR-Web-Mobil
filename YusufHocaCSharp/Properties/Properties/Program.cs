using System;

namespace Properties
{

    class Student
    {
        private int id;
        private string name;
        public double gpa { get; set; }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        // Property
        // Degiskenlere benzer olarak bir class uyesidir.
        // Kendine ait bir degisken turu vardır.
        // Deger alabilir ve okunabilir.
        // Degiskenlerden farkli olarak hafizada yer kaplamak zorunda degildir.
        // 
        public string myName
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        
    }

    class DikUcgen
    {
        int a = 3;
        int b = 4;

        public double Hipotenus
        {
            // read only
            get { return Math.Sqrt(a * a + b * b); }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.SetId(3);
            Console.WriteLine("Student Id: " + s1.GetId());

            s1.myName = "Ahmet";
            Console.WriteLine("Student name: " + s1.myName);
            Console.WriteLine("Student name: " + s1.GetName());

            DikUcgen u = new DikUcgen();
            Console.WriteLine("Hipotenus: " + u.Hipotenus);
        }
    }
}
