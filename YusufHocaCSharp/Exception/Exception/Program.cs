using System;
using System.Net.Http;

namespace ExceptionDeneme
{

    // Exception: Exception bir run time hatasidir. Programimizin calismasini durdurur.
    // Sifira bolum bir mantik(run time hatasidir)

    // Exception Handling: Exception ile karsilasirsa yapilabilecekler
    // 1. Eger duzeltilebilecek aksiyonlar (corrective actions) varsa isleme alinir
    // 2. Duzeltilemeyecek bir hata varsa bu hatayi loglayip(kayit altina alinip)
    //    gelistirici takima hata kaydi bilgileri verilip hatalarin giderilmesi istenebilir.
    // 3. Kaynaklari temizleme yoluna gidilebilir.(orn: Hatadan once bir veritabani baglantisi olusturduk
    //                                             daha sonra hata alindi ve program coktu)
    //    Bu baglantinin program kapanmadan kaldirilmasi saglanabilir.
    // 4. Kullaniciya bir uyarı mesaji verilip programin cokmeden kapatilmasi saglanabilir.
    // Genellikle hatalar programimizi bilinmeyen veya kararli olmayan durumlara surukleyebilecegi icin programin hatadan sonra calismasi cok tavsiye edilmez.

    class Program
    {
        static void Main(string[] args)
        {

            // test edilecek kod blogu try icine yazilir
            try
            {
                int x = 3;
                int y = 0;

                if(args != null)
                {
                    // Kendi hatamizi olusuturp firlatabiliriz.
                    ArgumentNullException ex = new ArgumentNullException();
                    throw ex;
                }

                // int z = x / y;
            }
            // Bu catch blogu sadece 0' a bolme hatasi yakalar
            catch(DivideByZeroException obj)
            {
                Console.WriteLine("Sifira bolme hatasi olustu!");
                Console.WriteLine("Mesaj: {0}", obj.Message);
                Console.WriteLine("Source: {0}", obj.Source);
                Console.WriteLine("Stack: {0}", obj.StackTrace);
            }
            // Bu catch blogu da yukarida yazilmis olan catch blogu 
            // haricindeki tum hatalar icin calisan catch blogudur
            catch(HttpRequestException e) when (e.Message.Contains("404"))
            {
                Console.WriteLine("404 Not Found!");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                // Butun hatalari yakalayan exception class i
            }
            // Finally blogu icerisinde kodlar her kosulda calisacak kodlardır.
            // (Hata olussa da olusmasa da bu kod blogu calisir)
            finally
            {

            }

            Console.ReadKey();
        }
    }
}
