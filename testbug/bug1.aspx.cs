using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class testbug_bug1 : System.Web.UI.Page
{
    private static SqlConnection conn;
    private static SqlCommand command;
    public string listFilter = null;

    static testbug_bug1()
    {
        /*     string strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
             conn = new MySqlConnection(strConnString);
             command = new MySqlCommand("", conn); */

        string connectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        listFilter = null;
        listFilter = test();

    }

    private string test()
    {
      
        DataTable dt = null;
        using (conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Connectionstring"].ConnectionString))
        {
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Symptoms_host from Symptoms_detail";
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    dt = new DataTable();
                    da.Fill(dt);
                }
            }
        }
        
      //  DataTable dt = new DataTable();
       // dt = Symptoms.showdataquiz();
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

}

