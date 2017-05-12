using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_register_doctor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string name = txtempname.Text;
        string address = txtaddress.Text;
        int ddlexpert = Convert.ToInt32(DropDownList1.SelectedValue);
        string tel = txttelemployees.Text;
        string username = txtName.Text;
        string password = txtpassword.Text;

        doctor doc = new doctor(name,username,password,address,tel,ddlexpert);
        doctor.Register_doctor(doc);
        Response.Redirect("../page/time_work_register.aspx");
    }

    protected void txtName_TextChanged(object sender, EventArgs e)
    {

    }
}