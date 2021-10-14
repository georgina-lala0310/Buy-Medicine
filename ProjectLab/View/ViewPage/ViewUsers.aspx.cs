using ProjectLab.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectLab.View.ViewPage
{
    public partial class ViewUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gvUsers.DataSource = UserHandler.GetAllMember();
                gvUsers.DataBind();
            }
            
        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            var id = (sender as Button).CommandArgument;
            UserHandler.DeleteMember(int.Parse(id));
            Response.Redirect("~/View/ViewPage/ViewUsers.aspx");
        }

        protected void gvUsers_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[4].Visible = false;
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Home/HomePage.aspx");
        }
    }
}