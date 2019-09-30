using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOT: "IWSKategori" arabirim adını kodda ve yapılandırma dosyasında birlikte değiştirmek için "Yeniden Düzenle" menüsündeki "Yeniden Adlandır" komutunu kullanabilirsiniz.

[ServiceContract]
public interface IWSKategori
{
    [OperationContract]
    List<Kategori> GetAllKATEGORI();

    [OperationContract]
    Kategori GetKATEGORI(int id);

    [OperationContract]
    void Save(Kategori kategori);

    [OperationContract]
    void Update(Kategori kategori);

    [OperationContract]
    void Delete(int id); 
}

[DataContract]
public class Kategori
{
    [DataMember]
    public int KATEGORI_REFNO { get; set; }
    [DataMember]
    public string KATEGORI_ADI { get; set; }
}