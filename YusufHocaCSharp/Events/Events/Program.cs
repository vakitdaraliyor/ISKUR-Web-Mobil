using System;

namespace Events
{

    // Event(Olay): Cogu ozelligi delegate yapisina benzer
    // Eventler delegatelerin basitlestirilmis ve ozel bir kullanim alanina sahip versiyonudur

    delegate void Handler();

    class Incrementer
    {
        // event anahtar kelimesi ile tanimlanir
        // Bu event'in delegate turunu belirtiyoruz
        // Bu event'e isim veriyoruz
        public event Handler CountedDozen;

        public void DoCount()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i%12 == 0 && CountedDozen != null)
                {
                    CountedDozen();
                }
            }
        }
    }

    class Dozens
    {
        public int DozensCount { set; get; }

        public Dozens(Incrementer iObj)
        {
            DozensCount = 0;
            iObj.CountedDozen += IncrementDozensCount;
        }

        public void IncrementDozensCount()
        {
            DozensCount++;
        }
    }
    // ----------------------------- Publicsher & Subscriber ----------------------------------
    class Publisher
    {
        public event EventHandler SimpleEvent;
        public void RaiseTheEvent() { SimpleEvent(this, null); }
    }

    class Subscriber
    {
        public int id { get; set; }
        public Subscriber(int id) { this.id = id; }
        public void MethodA(object o, EventArgs e) { Console.WriteLine(id + " AAA"); }
        public void MethodB(object o, EventArgs e) { Console.WriteLine(id + " BBB"); }
    }

    // --------------------------------- System & User (Send notification)------------------------------
    class System
    {
        public event EventHandler<Message> SimpleEvent;
        public void BildirimGonder(string s) {
            Message m = new Message();
            m.message = s;
            if (SimpleEvent != null)
            {
                SimpleEvent(this, m);
            }
        }
    }

    class Message : EventArgs
    {
        public string message { get; set; }
    }

    class User
    {
        public bool durum { get; set; } = true;
        public int id { get; set; }
        public User(int id) { this.id = id; }
        public void BildirimGoster(object o, Message m) { Console.WriteLine("User: " + id + " Message: " + m.message); }

        public void BildirimAcKapa(System sObj) 
        {
            if (durum == true)
            {
                sObj.SimpleEvent += BildirimGoster;
                durum = false;
            }
            else
            {
                sObj.SimpleEvent -= BildirimGoster;
                durum = true;
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {

            Incrementer iObj = new Incrementer();
            Dozens dObj = new Dozens(iObj);

            iObj.DoCount();

            Console.WriteLine("Dozen Count: " + dObj.DozensCount);

            // ----------------------------- Publicsher & Subscriber ----------------------------------

            Publisher pObj = new Publisher();
            Subscriber s1 = new Subscriber(1);
            Subscriber s2 = new Subscriber(2);

            pObj.SimpleEvent += s1.MethodA;
            pObj.SimpleEvent += s2.MethodA;
            pObj.SimpleEvent += s2.MethodB;

            pObj.RaiseTheEvent();

            // --------------------------------- System & User (Send notification)------------------------------

            System sObj = new System();
            User u1 = new User(1);
            User u2 = new User(2);
            u1.BildirimAcKapa(sObj); // Baglanti acik
            u2.BildirimAcKapa(sObj); // Baglanti acik

            // u1.BildirimAcKapa(sObj); // Baglanti kapali
            // u2.BildirimAcKapa(sObj); // Baglanti kapali

            sObj.BildirimGonder("Yarin ders yok");

            Console.ReadKey();
        }
    }
}
