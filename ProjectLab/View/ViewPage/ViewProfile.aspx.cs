using ProjectLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectLab.View.ViewPage
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User u = (User)Session["User"];
            lblUsername.Text = u.Username;
            lblName.Text = u.Name;
            lblGender.Text = u.Gender;
            lblPhone.Text = u.PhoneNumber.ToString();
            lblAddress.Text = u.Address;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewPage/UpdateProfile.aspx");
        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewPage/ChangePass.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Home/HomePage.aspx");
        }
    }
}