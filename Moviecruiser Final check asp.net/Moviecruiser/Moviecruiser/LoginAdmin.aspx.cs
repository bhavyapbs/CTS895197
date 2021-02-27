using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Moviecruiser
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnlogin_Click(object sender, EventArgs e)
        {
            if (Txtname.Text == "Bhavya1" && Txtpassword.Text == "bhavya123")
            {
                Session["name"] = Txtname.Text;
                FormsAuthentication.RedirectFromLoginPage(Txtname.Text, true);
                //Response.Redirect("AdminMovieList.aspx");
            }  
            
                    }

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value != "bhavya123")

            {
                args.IsValid = false;
            }
            else
                args.IsValid = true;
            //args.IsValid = (args.Value.Length >= 10);

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            
            if (args.Value != "Bhavya1")

            {
                args.IsValid = false;
            }
            else
                args.IsValid = true;
            //args.IsValid = (args.Value.Length >= 10);

        }
    }
}