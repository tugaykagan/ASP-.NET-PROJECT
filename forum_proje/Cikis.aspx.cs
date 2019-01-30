using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

public partial class Cikis : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Kimlik"] == null)
        {
            Response.Redirect("Anasayfa.aspx");
            MessageBox.Show("Önce Giriş Yapmalısınız!");
            return;
        }
        Session["Kimlik"] = null;
        Response.Redirect("Anasayfa.aspx");
    }
}