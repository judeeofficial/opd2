using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for doctor1
/// </summary>
public class doctor
{
    //  private static MySqlConnection conn;
    //  private static MySqlCommand command;
    private static SqlConnection conn;
    private static SqlCommand command;
    public int Doctor_ID { get; set; }
    public string Doctor_Name { get; set; }
    public string age { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public string address_doctor { get; set; }
    public string Tel_doctor { get; set; }
    public int diserse_group_name { get; set; }
    static doctor()
    {
        //   string strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        // conn = new MySqlConnection(strConnString);
        //  command = new MySqlCommand("", conn);
        string connectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }
    public doctor(int Doctor_ID, string Doctor_Name,
      string age, string username, string password, string address_doctor,
     string Tel_doctor, int diserse_group_name)
    {
        //
        // TODO: Add constructor logic here
        //

        this.Doctor_ID = Doctor_ID;
        this.Doctor_Name = Doctor_Name;
        this.username = username;
        this.password = password;
        this.address_doctor = address_doctor;
        this.Tel_doctor = Tel_doctor;
        this.diserse_group_name = diserse_group_name;
    }
    public doctor(string Doctor_Name,
        string username, string password, string address_doctor,
        string Tel_doctor, int diserse_group_name)
    {
        //
        // TODO: Add constructor logic here
        //
        this.Doctor_Name = Doctor_Name;
        this.username = username;
        this.password = password;
        this.address_doctor = address_doctor;
        this.Tel_doctor = Tel_doctor;
        this.diserse_group_name = diserse_group_name;
    }
    public doctor(string Doctor_Name, string username, string password)
    {
        //
        // TODO: Add constructor logic here
        //
        this.Doctor_Name = Doctor_Name;
        this.username = username;
        this.password = password;

    }

    public doctor(int Doctor_ID)
    {
        //
        // TODO: Add constructor logic here
        //

        this.Doctor_ID = Doctor_ID;

    }

    public doctor(int Doctor_ID,string Doctor_Name)
    {
        //
        // TODO: Add constructor logic here
        //

        this.Doctor_ID = Doctor_ID;
        this.Doctor_Name = Doctor_Name;


    }
    public static doctor Login_doctor(string username, string password)
    {
        string query = String.Format("SELECT COUNT(*) FROM doctor WHERE username = '{0}'", username);
        command.CommandText = query;
        try
        {
            conn.Open();
            int countuser = (int)command.ExecuteScalar();
            if (countuser == 1)
            {
                query = String.Format("select password from doctor WHERE username  = '{0}'", username);
                command.CommandText = query;
                string dbpassword = command.ExecuteScalar().ToString();
                if (dbpassword == password)
                {
                    query = String.Format("select Doctor_Name from doctor WHERE username = '{0}' ", username);
                    command.CommandText = query;
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        string Doctor_Name = reader.GetString(0);




                        doctor staff = new doctor(Doctor_Name, username, password);
                        return staff;

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
    public static string Register_doctor(doctor emp)
    {
        string query = String.Format("SELECT COUNT(*) FROM Employees WHERE Name = '{0}'", emp.Doctor_Name);
        try
        {
            conn.Open();
            command.CommandText = query;

            int amountOfPatient = (int)command.ExecuteScalar();
            if (amountOfPatient < 1)
            {
                query = String.Format("INSERT INTO Employees (username, password ," +
                                        "name,Job_position,address,Tel,Diagnose_group)" +
                                        " VALUES('{0}', '{1}','{2}', 'แพทย์', '{3}', '{4}','{5}')",
                                      emp.username,
                                      emp.password,
                                      emp.Doctor_Name,
                                     
                                      emp.address_doctor,
                                      emp.Tel_doctor,
                                      emp.diserse_group_name);

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
    public static doctor show_namedoctor(string id_name)
    {
        string query = string.Format("Select Employees_id from Employees where name= '{0}'", id_name);

        try
        {
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {


                int doctor_id = reader.GetInt32(0);
                doctor d = new doctor(doctor_id);
                return d;
            }

        }
        finally
        {
            conn.Close();
        }
        return null;
    }

    public static ArrayList show_name(string job_position)
    {
        ArrayList list = new ArrayList();
        string query = string.Format("Select Employees_id,name from Employees where Job_position = '{0}'",job_position);

        try
        {
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                int doc_id = reader.GetInt32(0);
                string doc_name = reader.GetString(1);
                doctor de = new doctor(doc_id,doc_name);
               list.Add(de);
            }

        }
        finally
        {
            conn.Close();
        }
        return list;
    }
}