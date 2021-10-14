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
    public partial class ViewCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gvCart.DataSource = CartHandler.ShowCart(); 
                gvCart.DataBind();
            }
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
                var id = (sender as Button).CommandArgument;
                CartHandler.RemoveItem(int.Parse(id));
                Response.Redirect("~/View/ViewPage/ViewCart.aspx");
            
        }

        protected void gvCart_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[1].Visible = false;

            int total = 0;
            for(int a = 0; a < gvCart.Rows.Count; a++)
            {
                total += int.Parse(gvCart.Rows[a].Cells[5].Text);
            }
            lblGrand.Text = total.ToString();
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            User u = (User)Session["User"];
            bool header = TransactionHandler.CreateHeaderTransac(u.UserId);
            bool detail = TransactionHandler.CreateDetailTransac(CartHandler.GetAllData());
            if(header == true && detail == true)
            {
                lblMsg.Text = "Checkout succeed\r\n";
                MedicineHandler.minusStock(CartHandler.GetAllData());
                CartHandler.RemoveCart();
                Response.Redirect("~/View/Home/HomePage.aspx");
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Home/HomePage.aspx");
        }
    }
}