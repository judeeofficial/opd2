using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_patientregister : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        Calendarbirthday.Visible = false;
   
    }





    protected void btnsubmit_Click(object sender, EventArgs e)
    {
      
            String Nameparrent = txtpatient.Text;
            String age = txtage.Text;
          //  DateTime birthday = ((DateTime)Calendarbirthday.SelectedDate);
           String birthday = Calendarbirthday.SelectedDate.ToString("yyyy-MM-dd");
        String ddlworklocation1 = ddworklocation.SelectedItem.Text;
            String telwork = txttelwork.Text;
            String addressnow = teladdressnow.Text;
            String tel = telmyself.Text;
            String dad = name_dad.Text;
            String mom = name_mom.Text;
            String hasbandwide = txtnamehusbandwide.Text;
            String parentname = txtparentname.Text;
            String statusparent = Rdpeople.SelectedValue;
            String teladdressparent = txtteladdressparent.Text;
            String telhomeparent = txttelhomeparent.Text;
        String ddltype_paatient = DropDownList1.SelectedItem.Text;
       
        Patient p = new Patient(Nameparrent, age,birthday, ddlworklocation1, telwork, addressnow, tel, dad, mom, hasbandwide, parentname,statusparent, teladdressparent, telhomeparent, ddltype_paatient);
            Patient.Register_opdcard(p);
            Server.Transfer("msopd.aspx");
        

      


    }



    protected void Calendarbirthday_SelectionChanged(object sender, EventArgs e)
    {
        String work_date = Calendarbirthday.SelectedDate.ToString("yyyy-MM-dd"); 
        lblbirthday.Text = "" + work_date;
    }

    protected void btbirthday_Click(object sender, ImageClickEventArgs e)
    {
        Calendarbirthday.Visible = true;
    }



}