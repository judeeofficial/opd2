using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Nurse
/// </summary>
public class Nurse
{
    private static SqlConnection conn;
    private static SqlCommand command;
    public int Employees_id { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public string name { get; set; }
    public string age { get; set; }
    public string Job_position { get; set; }
    public string address { get; set; }
    public string Tel { get; set; }
   // public string Diagnose_group { get; set; }
    static Nurse()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }

    public Nurse(int Employees_id, string username,
      string password, string name, string age, string Job_position,
     string address, string Tel)
    {
        //
        // TODO: Add constructor logic here
        //

        this.Employees_id = Employees_id;
        this.username = username;
        this.password = password;
        this.name = name;
        this.address = address;
        this.age = age;
        this.Job_position = Job_position;
    }


    public Nurse(string name,string username, string password)
    {
        this.name = name;
        this.username = username;
        this.password = password;
   
    }

    public Nurse(int Employees_id)
    {
        this.Employees_id = Employees_id;
    }

    public static Nurse Login_nurse(string username, string password)
    {
        string query = String.Format("select COUNT(*) from Employees WHERE username = '{0}'", username);
        command.CommandText = query;
        try
        {
            conn.Open();
            int NurseCount = (int)command.ExecuteScalar();
            if (NurseCount == 1)
            {
                query = String.Format("SELECT password FROM Employees WHERE username = '{0}'", username);
                command.CommandText = query;
                string dbpassword = command.ExecuteScalar().ToString();
                if (dbpassword == password)
                {
                    query = String.Format("SELECT name FROM Employees WHERE username = '{0}'", username);
                    command.CommandText = query;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string Nurse_Name = reader.GetString(0);
                        Nurse N = new Nurse(Nurse_Name,username ,password);
                        return N;
                    }
                    return null;
                }
                return null;
            }
            else
            {
                return null;
            }
        }
        finally
        {
            conn.Close();
        }
        return null;
    }

    public static int queue_nurse_service(string name)
    {
        string query = String.Format("SELECT COUNT(*) FROM Employees WHERE name = '{0}'", name);
        try
        {
            conn.Open();
            command.CommandText = query;
            int amountOfUsers = (int)command.ExecuteScalar();
            if (amountOfUsers > 0)
            {
                return 1;
            }
            else {
                return 2;
            } 
        }
        finally
        {
            conn.Close();
        }
        return 0;
    }

}