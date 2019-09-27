using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFSERVISI1
{
    // NOT: "IServiceBlog" arabirim adını kodda ve yapılandırma dosyasında birlikte değiştirmek için "Yeniden Düzenle" menüsündeki "Yeniden Adlandır" komutunu kullanabilirsiniz.
    [ServiceContract]
    public interface IServiceBlog
    {
        [OperationContract]
        List<Kategori> GetAllKATEGORI();
    }

    [DataContract]
    public class Kategori
    {
        [DataMember]
        public int KATEGORI_REFNO;
        [DataMember]
        public string KATEGORI_ADI;
    }
}
