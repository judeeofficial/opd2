using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_symtom : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void DropDownListdiagnose_SelectedIndexChanged(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(3000);


        if (IsPostBack)
        {

            Session["number_symtom"] = Convert.ToInt32(DropDownListdiagnose.SelectedValue);
          
                Response.Redirect("../page/nursesymtoms.aspx");
        
        }




    }
}
