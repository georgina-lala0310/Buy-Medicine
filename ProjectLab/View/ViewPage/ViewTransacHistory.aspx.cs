using ProjectLab.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectLab.View.ViewPage
{
    public partial class ViewTransacHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvTransacHistory.DataSource = TransactionHandler.showTransacHis(UserHandler.getUserId());
            gvTransacHistory.DataBind();
        }

        protected void gvTransacHistory_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            int total=0;
            for(int a = 0; a < gvTransacHistory.Rows.Count; a++)
            {
                total += int.Parse(gvTransacHistory.Rows[a].Cells[3].Text);
            }
            lblGrand.Text = total.ToString();
        }
    }
}