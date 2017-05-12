using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_msnurse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void lbllogout_Click(object sender, EventArgs e)
    {
        if (lbllogout.Text == "ออกจากระบบ")
        {
            Session.Clear();
            Server.Transfer("nurselogin.aspx");
        }
        else
        {

        }
    }
}