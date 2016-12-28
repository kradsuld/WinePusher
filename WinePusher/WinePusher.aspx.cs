using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WinePusher.BusinessLogic;

namespace WinePusher
{
    public partial class WinePusher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RoundHandler rh = new RoundHandler();            
            gvRoundsList.DataSource = rh.ListRounds();
            gvRoundsList.DataBind();
        }
        protected void btnCreateRound_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateRound.aspx");
        }

        protected void gvRoundsList_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "addOrder")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                int roundId = Convert.ToInt32(gvRoundsList.DataKeys[index].Value);
                Response.Redirect("CreateOrder.aspx?RoundId=" + roundId);
            }

            if (e.CommandName == "listOrders")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                int roundId = Convert.ToInt32(gvRoundsList.DataKeys[index].Value);
                Response.Redirect("ListOrders.aspx?RoundId=" + roundId);
            }
        }
    }
}