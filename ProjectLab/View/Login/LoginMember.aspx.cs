using ProjectLab.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectLab.View
{
    public partial class LoginMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoginMember_Click(object sender, EventArgs e)
        {
            bool remember = false;
            lblMessage.Text = UserController.Login(txtUsername.Text, txtPassword.Text, remember);
        }
    }
}