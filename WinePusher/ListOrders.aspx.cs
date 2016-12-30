using System;
using System.Web.UI.WebControls;
using WinePusher.BusinessLogic;
using WinePusher.Models;

namespace WinePusher
{
    public partial class ListOrders : System.Web.UI.Page
    {
        private int _roundId;
        protected void Page_Load(object sender, EventArgs e)
        {
            _roundId = Convert.ToInt32(Request.QueryString["RoundId"]);

            RoundHandler rh = new RoundHandler();
            Wine wine = rh.GetRoundWine(_roundId);
            lbloWineName.Text = wine.Name;
            lbloStore.Text = wine.Store;
            lbloPrice.Text = Convert.ToString(wine.Price);

            OrderHandler oh = new OrderHandler();
            gvOrdersList.DataSource = oh.ListActiveOrders(_roundId);
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
            //Response.Redirect(Request.UrlReferrer.ToString());
            Response.Redirect("WinePusher.aspx");
        }
        protected void btnCreateOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateOrder.aspx?RoundId=" + _roundId);
        }
    }
}