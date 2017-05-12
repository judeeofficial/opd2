using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_queueservicems : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView1.SelectedRow;


        string name = row.Cells[1].Text;
        Session["namepattient"] = name;
        Response.Redirect("../page/nursesymtom.aspx");
    }





    protected void lblindex_Click(object sender, EventArgs e)
    {
        Response.Redirect("../page/msnurse.aspx");
    }
}