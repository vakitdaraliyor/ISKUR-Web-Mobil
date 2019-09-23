using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SOADHEADERWS
{
    /// <summary>
    /// WebService1 için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        Model1 db = new Model1();

        [WebMethod]
        public string HelloWorld()
        {
            return "Merhaba Dünya";
        }

        [WebMethod]
        public List<URUN> GetAllUruns(){
            return db.URUNs.ToList();
        }

    }
}
