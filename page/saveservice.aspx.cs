using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_saveservice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView1.SelectedRow;
        string name = row.Cells[0].Text;
        string result_diagnose = row.Cells[1].Text;
        string date = row.Cells[3].Text;
        Session["namepatient"] = name;
        Session["result_diagnose"] = result_diagnose;
        Session["date"] = date;
        Server.Transfer("update_treatment.aspx");

        //  ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('เลือก "+ name + "');", true);
    }



    protected void LinkButton1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("../page/msdoctor.aspx");
    }
}