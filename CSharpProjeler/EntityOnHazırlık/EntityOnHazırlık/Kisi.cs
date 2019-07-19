using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityOnHazırlık
{
    class Kisi
    {
        private string adi;       

        public void SetAdi(string value)
        {
            if(value.Length > 30)
            {
                adi = value.Substring(0,30);
            }
            else
            {
                adi = value;
            }
        }

        public string GetAdi()
        {
            return adi;
        }

        private string soyadi;

        public string Soyadi
        {
            get { return soyadi; }
            set
            {
                if(value.Length > 30)
                {
                    soyadi = value.Substring(0, 30);
                }
                else
                {
                    soyadi = value;
                }
            }
        }

    }
}
