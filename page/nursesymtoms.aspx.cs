using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_nursesymtoms : System.Web.UI.Page
{
    private static SqlConnection conn;
    private static SqlCommand command;
    public string listFilter = null;
    public string listFilter1 = null;
    protected void Page_Load(object sender, EventArgs e)
    {

        //    Panel1.Visible = false;
       // listFilter = null;
    listFilter = sym_host();
        Label1.Text = "ชื่ออาการที่นำมาซัก  "+Session["number_symtom"];
    }


 
    /*
    protected void DropDownListdiagnose_SelectedIndexChanged(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(3000);
      

        if (IsPostBack)
        {

             quiz = Symptoms.GetQuiz(Convert.ToInt32(DropDownListdiagnose.SelectedValue));
     //       quiz = test();
            if (quiz != null)
            {
         
                txtCheck.Text = "เจอข้อมูล";
            }
            else
            {
                txtCheck.Text = "ไม่เจอเจอข้อมูล";
            }
        }
         



            }
            */
    private string sym_host()
    {

        //    Panel1.Visible = true;
        StringBuilder output = new StringBuilder();
        DataTable dt = new DataTable();
                dt = Symptoms.showdataquiz((int)Session["number_symtom"]);
         
                output.Append("[");
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    output.Append("\"" + dt.Rows[i]["Symptoms_host"].ToString() + "\"");

                    if (i != (dt.Rows.Count - 1))
                    {
                        output.Append(",");
                    }
                }

         
                output.Append("];");
           

          
        
     

        return output.ToString();
    }
    protected void txtsymtomhost_TextChanged(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(3000);
        Symptoms quiz = Symptoms.GetQuiz(txtsymptomhost.Text,(int)Session["number_symtom"]);
       // doctor quiz = doctor.Login_doctor("ge","12345");
        if(quiz != null)
        {
            Session["number_subsymtom"] = quiz.Symptoms_host;
            if (quiz.Subsymptom == "")
            {
                txtCheck.Text = ""+quiz.Diagnose_ID;
            }else
            {
               Response.Redirect("../page/subsymtom.aspx");
                // txtCheck.Text = "รหัส"+quiz.Symtoms_host_ID;
                Session["sub_host"] = quiz.Symtoms_host_ID;
             
                //  Response.Redirect("../page/subsymtom.aspx");
                //   txtCheck.Text = (string)Session["number_subsymtom"];
            }

        }
        else
        {
            txtCheck.Text = "ไม่มีข้อมูลที่กรอก";
        }
        //   listFilter = test();
    }


    /*
    protected void DropDownListdiagnose_SelectedIndexChanged(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(3000);


        if (IsPostBack)
        {

            quiz = Symptoms.GetQuiz(Convert.ToInt32(DropDownListdiagnose.SelectedValue));
            //       quiz = test();
            if (quiz != null)
            {

                txtCheck.Text = "เจอข้อมูล";
            }
            else
            {
                txtCheck.Text = "ไม่เจอเจอข้อมูล";
            }
        }

    }
    */
}