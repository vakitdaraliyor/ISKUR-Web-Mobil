using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFSERVISI1
{
    // NOT: "ServiceBlog" sınıf adını kodda, svc'de ve yapılandırma dosyasında birlikte değiştirmek için "Yeniden Düzenle" menüsündeki "Yeniden Adlandır" komutunu kullanabilirsiniz.
    // NOT: Bu hizmeti test etmek üzere WCF Test İstemcisi'ni başlatmak için lütfen Çözüm Gezgini'nde ServiceBlog.svc veya ServiceBlog.svc.cs öğesini seçin ve hata ayıklamaya başlayın.
    public class ServiceBlog : IServiceBlog
    {
        Model1 db = new Model1();
        public List<Kategori> GetAllKATEGORI() // interface teki methodu implement ettik
        {
            var liste = db.KATEGORIs.ToList();
            var listegonder = new List<Kategori>(); // gönderilecek liste
            for (int i = 0; i < liste.Count; i++)
            {
                Kategori k = new Kategori();
                k.KATEGORI_ADI = liste[i].KATEGORI_ADI;
                k.KATEGORI_REFNO = liste[i].KATEGORI_REFNO;
                listegonder.Add(k);
            }
            return listegonder;
        }
    }
}
