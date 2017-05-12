using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_doctorlogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Server.Transfer("msdoctor.aspx");
        /*
        String Username = txtusername.Text;

        String Password = txtpassword.Text;

        doctor doc = doctor.Login_doctor(Username, Password);

        if (doc != null)
        {
            Session["staff_name"] = doc.Doctor_Name;
            Server.Transfer("msdoctor.aspx");
        }else
        {
            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('รหัสผิดพลาด');", true);
        }


    */

    }
}