using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

public partial class Giris : System.Web.UI.Page
{
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
        string sql = "select * from kullanicilar where kullanici='" + TextBox1.Text + "'  and  sifre ='" + TextBox2.Text + "' ";
        db clsdb = new db();
        var okuyucu = clsdb.okuma(sql);
        if (okuyucu.HasRows)
        {
            okuyucu.Read();
            Session["Kimlik"] = okuyucu["Kimlik"].ToString();
            Response.Redirect("Anasayfa.aspx");
        }
        else
        {
            MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
        }
    }
}