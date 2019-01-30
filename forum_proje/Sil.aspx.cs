using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

public partial class Sil : System.Web.UI.Page
{
    db clsdb = new db();
    string sl;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Kimlik"] == null)
        {
            MessageBox.Show("giriş yapmalısınız");
            return;
        }

        if (Request.QueryString["id"] == null)
        {
            Response.Write("id değeri gerekli");
            return;
        }


        string Kimlik = Request.QueryString["id"].ToString();
        string sql = "delete from konular where Kimlik="+ Kimlik;
        clsdb.calistir(sql);
        Response.Redirect("Anasayfa.aspx");

    }
}