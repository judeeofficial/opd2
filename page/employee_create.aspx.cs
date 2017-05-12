using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_employee_create : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string name = txtempname.Text;
        string address = txtaddress.Text;
        string ddlemp_type = ddlworktype.SelectedValue;
        string tel = txttelemployees.Text;
        string username = txtName.Text;
        string password = txtpassword.Text;
        Employees emp = new Employees(username, password, name, ddlemp_type, address, tel);
        Employees.Register_employees(emp);
        Response.Redirect("../page/msboss.aspx");
    }

   

    protected void txtName_TextChanged(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(3000);
        int valuesMassage = Employees.valid_username(txtName.Text);
        if (valuesMassage == 1)
        {
            txtName.Text = "";
            lblCheck.Text = "ชื่อซ้ำ !!! กรุณากรอกชื่อใหม่";
        }
        else
        {
            lblCheck.Text = "OK ชื่อนี้ใช้ได้";
        }
    }
}