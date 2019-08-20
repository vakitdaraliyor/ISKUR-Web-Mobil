using System;

namespace Interface
{

    // Interface(Arayuz)
    // Interface bir referance tipidir
    // Bir ya da birden fazla fonksiyon tanimlarfakat fonksiyonlari gelistirmez
    // Bu fonksiyonlari interfce i implemente eden classlar doldurur
    // Interface te degisken ve static yapilar bulunamaz
    // Interface te erişilebilirlik etiketleri(public, private) kullanilmaz
    // Interface te fonksiyonlar, properties, event yapilari bulunabilir   

    // Bir class birden fazla class inherit edemezken
    // Birden fazla Interface i Implement edebilir

    // Eger bir class hem inheritance hem de interface ozelliklerini kullaniyorsa
    // : sonraki kisimda oncelikle base class ismi daha sonra interface isimleri yazilmalidir

    interface IInfo
    {
        string GetName();
        int GetAge();
    }
    class cA : IInfo
    {
        public string name;
        public int age;
        public string GetName() { return name; }
        public int GetAge() { return age; }
    }

    class cB : IInfo
    {
        public string FirstName;
        public string LastName;
        public int PersonAge;
        public string GetName() { return FirstName; }
        public int GetAge() { return PersonAge; }
    }

    class MyData : IComparable
    {
        public int number;

        // Eger kendi objesinin degeri parametre olarak gelen objenin degerinden
        // kucukse negatif
        // buyukse pozitif 
        // esitlik varsa 0 deger doner
        public int CompareTo(object obj)
        {
            MyData mObj = (MyData)obj;
            if (this.number < mObj.number) return -1;
            if (this.number > mObj.number) return 1;
            return 0;
        }
    }

    interface IDataStore
    {
        void SetData(int x);
        void PrintOut(string s);
    }

    interface IRetreiveData
    {
        int GetData();
        void PrintOut(string s);
    }

    // Interface diger interface leri inherit edebilir
    interface IDataIO : IRetreiveData, IDataStore
    {

    }

    class MyClass: IRetreiveData, IDataStore
    {
        public int number;

        public void PrintOut(string s)
        {
            Console.WriteLine(s);
        }

        public void SetData(int x)
        {
            number = x;
        }

        public int GetData()
        {
            return number;
        }
    }

    class Program
    {
        public static void PrintInfo(IInfo obj)
        {
            Console.WriteLine("Name: " + obj.GetName() + " Age: " + obj.GetAge());
        }

        static void Main(string[] args)
        {
            IInfo aObj = new cA() { name = "Osman", age = 26};
            IInfo bObj = new cB() { FirstName = "Ramazan", PersonAge = 22};
            PrintInfo(aObj);
            PrintInfo(bObj);

            int[] myArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            foreach(int item in myArr)
            {
                Console.WriteLine(item);
            }

            MyData[] newArr = new MyData[10];
            for (int i = 0; i < 10; i++)
            {
                newArr[i] = new MyData();
                newArr[i].number = myArr[i];
            }

            Array.Sort(newArr);
            Console.WriteLine("Siralanmis hali");
            foreach (MyData item in newArr)
            {
                Console.WriteLine(item.number);
            }

            MyClass mc = new MyClass();
            mc.SetData(5);
            mc.PrintOut("Hellooooo!");

            IRetreiveData interfaceObj = (IRetreiveData)mc;
            interfaceObj.PrintOut("Interface fonksiyonu");

            IDataIO i2 = mc as IDataIO;
            if (i2 == null)
            {
                Console.WriteLine("Boş");
            }
        }
    }
}
