using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_msstaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       

    }
    private void setmyqueue()
    {
        if (Session["staff_name"] != null)
        {
            string nurese_name = "" + Session["staff_name"];
            int checkqueue = Nurse.queue_nurse_service(nurese_name);
       




        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView1.SelectedRow;

    
        string name = row.Cells[1].Text;
        Session["namepattient"] = name;
        Server.Transfer("nursesymtom.aspx");




    }
}