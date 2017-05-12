using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_test : System.Web.UI.Page
{
    private bool buttonevent = false;

    protected void Page_Load(object sender, EventArgs e)
    {
        symtomquiz();
    }

    private void symtomquiz()
    {
        string[] quiz = { "Quiz 1", "Quiz 2", "Quiz 3", "Quiz 4" };
       
        if (Session["LastTokenNumberIssued"] == null)
        {
            Session["LastTokenNumberIssued"] = 0;
        }
        int count = (int)Session["LastTokenNumberIssued"] +1;
        Session["LastTokenNumberIssued"] = count;

        TextBox1.Text = Convert.ToString(quiz[0]);
        if (RadioButton1.Checked == true)
        {
            TextBox1.Text = Convert.ToString(count);
        }
        else 
        {
            
        }

        //  Response.Write(quiz[a]);
        //}
    }


    protected void Button1_Click1(object sender, EventArgs e)
    {

        symtomquiz();


    }

    protected void Button2_Click(object sender, EventArgs e)
    {

        Session.Clear();
    }
}