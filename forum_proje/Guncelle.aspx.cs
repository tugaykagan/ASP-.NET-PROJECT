using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

public partial class Guncelle : System.Web.UI.Page
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


        if (!IsPostBack)
        {
            string id = Request.QueryString["id"].ToString();
            string sql = "select * from  konular where Kimlik= " + id ;
            var okuyucu = clsdb.okuma(sql);
            okuyucu.Read();
            TextBox1.Text = okuyucu["baslik"].ToString();
            TextArea1.Value = okuyucu["konu"].ToString();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"].ToString();
        string sql = @"update konular set baslik='" + TextBox1.Text + "',  konu = '" + TextArea1.Value.ToString() + "'  where Kimlik=" + id;
        clsdb.calistir(sql);
        MessageBox.Show("Güncelleme Gerçekleştirildi!");
        Response.Redirect("Anasayfa.aspx");
    }
}