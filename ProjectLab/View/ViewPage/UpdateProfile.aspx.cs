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
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            User u = (User)Session["User"];
            string gender = "";
            if (dropGender.SelectedValue == "Male")
            {
                gender = "Male";
            }
            else if (dropGender.SelectedValue == "Female")
            {
                gender = "Female";
            }
            lblMsg.Text = UserController.UpdateProfile(u, txtUsername.Text,
                txtName.Text, gender, txtPhone.Text, txtAddress.Text);
        }

        protected void btnViewProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewPage/ViewProfile.aspx");
        }
    }
}