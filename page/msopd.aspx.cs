using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_msopd : System.Web.UI.Page
{
  //  private static SqlConnection conn;
 //   private static SqlCommand command;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["TokenQueue"] == null)
        {
            Queue<int> queuetoken = new Queue<int>();
            Session["TokenQueue"] = queuetoken;
        }
    }

    protected void btnsurch_Click(object sender, EventArgs e)
    {
      //  ButtonField bu = GridView1.Rows[0].FindControl("chkCustomerID");
        SearchData();






    }
    protected void SearchData()
    {
        string pattient = txtpatient.Text;
        string Filtter  = "";
       
        if (pattient != "")
        {
            Filtter = Filtter + " NAME like '%" + pattient+"%' and ";

        }

        if (Filtter.Length > 0)
        {
            string finalfilter = Filtter.Remove(Filtter.Length - 4, 3);
            SqlDataSource1.FilterExpression = finalfilter;
       
        }
        else
        {
            GridView1.DataBind();
      
        }
       // DataSet ds1 = new DataSet();
       //   DataTable ds = new DataTable();
       // ds = Patient.showdatapatient(txtpatient.Text);
       //     DataTable dt = new DataTable();

            // ds = ds1.Tables[3];
            //     ds.Rows.Add(ds);

            //GridView1.DataSource = ds;
            //GridView1.DataBind();
        }
   /* protected void SearchData()
    {
         conn = new SqlConnection();
        command = new SqlCommand();
        SqlDataAdapter dtAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        String strConnString, strSQL;
       string strKeyWord = txtpatient.Text;
        strConnString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        strSQL = "select name,age,birthday,belong_to,Tel_working,address,Tel_myself from patient WHERE (Name like '" + strKeyWord + "') ";

        conn.ConnectionString = strConnString;
        command.Connection = conn;
        command.CommandText = strSQL;
        command.CommandType = CommandType.Text;


        dtAdapter.SelectCommand = command;

        dtAdapter.Fill(ds);


        GridView1.DataSource = ds;
        GridView1.DataBind();

        dtAdapter = null;
        conn.Close();
        conn = null;

    } */

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
  /*
        Label lblName = (Label)(e.Row.FindControl("lblName"));
        if (lblName!= null)
        {
            lblName.Text = (string)DataBinder.Eval(e.Row.DataItem, "Name");
            
        }

    
        Label lblAge = (Label)(e.Row.FindControl("lblAge"));
        if (lblAge != null)
        {
            lblAge.Text = (string)DataBinder.Eval(e.Row.DataItem, "Age");
        }


        Label lblbirthday = (Label)(e.Row.FindControl("lblbirthday"));
        if (lblbirthday != null)
        {
            lblbirthday.Text = DataBinder.Eval(e.Row.DataItem, "birthday").ToString();
        }

        Label lblbelongto= (Label)(e.Row.FindControl("lblbelongto"));
        if (lblbelongto != null)
        {
            lblbelongto.Text = (string)DataBinder.Eval(e.Row.DataItem, "belong_to");
        }

        Label lbltelwork = (Label)(e.Row.FindControl("lbltelwork"));
        if (lbltelwork != null)
        {
            lbltelwork.Text = (string)DataBinder.Eval(e.Row.DataItem, "Tel_working");
        }

        Label lbladdress = (Label)(e.Row.FindControl("lbladdress"));
        if (lbladdress != null)
        {
            lbladdress.Text = (string)DataBinder.Eval(e.Row.DataItem, "address");
        }
        Label lbltel = (Label)(e.Row.FindControl("lbltel"));
        if (lbltel != null)
        {
            lbltel.Text = (string)DataBinder.Eval(e.Row.DataItem, "Tel_myself");
        }
        */
        /**

                Label lblEmail = (Label)(e.Row.FindControl("lblbirthday"));
                if (lblEmail != null)
                {
                    lblEmail.Text = (string)DataBinder.Eval(e.Row.DataItem, "birthday");
                }


                Label lblCountryCode = (Label)(e.Row.FindControl("lblbelongto"));
                if (lblCountryCode != null)
                {
                    lblCountryCode.Text = (string)DataBinder.Eval(e.Row.DataItem, "belong_to");
                }
                Label lblphonework = (Label)(e.Row.FindControl("lblphonework"));
                if (lblphonework != null)
                {
                    lblphonework.Text = DataBinder.Eval(e.Row.DataItem, "Tel_working").ToString();
                }


                Label lblBudget = (Label)(e.Row.FindControl("address"));
                if (lblBudget != null)
                {
                    lblBudget.Text = DataBinder.Eval(e.Row.DataItem, "address").ToString();
                }


                Label lblUsed = (Label)(e.Row.FindControl("Tel_myself "));
                if (lblUsed != null)
                {
                    lblUsed.Text = DataBinder.Eval(e.Row.DataItem, "Tel_myself ").ToString();
                }
            */
    }



    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
    /**    
        if(e.CommandName == "Select")
        {
          Int16 num = Convert.ToInt16(e.CommandArgument);

            //   GridViewRow selectrow = GridView1.Rows[num];
            //   TableCell name = selectrow.Cells[5];
            string n = GridView1.Rows[num].Cells[2].Text;


            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('คุณเลือก    "+n+"');", true);

        //Server.Transfer("index.aspx");



        }*/
    }



    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            GridViewRow row = GridView1.SelectedRow;
            Queue<int> sequence_queue = (Queue<int>)Session["TokenQueue"];
            string name = row.Cells[0].Text;

            int tokennumber = sequence_queue.Dequeue();
            //     textbox.Text = tokennumber.ToString();
            //   txtdisplay.Text = "Token Number " + tokennumber.ToString() + "Please go to couter " + coutercustomer.ToString();
            Addtokenlast(sequence_queue);

            int idPatient = Convert.ToInt32(name);
            //  if (Session["LastTokenNumberIssued"] == null)
            //    {
            //      Session["LastTokenNumberIssued"] = 0;
            //   }
            //    int nextTokenNumbertobeIssued = (int)Session["LastTokenNumberIssued"] + 1;
            //  Session["LastTokenNumberIssued"] = nextTokenNumbertobeIssued;
            //    sequence_queue.Enqueue(nextTokenNumbertobeIssued);
            // sequence_queue.Enqueue(idPatient);
            /*   sequence_queue.Enqueue(idPatient);
               sequence_queue.Enqueue(idPatient);
               sequence_queue.Enqueue(idPatient);
               sequence_queue.Enqueue(idPatient);
               sequence_queue.Enqueue(idPatient);
               sequence_queue.Enqueue(idPatient);
               sequence_queue.Enqueue(idPatient);
               sequence_queue.Enqueue(idPatient);
               sequence_queue.Enqueue(idPatient);
               sequence_queue.Enqueue(idPatient);*/
            //  int count_queue = sequence_queue.Count;
            //  foreach (var i in sequence_queue.ToArray())
            //  {
            string status_queue = "1";

            string date = DateTime.Today.ToLongDateString();
            string time_queue = DateTime.Now.ToString("h:mm:ss tt");
            ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('ส่งข้อมูลเสร็จสิ้น');", true);

            String Name = "" + Session["staff_name"];
            //   sequence_queue.Dequeue();
            //   foreach (int token in sequence_queue)
            //   {
            //  lbltoken.Items.Add(token.ToString());

            // string se =token.ToString();
            //    int num_queue = Convert.ToInt32(se);
          
            Queue_Service ser = new Queue_Service(status_queue, tokennumber, date, time_queue, idPatient);
            Queue_Service.sent_queueservice(ser);



            //    }


            //  }


            /*  while (sequence_queue.Count > 6)
              {
              }


              */


            //  ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('Call    " + idPatient + "');", true);


            // string index = GridView1.SelectedRow.Cells[1].Text;

            //  ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('คุณเลือกค" + index + "');", true);
            /*  foreach (GridViewRow row in GridView1.Rows)
              {
                  if (row.RowIndex == GridView1.SelectedIndex)
                  {
                      row.BackColor = ColorTranslator.FromHtml("#A1DCF2");
                  }
                  else
                  {
                      row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                  }
              }*/
        }
        catch (Exception w)
        {
            lblstatus.Text = "คิวว่าง " + w.Message;
            //  ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('คิวว่าง' "+w.Message+");", true);
        }
      
    }

    private void servernext(TextBox textbox, int coutercustomer)
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
         //   txtdisplay.Text = "Token Number " + tokennumber.ToString() + "Please go to couter " + coutercustomer.ToString();
            Addtokenlast(tokenqueue);
        }
    }

    protected void Btntoken_Click(object sender, EventArgs e)
    {

        Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
       lblstatus.Text = "There are " + tokenQueue.Count.ToString() + "customer before you in queue ";

        if (Session["LastTokenNumberIssued"] == null)
        {
            Session["LastTokenNumberIssued"] = 0;
        }
        int nextTokenNumbertobeIssued = (int)Session["LastTokenNumberIssued"] + 1;
        Session["LastTokenNumberIssued"] = nextTokenNumbertobeIssued;
        tokenQueue.Enqueue(nextTokenNumbertobeIssued);
       // tokenQueue.Dequeue();
        Addtokenlast(tokenQueue);

    }
    private void Addtokenlast(Queue<int> tokenQueue)
    {
       lbltoken.Items.Clear();
        foreach (int token in tokenQueue)
        {
           lbltoken.Items.Add(token.ToString());

      //  token.ToString();
        }


    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
            lblstatus.Text = "There are " + tokenQueue.Count.ToString() + "customer before you in queue ";

            if (Session["LastTokenNumberIssued"] == null)
            {
                Session["LastTokenNumberIssued"] = 0;
            }
            int nextTokenNumbertobeIssued = (int)Session["LastTokenNumberIssued"] - 1;
          
               Session["LastTokenNumberIssued"] = nextTokenNumbertobeIssued;
              //  tokenQueue.Enqueue(nextTokenNumbertobeIssued);
                tokenQueue.Dequeue();
                Addtokenlast(tokenQueue);
            
          
       
        }
        catch(Exception w)
        {
            lblstatus.Text = "คิวว่าง " + w.Message;
          //  ClientScript.RegisterStartupScript(GetType(), "hwa", "alert('คิวว่าง' "+w.Message+");", true);
        }
      

    }





    protected void lbllogout_Click(object sender, EventArgs e)
    {
        if (lbllogout.Text == "ออกจากระบบ")
        {
            Session.Clear();
            Server.Transfer("opdlogin.aspx");
        }
        else
        {

        }
    }
}