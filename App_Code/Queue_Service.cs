using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Queue_Service
/// </summary>
public class Queue_Service
{
    private static SqlConnection conn;
    private static SqlCommand command;
    public int Queue_ID { get; set; }
    public string status_Queue { get; set; }
    public int sequence_queue { get; set; }

    public string date_queue { get; set; }
    public string time_queue { get; set; }
    public int Service_number { get; set; }
    public int Patient_id { get; set; }


    static Queue_Service()
    {
        /*     string strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
             conn = new MySqlConnection(strConnString);
             command = new MySqlCommand("", conn); */

        string connectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }

    public Queue_Service(int Queue_ID,string status_Queue,int sequence_queue,
                         string date_queue,string time_queue,int Service_number, int Patient_id)
    {
        this.Queue_ID = Queue_ID;
        this.status_Queue = status_Queue;
        this.sequence_queue = sequence_queue;
        this.date_queue = date_queue;
        this.time_queue = time_queue;
        this.Service_number = Service_number;
        this.Patient_id = Patient_id;

    }

    public Queue_Service(string status_Queue, int sequence_queue,
                     string date_queue, string time_queue, int Patient_id)
    {
        this.status_Queue = status_Queue;
        this.sequence_queue = sequence_queue;
        this.date_queue = date_queue;
        this.time_queue = time_queue;
        this.Patient_id = Patient_id;

    }

  
    public static string sent_queueservice(Queue_Service Q)
    {
        string query = String.Format("SELECT COUNT(*) FROM queue WHERE status_queue = '{0}'", Q.Queue_ID);
        try
        {
            conn.Open();
            command.CommandText = query;

            int amountOfPatient = (int)command.ExecuteScalar();
            if (amountOfPatient < 1)
            {
                query = String.Format("INSERT INTO queue (status_queue, sequence_queue ," +
                                        "date_queue,time_queue , Patient_id)" +
                                        " VALUES('{0}', '{1}','{2}', '{3}', '{4}')",
                                       Q.status_Queue,
                                      Q.sequence_queue,
                                      Q.date_queue,
                                      Q.time_queue,
                                    
                                      Q.Patient_id
                                       );
                command.CommandText = query;
                command.ExecuteNonQuery();
                return "ส่งข้อมูลสมบูรณ์";
            }
            else
            {
                return "ส่งข้อมูลไม่สำเร็จ";
            }
        }
        finally
        {
            conn.Close();
        }
    }




}