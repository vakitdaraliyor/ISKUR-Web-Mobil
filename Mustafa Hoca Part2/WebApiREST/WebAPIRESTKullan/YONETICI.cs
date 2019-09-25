using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIRESTKullan
{
    public class YONETICI
    {
        public int YONETICI_REFNO { get; set; }
        public string KULLANICI_ADI { get; set; }
        public string SIFRESI { get; set; }
        public bool DURUMU { get; set; }
    }
}
