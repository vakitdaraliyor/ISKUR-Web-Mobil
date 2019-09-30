using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServisi.Model1;

// NOT: "WSKategori" sınıf adını kodda, svc'de ve yapılandırma dosyasında birlikte değiştirmek için "Yeniden Düzenle" menüsündeki "Yeniden Adlandır" komutunu kullanabilirsiniz.
public class WSKategori : IWSKategori
{
    Model db = new Model();
    public void Delete(int id)
    {
        KATEGORI k = db.KATEGORIs.Find(id);
        if (k != null)
        {
            db.KATEGORIs.Remove(k);
            db.SaveChanges();
        }
    }

    public List<Kategori> GetAllKATEGORI()
    {
        List<KATEGORI> liste = db.KATEGORIs.ToList();
        List<Kategori> listeGonder = new List<Kategori>();

        foreach (var item in liste)
        {
            Kategori k = new Kategori();
            k.KATEGORI_ADI = item.KATEGORI_ADI;
            k.KATEGORI_REFNO = item.KATEGORI_REFNO;
            listeGonder.Add(k);
        }
        return listeGonder;
    }

    public Kategori GetKATEGORI(int id)
    {
        KATEGORI k1 = db.KATEGORIs.Find(id);
        Kategori k2 = new Kategori();
        if (k1 != null)
        {            
            k2.KATEGORI_ADI = k1.KATEGORI_ADI;
            k2.KATEGORI_REFNO = k1.KATEGORI_REFNO;
        }
        else
        {
            k2 = null;
        }
        return k2;
    }

    public void Save(Kategori kategori)
    {
        KATEGORI k = new KATEGORI();
        k.KATEGORI_ADI = kategori.KATEGORI_ADI;
        db.KATEGORIs.Add(k);
        db.SaveChanges();
    }

    public void Update(Kategori kategori)
    {
        KATEGORI k = new KATEGORI();
        k.KATEGORI_ADI = kategori.KATEGORI_ADI;
        k.KATEGORI_REFNO = kategori.KATEGORI_REFNO;
        db.Entry(k).State = System.Data.Entity.EntityState.Modified;
        db.SaveChanges();
    }
}
