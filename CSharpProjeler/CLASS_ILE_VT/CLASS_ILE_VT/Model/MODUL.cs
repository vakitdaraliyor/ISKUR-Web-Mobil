using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO.Net;

namespace CLASS_ILE_VT.Model
{
    class MODUL
    {
        DBClass db = new DBClass();
        public int MODUL_REFNO { get; set; }
        public string MODUL_ADI { get; set; }

        public void Load(int REFNO)
        {
            MODUL_REFNO = REFNO;
            if (MODUL_REFNO > 0)
            {
                string sql = "SELECT * FROM MODUL WHERE MODUL_REFNO=@MODUL_REFNO";
                SqlParameter prm1 = new SqlParameter("MODUL_REFNO", MODUL_REFNO);
                DataTable dt = db.TableGetir(sql,false, prm1);

                if(dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["MODUL_REFNO"] != DBNull.Value) MODUL_REFNO = Convert.ToInt32(dt.Rows[0]["MODUL_REFNO"]);
                    if (dt.Rows[0]["MODUL_ADI"] != DBNull.Value) MODUL_ADI = Convert.ToString(dt.Rows[0]["MODUL_ADI"]);
                }                
            }
        }

        public void Insert()
        {
            string sql = "INSERT INTO MODUL(MODUL_ADI) VALUES(@MODUL_ADI)";
            SqlParameter prm1 = new SqlParameter("@MODUL_ADI", MODUL_ADI);
            db.SqlCalistir(sql, prm1);
        }

        public void Update()
        {
            string sql = "UPDATE MODUL SET MODUL_ADI = @MODUL_ADI WHERE MODUL_REFNO = @MODUL_REFNO";
            SqlParameter prm1 = new SqlParameter("@MODUL_ADI", MODUL_ADI);
            SqlParameter prm2 = new SqlParameter("@MODUL_REFNO", MODUL_REFNO);
            db.SqlCalistir(sql, prm1, prm2);
        }

        public void Delete()
        {
            string sql = "DELETE FROM MODUL WHERE MODUL_REFNO = @MODUL_REFNO";
            SqlParameter prm1 = new SqlParameter("@MODUL_REFNO", MODUL_REFNO);
            db.SqlCalistir(sql, prm1);
        }

        public static List<MODUL> Load()
        {
            List<MODUL> liste = new List<MODUL>();

            string sql = "SELECT * FROM MODUL";
            DBClass db = new DBClass();
            DataTable dt = db.TableGetir(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MODUL m = new MODUL();
                m.Load(Convert.ToInt32(dt.Rows[i]["MODUL_REFNO"]));
                liste.Add(m);
            }
            return liste;
        }


    }
}
