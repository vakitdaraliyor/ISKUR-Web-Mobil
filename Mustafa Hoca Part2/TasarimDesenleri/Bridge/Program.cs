using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            MessengerBridge m1 = new MessengerBridge(new SMSSender());
            m1.Send("Son ders");
            MessengerBridge m2 = new MessengerBridge(new MailSender());
            m2.Send("Son ders");

            Console.ReadLine();
        }

        abstract class MessengerBase
        {
            public abstract void Send(string mesaj);
        }

        class MailSender : MessengerBase
        {
            public override void Send(string mesaj)
            {
                Console.WriteLine("Mail Mesaj: " + mesaj);
            }
        }
        class SMSSender : MessengerBase
        {
            public override void Send(string mesaj)
            {
                Console.WriteLine("SMS Mesaj: " + mesaj);
            }
        }

        class MessengerBridge
        {
            MessengerBase _mb;
            public MessengerBridge(MessengerBase m)
            {
                _mb = m;
            }

            public void Send(string mesaj)
            {
                _mb.Send(mesaj);
            }
        }

    }
}
