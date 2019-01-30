using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

public partial class Konu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Kimlik"] == null)
        {
            MessageBox.Show("Giriş yapmalısınız!");
            Label1.Visible = false;
            Label2.Visible = false;
            return;
        }

        if (Request.QueryString["id"] == null)
        {
            Response.Write("id değeri gerekli");
            return;
        }

        string id = Request.QueryString["id"].ToString();
        string sql = "select * from  konular where Kimlik= " + id + "";
        db clsdb = new db();
        var okuyucu = clsdb.okuma(sql);
        while (okuyucu.Read())
        {
            Label1.Text = okuyucu["baslik"].ToString();
            Label2.Text = okuyucu["konu"].ToString();
        }

    }
}