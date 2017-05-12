using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_msqueue : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["TokenQueue"] == null)
        {
            Queue<int> queuetoken = new Queue<int>();
            Session["TokenQueue"] = queuetoken;
        }
    }

    protected void btntoken_Click(object sender, EventArgs e)
    {
        Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
        lblstatus.Text = "There are " + tokenQueue.Count.ToString() + "customer before you in queue ";

        if(Session["LastTokenNumberIssued"] == null)
        {
            Session["LastTokenNumberIssued"] = 0;
        }
        int nextTokenNumbertobeIssued = (int)Session["LastTokenNumberIssued"] + 1;
        Session["LastTokenNumberIssued"] = nextTokenNumbertobeIssued;
        tokenQueue.Enqueue(nextTokenNumbertobeIssued);
        Addtokenlast(tokenQueue);
    
       
    }
    private void Addtokenlast(Queue<int> tokenQueue)
    {
        listtoken.Items.Clear();
        foreach (int token in tokenQueue)
        {
            listtoken.Items.Add(token.ToString());
        }
    }

    private void servernext(TextBox textbox , int coutercustomer)
    {
        Queue<int> tokenqueue = (Queue<int>)Session["TokenQueue"];
        if (tokenqueue.Count == 0)
        {
            textbox.Text = "No Customer in the queue";
        }
        else
        {
            int tokennumber = tokenqueue.Dequeue();
            textbox.Text = tokennumber.ToString();
            txtdisplay.Text = "Token Number " + tokennumber.ToString() + "Please go to couter " +coutercustomer.ToString();
            Addtokenlast(tokenqueue);
        }
    }
    protected void btncouter1_Click(object sender, EventArgs e)
    {
        servernext(txtcounter1, 1);
    }

    protected void btncouter2_Click(object sender, EventArgs e)
    {
        servernext(txtcouter2, 2);
    }

    protected void btncouter3_Click(object sender, EventArgs e)
    {
        servernext(counter3, 3);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
        lblstatus.Text = "There are " + tokenQueue.Count.ToString() + "customer before you in queue ";

        if (Session["LastTokenNumberIssued"] == null)
        {
            Session["LastTokenNumberIssued"] = 0;
        }
        int nextTokenNumbertobeIssued = (int)Session["LastTokenNumberIssued"] - 1;
        Session["LastTokenNumberIssued"] = nextTokenNumbertobeIssued;
        tokenQueue.Enqueue(nextTokenNumbertobeIssued);
        Addtokenlast(tokenQueue);
    }
}