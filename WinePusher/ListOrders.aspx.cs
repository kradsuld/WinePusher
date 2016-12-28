using System;
using System.Web.UI.WebControls;
using WinePusher.BusinessLogic;

namespace WinePusher
{
    public partial class ListOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var roundId = Request.QueryString["RoundId"];

            OrderHandler oh = new OrderHandler();
            gvOrdersList.DataSource = oh.ListOrders(Convert.ToInt32(roundId));
            gvOrdersList.DataBind();
        }
        protected void gvOrdersList_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "editOrder")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                int orderId = Convert.ToInt32(gvOrdersList.DataKeys[index].Value);
                Response.Redirect("EditOrder.aspx?OrderId=" + orderId);
            }
       }
      protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("WinePusher.aspx");
        }
    }
}