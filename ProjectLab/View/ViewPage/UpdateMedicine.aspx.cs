using ProjectLab.Controller;
using ProjectLab.Handler;
using ProjectLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectLab.View.ViewPage
{
    public partial class UpdateMedicine : System.Web.UI.Page
    {
        Medicine m;
        protected void Page_Load(object sender, EventArgs e)
        {
            string req = Request.QueryString["Id"];
            m = MedicineHandler.reqMed(int.Parse(req));
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            lblMsg.Text = MedicineController.UpdateMed(m, txtName.Text, txtDesc.Text,
                txtStock.Text, txtPrice.Text);
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewPage/ViewMedicine.aspx");
        }
    }
}