using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Queue myQueue = new Queue(6);
        myQueue.EnQueue(10);
        myQueue.EnQueue(20);
        myQueue.EnQueue(30);
        myQueue.EnQueue(40);
        myQueue.EnQueue(50);
        for (int i = 0; i < 10; i++)
            Response.Write(myQueue.DeQueue());
    
      

        /*   Queue<string> myQueue = new Queue<string>();
           myQueue.Enqueue("abc");
           myQueue.Enqueue("hello");
           myQueue.Enqueue("thailand");
           myQueue.Enqueue("bangkok");
          // Response.Write(myQueue.Count);

     //      for (int i =myQueue.Count; i < 7; i++)
       //    {
             //  Response.Write(i);

         //      Response.Write(myQueue.Dequeue());
           //}

           while (myQueue.Count > 3)
           {
               Response.Write(myQueue.Dequeue());
           }

       */
        /*
        Queue<int> collection = new Queue<int>();
        collection.Enqueue(5);
        collection.Enqueue(6);
        collection.Enqueue(7);
        collection.Enqueue(8);
        collection.Dequeue();
     //   collection.Dequeue();
 
        // Loop through queue.
        foreach (int value in collection)
        {
            string v = Convert.ToString(value);
            Response.Write(value);
        }

       // lbllabel1.Text = DateTime.Now.ToString("h:mm:ss tt");
       lbllabel1.Text = DateTime.Today.ToLongDateString(); 

    */



    }

    protected void OpenWindow(object sender, EventArgs e)
    {
        string url = "../page/index.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=300,height=100,left=100,top=100,resizable=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
}