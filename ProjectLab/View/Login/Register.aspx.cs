using ProjectLab.Controller;
using ProjectLab.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectLab.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirm = txtConfirm.Text;
            string name = txtName.Text;
            string gender = "";
            string phone="";
            if (dropGender.SelectedValue == "Male")
            {
                gender = "Male";
            }
            else if (dropGender.SelectedValue == "Female")
            {
                gender = "Female";
            }
            if (txtPhone.Text != null)
            {
                phone = txtPhone.Text;
            }
            
            string address = txtAddress.Text;

            lblMessage.Text = UserController.Register(username, password,
                confirm, name, gender, phone, address);
        }
    }
}