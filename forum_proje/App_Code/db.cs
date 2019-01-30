using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;

/// <summary>
/// Summary description for db
/// </summary>
public class db
{
    OleDbConnection con = new OleDbConnection();
    public db()
    {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source
            =" + System.Web.HttpContext.Current.Server.MapPath("forum.accdb");
            con.Open();
        }

        public void calistir(string sql)
        {
            OleDbCommand komut = new OleDbCommand(sql, con);
            komut.ExecuteNonQuery();

            con.Close();
        }

        public OleDbDataReader okuma(string sql)
        {
            OleDbCommand komut = new OleDbCommand(sql, con);
            var okuyucu = komut.ExecuteReader();
            return okuyucu;
        }

        public bool yetki_kontrol(string sayfa)
        {
            if (!SessionKontrol())
                return false;
            string kimlik = GetKimlikSession();
            string sql = "select * from yetkiler inner join kullanicilar on yetkiler.rol=kullanicilar.rol where kullanicilar.Kimlik=" + kimlik + " and yetkiler.yetki='" + sayfa + "' ";

            var okuyucu = okuma(sql);
            if (okuyucu.HasRows)
                return true;
            else
                return false;
        }

        public bool SessionKontrol()
        {
            var currentSession = HttpContext.Current.Session;
            if (currentSession["Kimlik"] == null)
                return false;
            else
                return true;
        }

        public string GetKimlikSession()
        {
            var currentSession = HttpContext.Current.Session;
            string Kimlik = currentSession["Kimlik"].ToString();
            return Kimlik;
        }


    
}
