using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Treatment
/// </summary>
public class Treatment
{
    private static SqlConnection conn;
    private static SqlCommand command;
    public int Treatment_ID { get; set; }
    public string Treatment_Date { get; set; }
    public string Comment { get; set; }
    public int Diagnose_ID { get; set; }
    public int Patient_id { get; set; }

    static Treatment()
    {
        /*     string strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
             conn = new MySqlConnection(strConnString);
             command = new MySqlCommand("", conn); */

        string connectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }

    public Treatment(int Treatment_ID, string Treatment_Date, string Comment, int Diagnose_ID,
        int Patient_id)
    {
        this.Treatment_ID = Treatment_ID;
        this.Treatment_Date = Treatment_Date;
        this.Comment = Comment;
        this.Diagnose_ID = Diagnose_ID;
        this.Patient_id = Patient_id;

    }

    public Treatment(string Treatment_Date, string Comment, int Diagnose_ID,
       int Patient_id)
    {
        this.Treatment_Date = Treatment_Date;
        this.Comment = Comment;
        this.Diagnose_ID = Diagnose_ID;
        this.Patient_id = Patient_id;

    }

    public static string save_Treatment(Treatment treatment)
    {
        string query = String.Format("SELECT COUNT(*) FROM Treatment WHERE Patient_id = {0}", treatment.Patient_id);
        try
        {
            conn.Open();
            command.CommandText = query;
            int amountOfUsers = (int)command.ExecuteScalar();
            if (amountOfUsers < 1)
            {
                query = String.Format("INSERT INTO Treatment (Treatment_Date, Comment, Diagnose_ID, Patient_id) VALUES ('{0}', '{1}', {2}, {3})", treatment.Treatment_Date,treatment.Comment,
                                                          treatment.Diagnose_ID,treatment.Patient_id);
                command.CommandText = query;
                command.ExecuteNonQuery();
                return "บันทึกข้อมูลเสร็จสิ้น";
            }
            else
            {
                return "บันทึกข้อมูลไม่สำเร็จ";
            }
        }
        finally
        {
            conn.Close();
        }
    }

}