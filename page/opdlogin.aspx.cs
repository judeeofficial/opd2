using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_opdlogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnlogin_Click(object sender, EventArgs e)
    {
        String Username = txtusername.Text;

        String Password = txtpassword.Text;

        Employees emp = Employees.Login_emp(Username, Password);

        if (emp != null)
        {
            Session["staff_name"] = emp.name;
            Response.Redirect("../page/msopd.aspx");
        
        }

        else
        {
            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('รหัสผิดพลาด');", true);
        }

    }
}