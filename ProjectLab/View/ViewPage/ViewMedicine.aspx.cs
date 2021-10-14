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
    public partial class ViewMedicine : System.Web.UI.Page
    {
        static bool searchClicked = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (searchClicked == false)
                {
                    gvMed.DataSource = MedicineHandler.GetAllMed();
                    gvMed.DataBind();

                }

                User u = (User)Session["User"];

                if (u.RoleId == 1)
                {
                    gvMed.Columns[1].Visible = false;
                    gvMed.Columns[2].Visible = false;
                    gvMed.Columns[3].Visible = false;

                }
                else if (u.RoleId == 2)
                {
                    gvMed.Columns[0].Visible = false;

                }
            }
            
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            searchClicked = true;
            gvMed.DataSource = MedicineHandler.searchMed(txtSearch.Text);
            gvMed.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var id = (sender as Button).CommandArgument;
            Response.Redirect("~/View/ViewPage/AddToCart.aspx?Id=" + id);
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewPage/InsertMedicine.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            var id = (sender as Button).CommandArgument;
            Response.Redirect("~/View/ViewPage/AddToCart.aspx?Id=" + id);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            var id = (sender as Button).CommandArgument;
            MedicineHandler.DeleteMed(int.Parse(id));
            //fetchData();
            Response.Redirect("~/View/ViewPage/ViewMedicine.aspx");
        }

        protected void gvMed_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[4].Visible = false;
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Home/HomePage.aspx");
        }
    }
}