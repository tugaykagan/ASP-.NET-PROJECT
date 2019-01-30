using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

public partial class YeniKonu : System.Web.UI.Page
{
    db clsdb = new db();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Kimlik"] == null)
        {
            MessageBox.Show("Giriş yapmalısınız!");
            Button1.Visible = false;
            Label1.Text = "";
            Label2.Text = "";
            TextBox1.Visible = false;
            TextArea1.Visible = false;
            return;
        }
        if (Request.QueryString["id"] == null)
        {
            Response.Write("id değeri gerekli");
            return;
        }
    }

    string kllnc;
    protected void Button1_Click(object sender, EventArgs e)
    {

        string Kimlik = Request.QueryString["id"].ToString();
        string sql2 = "select kullanici from kullanicilar where Kimlik=" + Kimlik + "";
        var okuyucu = clsdb.okuma(sql2);
        while (okuyucu.Read())
        {
            kllnc = okuyucu["kullanici"].ToString();
        }

        string sql = @"insert into konular (baslik,konu,tarih,kullanici) 
            values ('" + TextBox1.Text + "','" + TextArea1.Value.ToString() + "','" + DateTime.Now.ToString() + "', '"+kllnc+"' )";
        clsdb.calistir(sql);
        MessageBox.Show("Konunuz Oluşturuldu!");
        Response.Redirect("Anasayfa.aspx");
    }
}