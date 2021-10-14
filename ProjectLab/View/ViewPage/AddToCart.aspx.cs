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
    public partial class AddToCart : System.Web.UI.Page
    {
        static Medicine m;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    var req = Request.QueryString["id"];
                    m =  MedicineHandler.reqMed(int.Parse(req));
                    lblName.Text = m.Name;
                    lblDesc.Text = m.Description;
                    lblStock.Text = m.Stock.ToString();
                    lblPrice.Text = m.Price.ToString();
                }
                else
                {
                    Response.Redirect("~/View/Home/HomePage.aspx");
                }
            }
            
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string buyItem = txtSum.Text;
            User u = (User)Session["User"];
            lblMessage.Text = CartController.AddToCart(m, buyItem, u.UserId);
        }
    }
}