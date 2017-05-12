using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for time_work
/// </summary>
public class time_work
{
    private static SqlConnection conn;
    private static SqlCommand command;
    public int Doctor_time_work_ID { get; set; }
    public string Date_of_work { get; set; }
    public string Time_of_work { get; set; }
    public string Day { get; set; }
    public string month { get; set; }
    public string Year { get; set; }
    public int Employees_id { get; set; }
    static time_work()
    {
        /*     string strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
             conn = new MySqlConnection(strConnString);
             command = new MySqlCommand("", conn); */

        string connectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }
    public time_work(int Doctor_time_work_ID, string Date_of_work, string Time_of_work,
        string Day,string month,string Year ,int Employees_id)
    {
        this.Doctor_time_work_ID = Doctor_time_work_ID;
        this.Date_of_work = Date_of_work;
        this.Time_of_work = Time_of_work;
        this.Day = Day;
        this.month = month;
        this.Year = Year;
        this.Employees_id = Employees_id;
    }
    public time_work(string Date_of_work, string Time_of_work,
     string Day, string month, string Year , int Employees_id)
    {
      
        this.Date_of_work = Date_of_work;
        this.Time_of_work = Time_of_work;
        this.Day = Day;
        this.month = month;
        this.Year = Year;
        this.Employees_id = Employees_id;
    }
    public time_work( string Time_of_work,
 string Day)
    {
        
        this.Time_of_work = Time_of_work;
        this.Day = Day;

    }
    public static string Register_time(time_work timework)
    {
        string query = String.Format("SELECT COUNT(*) FROM time_work  WHERE Date_of_work = '{0}'", timework.Date_of_work);
        try
        {
            conn.Open();
            command.CommandText = query;

            int amountOfPatient = (int)command.ExecuteScalar();
            if (amountOfPatient < 1)
            {
                query = String.Format("INSERT INTO time_work (Date_of_work, Time_of_work ,Day," +
                                        "month,Year,Employees_id)" +
                                        " VALUES('{0}', '{1}','{2}', '{3}','{4}','{5}')",
                                       timework.Date_of_work,
                                       timework.Time_of_work,
                                       timework.Day,

                                       timework.month,
                                       timework.Year,
                                       timework.Employees_id
                                  );
                command.CommandText = query;
                command.ExecuteNonQuery();
                return "ทำรายการเสร็จสมบูรณ์";
            }
            else
            {
                return "ทำรายการไม่สำเร็จ";
            }
        }
        finally
        {
            conn.Close();
        }
    }
    public static int valid_timedoctor(string Date_of_work,string time_of_work)
    {
        string query = String.Format("SELECT COUNT(*) FROM time_work  WHERE Time_of_work = '{0}' and Date_of_work = '{1}'", Date_of_work,time_of_work);
        try
        {
            conn.Open();
            command.CommandText = query;
            int amountOfUsers = (int)command.ExecuteScalar();
            if (amountOfUsers > 0)
            {
                return 1;
            }
            else return 0;
        }
        finally
        {
            conn.Close();
        }
        return 0;
    }

    public static ArrayList showtimechalender(int employees_ID)
    {
        ArrayList list = new ArrayList();
        string query = string.Format("Select Day,Time_of_work from time_work where Employees_id = {0}",employees_ID);

        try
        {
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {


                string day = reader.GetString(0);
                string time_of_work = reader.GetString(1);
                time_work time = new time_work(time_of_work,day);
                list.Add(time);
            }

        }
        finally
        {
            conn.Close();
        }
        return list;
    }
}