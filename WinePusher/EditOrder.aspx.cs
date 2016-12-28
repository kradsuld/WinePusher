using System;
using WinePusher.BusinessLogic;
using WinePusher.Models;

namespace WinePusher
{
    public partial class EditOrder : System.Web.UI.Page
    {
        private int _roundId;
        private decimal _winePrice;

        protected void Page_Load(object sender, EventArgs e)
        {
                var orderId = Request.QueryString["OrderId"];

                OrderHandler oh = new OrderHandler();
                Order order = oh.GetOrder(Convert.ToInt32(orderId));

                _roundId = order.RoundId;
                _winePrice = order.WinePrice;

            if (!IsPostBack)
            {
                lbloMemberName.Text = order.MemberName;
                lbloOrderAmount.Text = order.OrderAmount.ToString();
                lbloOrderDate.Text = order.OrderDate.ToString();
                lbloWineName.Text = order.WineName;
                lbloWinePrice.Text = order.WinePrice.ToString();
                lbloWineType.Text = order.WineType;
                ddBottles.SelectedValue = order.Bottles.ToString();
                ddDeliveredMark.SelectedValue = order.Delivered;
                ddPaidMark.SelectedValue = order.Paid;
            }
        }

        protected void btnSaveOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListOrders.aspx?RoundId=" + _roundId);
        }
        protected void btnDeleteOrder_Click(object sender, EventArgs e)
        {

        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListOrders.aspx?RoundId=" + _roundId);
        }
        protected void ddBottles_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbloOrderAmount.Text = (Convert.ToDecimal(ddBottles.SelectedValue) * _winePrice).ToString();
        }
    }
}