using ProjectLab.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectLab.View.ViewPage
{
    public partial class InsertMedicine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            lblMsg.Text = MedicineController.InsertMed(txtName.Text, txtDesc.Text, txtStock.Text,
                txtPrice.Text);
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Home/HomePage.aspx");
        }
    }
}