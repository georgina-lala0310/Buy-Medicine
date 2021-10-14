using ProjectLab.Controller;
using ProjectLab.Handler;
using ProjectLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectLab.View.Home
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack){
                if(Session["User"] == null)
                {
                    Response.Redirect("~/View/Login/LoginGuest.aspx");
                }

                gvMed.DataSource = MedicineHandler.randomMed();
                gvMed.DataBind();

                User u = (User)Session["User"];
                if(u.RoleId == 1)
                {
                    btnCart.Visible = true;
                    btnTransacHistory.Visible = true;
                    gvMed.Visible = true;
                
                }
                else if (u.RoleId == 2)
                {
                    btnInsertMed.Visible = true;
                    btnViewUsers.Visible = true;
                    btnViewTransacReport.Visible = true;
                    gvMed.Visible = false;
                }
            }
            
        }

        protected void btnViewMedicine_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewPage/ViewMedicine.aspx");
        }

        protected void btnProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewPage/ViewProfile.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            UserController.Logout();
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewPage/ViewCart.aspx");
        }

        protected void btnTransacHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewPage/ViewTransacHistory.aspx");
        }

        protected void btnInsertMed_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewPage/InsertMedicine.aspx");
        }

        protected void btnViewUsers_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewPage/ViewUsers.aspx");
        }

        protected void btnViewTransacReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewPage/ReportPage.aspx");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            
            var id = (sender as Button).CommandArgument;
            Response.Redirect("/View/ViewPage/AddToCart.aspx?id=" + id);
        }

        protected void gvMed_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[1].Visible = false;
        }
    }
}