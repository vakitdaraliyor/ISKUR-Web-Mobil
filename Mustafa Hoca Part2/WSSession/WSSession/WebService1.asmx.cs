using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WSSession
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

        [WebMethod(EnableSession = true)]
        public bool Giris(string kullanici, string parola)
        {
            if (kullanici == "sa" && parola == "123")
            {
                Session["GIRIS"] = true;
                return true;
            }
            else
            {
                Session["GIRIS"] = false;
                return false;
            }
        }

        [WebMethod(EnableSession = true)]
        public List<string> ListeGetir()
        {
            if (Session["GIRIS"] == null)
            {
                return null;
            }
            else
            {
                if (Convert.ToBoolean(Session["GIRIS"]) == false) return null;
            }
            List<string> liste = new List<string>()
            {
                "mustafa", "ali", "kazım", "ramazan", "osman"
            };
            return liste;
        }
    }
}
