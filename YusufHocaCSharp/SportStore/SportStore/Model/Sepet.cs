using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStore.Model
{
    public class Sepet
    {
        private List<SepetElemani> sepetim = new List<SepetElemani>();

        public void SepeteEkle(Product _urun, int sayi)
        {
            // Sepete eklemek istedigimiz urunun daha once sepette olup olmadigini kontrol ediyoruz
            SepetElemani s = sepetim.Where(p => p.urun.PRODUCT_REFNO == _urun.PRODUCT_REFNO).FirstOrDefault();
            if (s == null)
            {
                sepetim.Add(new SepetElemani { adet = sayi, urun = _urun});
            }
            else
            {
                s.adet += sayi;
            }
        }

        public void SepettenSil(Product _urun)
        {
            sepetim.RemoveAll(p => p.urun.PRODUCT_REFNO == _urun.PRODUCT_REFNO);
        }

        public decimal SepetToplaminiHesapla()
        {
            return sepetim.Sum(p => p.urun.PRICE * p.adet);
        }

        public void SepetiTemizle()
        {
            sepetim.Clear();
        }

        public IEnumerable<SepetElemani> BenimSepetim
        {
            get
            {
                return sepetim;
            }
        }

    }

    public class SepetElemani
    {
        public int adet { get; set; }
        public Product urun { get; set; }
    }
}