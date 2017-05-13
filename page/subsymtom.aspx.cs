using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_subsymtom : System.Web.UI.Page
{
    public string listFilter = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        listFilter = sym_sub();
        Label1.Text = "ชื่ออาการที่นำมาซัก  " + Session["number_symtom"];
        txtCheck.Text = (string) Session["number_subsymtom"];
    }






    private string sym_sub()
    {

        //    Panel1.Visible = true;
        StringBuilder output = new StringBuilder();
        DataTable dt = new DataTable();
        dt = Symptoms.showsubdataquiz((int)Session["sub_host"]);

        output.Append("[");
        for (int i = 0; i < dt.Rows.Count; ++i)
        {
            output.Append("\"" + dt.Rows[i]["Sub_Symtoms"].ToString() + "\"");

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
        Symptoms quiz = Symptoms.GetsubQuiz(txtsymptomhost.Text, (int)Session["number_symtom"]);
        // doctor quiz = doctor.Login_doctor("ge","12345");
        if (quiz != null)
        {
            txtCheck.Text = "รหัสโรคที่คาดว่าจะเป็น  "+quiz.Diagnose_ID + " หมายเหตุ  " +quiz.result_comment;
           
     

        }
        else
        {
            txtCheck.Text = "ไม่มีข้อมูลที่กรอก";
        }
    }
}