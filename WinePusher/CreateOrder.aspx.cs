using System;
using System.Web.UI.WebControls;
using WinePusher.BusinessLogic;
using WinePusher.Models;

namespace WinePusher
{
    public partial class CreateOrder : System.Web.UI.Page
    {
        public CreateOrder()
        {
                
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            var roundId = Request.QueryString["RoundId"];

            lbloWineName.Text = roundId.ToString();

            if (!IsPostBack)
            {
                MemberHandler mh = new MemberHandler();
                ddMembers.DataSource = mh.ListMembers();
                ddMembers.DataBind();

                ddMembers.Items.Insert(0, new ListItem("Vælg medlem", "NA"));
                ddMembers.SelectedIndex = 0;
            }

            RoundHandler rh = new RoundHandler();
            Wine wine = rh.GetRoundWine(Convert.ToInt32(roundId));
            lbloWineName.Text = wine.Name;
            lbloStore.Text = wine.Store;
            lbloPrice.Text = Convert.ToString(wine.Price);           
        }

        protected void btnSaveOrder_Click(object sender, EventArgs e)
        {
            var roundId = Request.QueryString["RoundId"];

            OrderHandler oh = new OrderHandler();
            oh.CreateOrder(Convert.ToInt16(roundId), 
                           Convert.ToInt16(ddMembers.SelectedValue), 
                           Convert.ToInt16(ddBottles.SelectedValue), 
                           "N", 
                           "N", 
                           "A");

            Response.Redirect("WinePusher.aspx");
        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("WinePusher.aspx");
        }
    }
}