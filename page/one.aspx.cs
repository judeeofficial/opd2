using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_one : System.Web.UI.Page
{
    private bool button2WasClicked = false;
    int count = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        symtomquiz();
     
                
        if (!Page.IsPostBack)
        {
            TextBox1.Text = count.ToString();
       }
    }

    private void symtomquiz()
    {
      
        string[] quizhost = { "Quiz 1", null, "Quiz 2", "Quiz 3" };
        string[] quizsub = {null,"subQuiz 1.2", "subQuiz 1.3" };
        string[] answer = { "ans 1", "ans 2", "ans 3", "ans 4" };

        
        for (int lengthA = 0; lengthA < quizhost.Length; lengthA++)
        {

             Response.Write(quizhost[lengthA]);
      
        
        }
 
   



    }

 
    protected void Button1_Click1(object sender, EventArgs e)
    {
        symtomquiz();
    }



    protected void Button3_Click(object sender, EventArgs e)
    {
        while(count < 10)
        {
            if (int.TryParse(TextBox1.Text, out count))
            {

                TextBox1.Text = (++count).ToString();


            }
        }

     
       // count++;
       // TextBox1.Text = count.ToString();
            
    
       
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        string[] quizhost = { "Quiz 1", null, "Quiz 2", "Quiz 3" };
        string[] quizsub = { null, "subQuiz 1.2", "subQuiz 1.3" };
        string[] answer = { "ans 1", "ans 2", "ans 3", "ans 4" };

        string textbox = DropDownList1.SelectedValue;
        switch (textbox)
        {
            case "1":
                Response.Write(quizhost[2]);
                break; 


        }





    }
}