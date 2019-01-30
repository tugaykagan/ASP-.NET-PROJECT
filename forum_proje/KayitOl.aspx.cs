using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

public partial class KayitOl : System.Web.UI.Page
{
    db clsdb = new db();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Kimlik"] != null)
        {
            Response.Redirect("Anasayfa.aspx");
            MessageBox.Show("Zaten Girmiş Durumdasınız!");
            return;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string sql = @"insert into kullanicilar (kullanici,sifre) 
            values ('" + TextBox1.Text + "','" + TextBox2.Text + "')";
        clsdb.calistir(sql);
        MessageBox.Show("Kayıt Eklendi!");
        Response.Redirect("Giris.aspx?mesaj=ekleme başarılı");
    }
}