using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Employees
/// </summary>
public class Employees
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

    static Employees()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }
    public Employees(int Employees_id,string username,string password,string name,string age,string Job_position
                      , string address,string Tel)
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


    public Employees(string name, string username, string password)
    {
        this.name = name;
        this.username = username;
        this.password = password;

    }

    public Employees(string username, string password, string name,string Job_position
                  , string address, string Tel)
    {
        this.username = username;
        this.password = password;
        this.name = name;
        this.Job_position = Job_position;
        this.address = address;
        this.Tel = Tel;
    }

    public static Employees Login_emp(string username, string password)
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
                        string emp_Name = reader.GetString(0);
                        Employees E = new Employees(emp_Name, username, password);
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

    public static string Register_employees(Employees emp)
    {
        string query = String.Format("SELECT COUNT(*) FROM Employees WHERE Name = '{0}'", emp.name);
        try
        {
            conn.Open();
            command.CommandText = query;

            int amountOfPatient = (int)command.ExecuteScalar();
            if (amountOfPatient < 1)
            {
                query = String.Format("INSERT INTO Employees (username, password ," +
                                        "name,Job_position,address,Tel)" +
                                        " VALUES('{0}', '{1}','{2}', '{3}', '{4}', '{5}')",
                                      emp.username,
                                      emp.password,
                                      emp.name,
                                      emp.Job_position,
                                      emp.address,
                                      emp.Tel);

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
    public static int valid_username(string name)
    {
        string query = String.Format("SELECT COUNT(*) FROM Employees WHERE username = '{0}'", name);
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
}