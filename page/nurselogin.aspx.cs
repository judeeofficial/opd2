using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_nurselogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btnlogin_Click(object sender, EventArgs e)
    {
        
        string username = txtusername.Text;
        string password = txtpassword.Text;
        Nurse user = Nurse.Login_nurse(username, password);

        if (user != null)
        {
            Session["staff_name"] = user.name;

            Server.Transfer("msnurse.aspx");
            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('เข้าสู่ระบบเรียบร้อย');", true);
        }
        else
        {
            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('เข้าสู่ระบบผิดพลาด');", true);
        }
        
    }
}