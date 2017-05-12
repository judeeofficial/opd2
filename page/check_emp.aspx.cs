using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_check_emp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void LinkButton1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("../page/msboss.aspx");
    }

    protected void btnsurch_Click(object sender, EventArgs e)
    {
        string staff = txtstaff.Text;
        string Filtter = "";

        if (staff != "")
        {
            Filtter = Filtter + " name like '%" + staff + "%' and ";

        }

        if (Filtter.Length > 0)
        {
            string finalfilter = Filtter.Remove(Filtter.Length - 4, 3);
            SqlDataSource1.FilterExpression = finalfilter;

        }
        else
        {
            GridView1.DataBind();

        }
    }
}