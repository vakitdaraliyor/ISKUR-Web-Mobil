using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SOAPWebService
{
    /// <summary>
    /// OrnekService için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
    // [System.Web.Script.Services.ScriptService]
    public class OrnekService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Merhaba Dünya";
        }

        [WebMethod]
        public string HelloWorldGüvenlik(string prm1, string prm2, string prm3)
        {
            if (CheckUser(prm1, prm2, prm3) == false) return null;
            return "Merhaba";
            
        }

        [WebMethod]
        public int Topla(int s1, int s2, string prm1, string prm2, string prm3)
        {
            return s1 + s2;
        } 

        bool CheckUser(string prm1, string prm2, string prm3)
        {
            if (prm1 == "sa" && prm2 == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
