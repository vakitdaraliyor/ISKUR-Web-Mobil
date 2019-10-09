using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Rapor
{
    interface IRapor
    {
        string RaporAdi { set; get; }
        string RaporYolu { set; get; }
        DataTable Veri { set; get; }
        void Olustur();
    }

    class ExcelRapor : IRapor
    {
        public string RaporAdi { get; set; }
        public string RaporYolu { get; set; }
        public DataTable Veri { get; set; }

        public void Olustur()
        {
            StreamWriter sw = new StreamWriter(RaporYolu + "/" + RaporAdi, false, Encoding.UTF8);
            string satir = "";
            for (int i = 0; i < Veri.Rows.Count; i++)
            {
                satir = "";
                for (int j = 0; j < Veri.Columns.Count; j++)
                {
                    satir = satir + Veri.Rows[i][j].ToString();
                    if ( j != Veri.Columns.Count-1)
                    {
                        satir = satir + ";";
                    }
                }
                sw.WriteLine(satir);
            }
            sw.Close();
            Console.WriteLine("Excel rapor olustu.");
        }
    }

    class PdfRapor : IRapor
    {
        public string RaporAdi { get; set; }
        public string RaporYolu { get; set; }
        public DataTable Veri { get; set; }
        public void Olustur()
        {
            Console.WriteLine("Pdf rapor olustur");
        }
    }

    enum ERaportType{
        Excel, PDF
    }

    class RaportFactory
    {
        public IRapor GetRapor(ERaportType raportType)
        {
            switch (raportType)
            {
                case ERaportType.Excel:
                    return new ExcelRapor();
                case ERaportType.PDF:
                    return new ExcelRapor();
                default:
                    return null;
            }
        }
    }

}
