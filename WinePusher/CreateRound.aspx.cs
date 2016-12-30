using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WinePusher.BusinessLogic;

namespace WinePusher
{
    public partial class CreateRound : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSaveRound_Click(object sender, EventArgs e)
        {
            WineHandler wh = new BusinessLogic.WineHandler();
            int wineId = wh.CreateWine(ddWineTypes.SelectedValue,
                                       tbWineName.Text,
                                       Convert.ToDecimal(tbWinePrice.Text),
            tbStore.Text);

            RoundHandler rh = new RoundHandler();
            rh.CreateRound(wineId,
                           DateTime.Now,
                           "A");

            Response.Redirect("WinePusher.aspx");
        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            //Response.Redirect(Request.UrlReferrer.ToString());
            Response.Redirect("WinePusher.aspx");
        }
    }
}