using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_time_work_register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void lbllogout_Click(object sender, EventArgs e)
    {

    }



    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {
        ArrayList doc = doctor.show_name("แพทย์");
        foreach (doctor Docactivity in doc)
        {
            ArrayList time= time_work.showtimechalender(Docactivity.Doctor_ID);
            foreach (time_work timeactivity in time)
            {
               if (e.Day.DayNumberText == timeactivity.Day)
                {
                    e.Cell.BackColor = System.Drawing.Color.HotPink;
                    e.Cell.Controls.Add(new LiteralControl("<br/><B>"+ Docactivity.Doctor_Name+"</B>"));
                    e.Cell.Controls.Add(new LiteralControl("<br/><B>" + timeactivity.Time_of_work + "</B>"));
                }
            }
        


        }
        
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {

    }
}