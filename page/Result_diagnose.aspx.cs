using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_Result_diagnose : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblpattient.Text = "  "+ Session["namepattient"];
        lbldiagnose.Text = "คุณคาดว่าจะเป็นโรค  "+ Session["diagno"] + " จัดอยู่ในกลุ่มโรค " + Session["name_group"] + "";
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        string name = ""+Session["namepattient"];
      Patient patient = Patient.show_namePatient(name);
    if (patient != null)
        {

            string date = DateTime.Today.ToLongDateString();
            int name_id = patient.Patient_id;
            int convert = (int)Session["convert"];
          Treatment p = new Treatment(date, "", convert, name_id);
            Treatment.save_Treatment(p);
          //  ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('กรุณากรอกข้อมูลให้เรียบร้อย111' );", true);
          Server.Transfer("queueservicems.aspx");

        }else
        {
            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('กรุณากรอกข้อมูลให้เรียบร้อย' );", true);

        }
    
    }
}