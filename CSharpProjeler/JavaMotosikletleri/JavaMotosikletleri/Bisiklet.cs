using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaMotosikletleri
{

    interface IBisiklet
    {
        int Vites { get; set; }
        int Guc { get; set; }
        void GucVer();
        void FrenYap();
    }
    class Bisiklet:IBisiklet
    {

        private int _vites;

        public int Vites
        {
            get { return _vites; }
            set {
                if(value > 5)
                {
                    _vites = 5;
                }
                else
                {
                    _vites = value;
                }
            }
        }

        private int _guc;

        public int Guc
        {
            get { return _guc; }
            set {
                if(value > 5)
                {
                    _guc = 5;
                }
                else
                {
                    _guc = value;
                }
            }
        }

        private int _hiz;

        public int Hiz
        {
            get { return _hiz; }
            set {
                if (_hiz > 35)
                {
                    _hiz = 35;
                }
                else
                {
                    _hiz = value;
                }
            }
        }


        public void GucVer()
        {
            Hiz = Convert.ToInt32(Vites * Guc * 1.5F);
        }

        public void FrenYap()
        {
            Hiz = 0;
        }


        public Bisiklet()
        {

        }


    }

    class Motosiklet : Bisiklet
    {
        public delegate void DAsiriSicakOldu(int sicaklik);
        public event DAsiriSicakOldu AsiriSicakOldu; // Click Olayının aynisi
        public bool Durumu = false;
        private int _guc;

        public int Guc
        {
            get { return _guc; }
            set {
                if(value > 10)
                {
                    _guc = 10;
                }
                else
                {
                    _guc = value;
                }
            }
        }

        private int _sicaklik;

        public int Sicaklik
        {
            get { return _sicaklik; }
            set { _sicaklik = value; }
        }

        private int _hiz;

        public int Hiz
        {
            get { return _hiz; }
            set {
                if(value > 120)
                {
                    _hiz = 120;
                }
                else
                {
                    _hiz = value;
                }
            }
        }

        public int DepoKapasite { get; set; }
        public int YakitMiktari { get; set; }

        public void GucVer()
        {
            if (Durumu == false) return; // çalısmiyorsa burasi calismaz
            int _anlikTuketim = 100 + Guc * Vites;
            Hiz = Guc * Vites * 2;
            Sicaklik = Convert.ToInt32(_anlikTuketim / 1.5F);
            if (Sicaklik > 90)
            {
                if(AsiriSicakOldu != null) // Formda bisikletin AsiriSicakOldu olayi içiin method tanımlandıysa
                {
                    AsiriSicakOldu(Sicaklik);
                }                
            }

            if(YakitMiktari > _anlikTuketim)
            {
                YakitMiktari = YakitMiktari - _anlikTuketim;
            }
            else
            {
                YakitMiktari = 0;
                Durumu = false;
            }
        }
    }
}
