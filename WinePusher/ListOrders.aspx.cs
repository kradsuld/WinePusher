using System;
using System.Data;
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

            gvOrdersList.Columns[6].Visible = false;
            gvOrdersList.Columns[7].Visible = false;
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
        protected void gvOrdersList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            string delivered = e.Row.Cells[6].Text;
            string paid = e.Row.Cells[7].Text;

            Image imgDelivered = (Image)e.Row.FindControl("ImgDelivered");
            if (imgDelivered == null)
            {
                return;
            }
            if (delivered == "Y")
            {
                imgDelivered.ImageUrl = "~/Images/check.png";
            }
            else if (delivered == "N")
            {
                imgDelivered.ImageUrl = "~/Images/no.png";
            }
            else
            {
                //default static image
                imgDelivered.ImageUrl = "~/Images/c.jpg";
            }

            Image imgPaid = (Image)e.Row.FindControl("ImgPaid");
            if (imgPaid == null)
            {
                return;
            }
            if (paid == "Y")
            {
                imgPaid.ImageUrl = "~/Images/check.png";
            }
            else if (paid == "N")
            {
                imgPaid.ImageUrl = "~/Images/no.png";
            }
            else
            {
                //default static image
                imgPaid.ImageUrl = "~/Images/c.jpg";
            }

            //e.Row.Cells[6].Visible = false;
            //e.Row.Cells[7].Visible = false;
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