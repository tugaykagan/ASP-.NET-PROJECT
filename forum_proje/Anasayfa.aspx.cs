using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

public partial class Anasayfa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        db clsdb = new db();
        if (Session["Kimlik"] == null)
        {
            // Response.Write("Giriş yapmalısınız!");
            MessageBox.Show("Giriş Yapmalısınız!");
            Label2.Visible = false;
            Label1.Text = "";
            return;
        }

        string id = Session["Kimlik"].ToString();
        Label2.Text = "<a href='YeniKonu.aspx?id=" + id + "'>Yeni Konu</a>";


        string sql = "select * from  konular";

        var okuyucu = clsdb.okuma(sql);
        Label1.Text = "</br><table border=1 cellpadding=1 cellspacing=1>";

        while (okuyucu.Read())
        {
            Label1.Text += "<tr>";
            Label1.Text += "<td>" + okuyucu["baslik"].ToString() + "</td>";
            Label1.Text += "<td>" + okuyucu["kullanici"].ToString() + "</td>";
            Label1.Text += "<td>" + okuyucu["tarih"].ToString() + "</td>";
            Label1.Text += "<td> <a href='Konu.aspx?id=" + okuyucu["Kimlik"].ToString() + "'>Konuya Gir</a> </td>";
            if (clsdb.yetki_kontrol("sil"))
            {
                Label1.Text += "<td> <a href='Sil.aspx?id=" + okuyucu["Kimlik"].ToString() + "'>Sil</a> </td>";
            }
            if (clsdb.yetki_kontrol("guncelle"))
            {
                Label1.Text += "<td> <a href='Guncelle.aspx?id=" + okuyucu["Kimlik"].ToString() + "'>Güncelle</a> </td>";
            }
                Label1.Text += "</tr>";
        }
        Label1.Text += "</table>";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}