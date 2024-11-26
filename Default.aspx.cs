using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankManagent
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BankerLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Banker.aspx");
        }

        protected void CustomerLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customer.aspx");
        }
    }
}