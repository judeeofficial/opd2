using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_save_time : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtdoctor.Text = (string)Session["doctor_name"];
        Calendarbirthday.Visible = false;

        string date = DateTime.Now.ToString("MMMM");

        lblmonth.Text = date;
    }

    protected void btbirthday_Click(object sender, ImageClickEventArgs e)
    {
        Calendarbirthday.Visible = true;
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string name = txtdoctor.Text;
        doctor doc = doctor.show_namedoctor(name);
        if(doc != null)
        {
            int doc_id = doc.Doctor_ID;
            DateTime datework = ((DateTime)Calendarbirthday.SelectedDate);

            String time_of_work = DropDownList1.SelectedValue;
            string date_work = Convert.ToString(datework);
            string date = Convert.ToString(datework.Day);
            string month = DateTime.Now.ToString("MMMM");
            string year = Convert.ToString(datework.Year);
     
            time_work time = new time_work(date_work, time_of_work,date ,month,year, doc_id);
            time_work.Register_time(time);
            Response.Redirect("../page/time_work_table.aspx");
        }
    }

    protected void Calendarbirthday_SelectionChanged(object sender, EventArgs e)
    {
        lblwork.Text = Calendarbirthday.SelectedDate.ToString("yyyy-MM-dd");
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
}