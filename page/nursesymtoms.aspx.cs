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
    protected void Page_Load(object sender, EventArgs e)
    {
       
        //    Panel1.Visible = false;
        //  listFilter = null;
     // listFilter = test();
    }


 

    protected void DropDownListdiagnose_SelectedIndexChanged(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(3000);

        if (IsPostBack)
        {
            Symptoms quiz = Symptoms.GetQuiz(Convert.ToInt32(DropDownListdiagnose.SelectedValue));
            listFilter = ""+quiz;
            listFilter = test();
            if (quiz != null)
            {
                //    Panel1.Visible = true;
          
                txtCheck.Text = "เจอข้อมูล";
            }else
            {
                txtCheck.Text = "ไม่เจอเจอข้อมูล";
            }
        }
          
            }
    private string test()
    {




         DataTable dt = new DataTable();
         dt = Symptoms.showdataquiz(Convert.ToInt32(DropDownListdiagnose.SelectedValue));
        StringBuilder output = new StringBuilder();
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
     

    }
}