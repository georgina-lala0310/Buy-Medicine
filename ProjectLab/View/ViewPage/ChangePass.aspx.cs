using ProjectLab.Controller;
using ProjectLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectLab.View.ViewPage
{
    public partial class ChangePass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            User u = (User)Session["User"];
            lblMsg.Text = UserController.ChangePass(u, txtOld.Text, txtNew.Text,
                txtConf.Text);
        }
    }
}