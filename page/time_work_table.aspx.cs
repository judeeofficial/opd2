using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_time_work_table : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e) {


    }
    

 

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = GridView1.SelectedRow;
        string name = row.Cells[0].Text;
        Session["doctor_name"] = name;
       string url = "../page/save_time.aspx";
        Response.Redirect(url);
      //  string s = "window.open('" + url + "', 'popup_window', 'width=1000,height=1200,left=100,top=100,resizable=yes');";
    //    ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);

 
    }
}