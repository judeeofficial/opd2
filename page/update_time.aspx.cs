using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_update_time : System.Web.UI.Page
{
    private static SqlConnection conn;
    private static SqlCommand command;

    static page_update_time()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        txtdoctor.Text = (string)Session["doctor_name"];
        Calendarbirthday.Visible = false;
        string date = DateTime.Now.ToString("MMMM");

        lblmonth.Text = date;
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            System.Threading.Thread.Sleep(3000);
            string datework = Convert.ToString(((DateTime)Calendarbirthday.SelectedDate));
            int check_time = time_work.valid_timedoctor(DropDownList1.SelectedValue, datework);
            if (check_time == 1)
            {
                DropDownList1.SelectedIndex = 0;
                lblCheck.Text = "เวลานี้มีผู้มาปฏิบัติงานแล้ว";
            }
            else
            {
                lblCheck.Text = "เวลานี้ไม่มีคนจอง";
            }
        }
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string name = txtdoctor.Text;
        doctor doc = doctor.show_namedoctor(name);
        if (doc != null)
        {
            try
            {
                int doc_id = doc.Doctor_ID;
                DateTime datework = ((DateTime)Calendarbirthday.SelectedDate);

                String time_of_work = DropDownList1.SelectedValue;
                string date_work = Convert.ToString(datework);
                string date = Convert.ToString(datework.Day);
                string month = DateTime.Now.ToString("MMMM");
                string year = Convert.ToString(datework.Year);

                conn.Open();
                string query = string.Format("UPDATE time_work  SET Date_of_work = '{0}', Time_of_work = '{1}', "+
                                             "Day = '{2}', month = '{3}', Year = '{4}' where Employees_id = {5}",
                                             date_work,time_of_work,date,month,year,doc_id);
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
    }

    protected void btbirthday_Click(object sender, ImageClickEventArgs e)
    {
        Calendarbirthday.Visible = true;
    }

    protected void Calendarbirthday_SelectionChanged(object sender, EventArgs e)
    {
        lblwork.Text = Calendarbirthday.SelectedDate.ToString("yyyy-MM-dd");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("../page/Change_time.aspx");
    }
}