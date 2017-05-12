using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for boss
/// </summary>
public class boss
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

    static boss()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }

    public boss(int Employees_id, string username, string password, string name, string age, string Job_position
                      , string address, string Tel)
    {
        this.Employees_id = Employees_id;
        this.username = username;
        this.password = password;
        this.name = name;
        this.age = age;
        this.Job_position = Job_position;
        this.address = address;
        this.Tel = Tel;
    }
    public boss(string name, string username, string password)
    {
        this.name = name;
        this.username = username;
        this.password = password;

    }

    public static boss Login_emp(string username, string password)
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
                        string boss_Name = reader.GetString(0);
                        boss E = new boss(boss_Name, username, password);
                        return E;
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
}