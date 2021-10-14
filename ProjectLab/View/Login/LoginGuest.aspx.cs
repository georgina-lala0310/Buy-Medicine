using ProjectLab.Controller;
using System;
using System.Web;

namespace ProjectLab.View
{
    public partial class LoginGuest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie req = Request.Cookies["userLogin"];
            if (req != null)
            {
                txtUsername.Text = Request.Cookies["userLogin"]["Username"];
                txtPassword.Text = Request.Cookies["userLogin"]["Password"];
            }
        }

        protected void btnLoginGuest_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool remember;

            if (chRemember.Checked == true)
            {
                remember = true;

            }
            else
            {
                remember = false;
            }

            lblMessage.Text = UserController.Login(username, password, remember);
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Login/Register.aspx");
        }
    }
}