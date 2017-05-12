using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class page_Default3 : System.Web.UI.Page
{
    private MySqlConnection objConn;
    private MySqlCommand objCmd;
    private MySqlTransaction Trans;
    private String strConnString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        strConnString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        using (objConn = new MySqlConnection(strConnString))
        {
            objConn.Open();
            Response.Write("เชื่อมต่อได้แล้ว");
        }
    }
}