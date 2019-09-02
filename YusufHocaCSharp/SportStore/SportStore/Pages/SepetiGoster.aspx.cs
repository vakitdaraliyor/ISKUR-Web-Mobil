using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SportStore.Model;
using SportStore.Model.Repository;

namespace SportStore.Pages
{
    public partial class SepetiGoster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Repository repository = new Repository();

                int silinecekUrunRefno = Convert.ToInt32(Request.Form["sil"]);
                // int.TryParse(Request.Form["ekle"], out seciliUrunREFNO);

                Sepet sepetim = (Sepet)Session["sepet"];
                if (sepetim == null)
                {
                    sepetim = new Sepet();
                }

                Product silinecekUrun = repository.Products.Where(p => p.PRODUCT_REFNO == silinecekUrunRefno).FirstOrDefault();
                if (silinecekUrun !=  null)
                {
                    sepetim.SepettenSil(silinecekUrun);
                    Session["sepet"] = sepetim;
                }
            }
        }

        public IEnumerable<SportStore.Model.SepetElemani> SepetElemanlariniGetir()
        {
            Sepet sepetim = (Sepet)Session["sepet"];
            if (sepetim == null)
            {
                sepetim = new Sepet();
            }
            return sepetim.BenimSepetim;
        }

        public decimal SepetToplami {
            get
            {
                Sepet sepetim = (Sepet)Session["sepet"];
                if (sepetim == null)
                {
                    sepetim = new Sepet();
                }
                return sepetim.SepetToplaminiHesapla();
            }
        }
    }
}