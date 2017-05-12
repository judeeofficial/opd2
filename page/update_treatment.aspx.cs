using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_update_treatment : System.Web.UI.Page
{
    private static SqlConnection conn;
    private static SqlCommand command;
    protected void Page_Load(object sender, EventArgs e)
    {
       txtnamepatient.Text = (string)Session["namepatient"];
     txtdiagnose.Text = (string)Session["result_diagnose"];
       txtdate.Text = (string)Session["date"];
    }
    static page_update_treatment()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string saveservice = txtarria.Text;
        string namepatient = (string)Session["namepatient"];
        Patient p = Patient.show_namePatient(namepatient);
        if(p != null)
        {
            
            try
            {
                conn.Open();
                string query = string.Format("UPDATE Treatment SET Comment = '{0}' where Patient_id = '{1}'", saveservice, p.Patient_id);
                ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('อัพเดทข้อมูลเรียบร้อย');", true);
                command.CommandText = query;
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        Response.Redirect("../page/saveservice.aspx");
        //  Server.Transfer("");
    }
}