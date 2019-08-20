using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaIfadeler
{
    static class Genel
    {
        public delegate bool DIslem(int sayi);
        public delegate bool DIslem2(int sayi, int ilk, int son);
        public static int DiziIslem(this int[] dizi, DIslem fonksiyon)
        {
        int sonuc = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                int sayi = dizi[i];
                if (fonksiyon(sayi))
                {
                    sonuc = sonuc + sayi;
                }
            }
            return sonuc;
        }

        public static int[] Where1(this int[] dizi, DIslem fonksiyon)
        {
            List<int> sonuc = new List<int>();
            for (int i = 0; i < dizi.Length; i++)
            {
                int sayi = dizi[i];
                if (fonksiyon(sayi))
                {
                    sonuc.Add(sayi);
                }
            }
            return sonuc.ToArray();
        }

        public static int[] Where2(this int[] dizi, DIslem2 fonksiyon, int ilk, int son)
        {
            List<int> sonuc = new List<int>();
            for (int i = 0; i < dizi.Length; i++)
            {
                int sayi = dizi[i];
                if (fonksiyon(sayi, ilk , son))
                {
                    sonuc.Add(sayi);
                }
            }
            return sonuc.ToArray();
        }
    }
}
