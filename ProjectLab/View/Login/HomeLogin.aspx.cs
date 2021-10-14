using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectLab.View
{
    public partial class LoginGeneral : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Login/LoginMember.aspx");
        }

        protected void btnLoginMember_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Login/LoginMember.aspx");
        }

        protected void btnLoginGuest_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Login/LoginGuest.aspx");
        }
    }
}