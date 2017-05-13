using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class testbug_bug2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        Symptoms quiz = Symptoms.GetQuiz1(TextBox1.Text);
        if(quiz != null)
        {
            Response.Write(quiz.Symptoms_host);
        }
    }
}