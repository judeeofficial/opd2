using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Patient
/// </summary>
public class Patient
{
    //  private static MySqlConnection conn;
    // private static MySqlCommand command;
    private static SqlConnection conn;
    private static SqlCommand command;

    public int Patient_id { get; set; }
    public string name { get; set; }
    public string age { get; set; }
    public string birthday { get; set; }
    public string belong_to { get; set; }
    public string Tel_working { get; set; }
    public string address { get; set; }
    public string Tel_myself { get; set; }
    public string Name_dad { get; set; }
    public string Name_mom { get; set; }
    public string  Name_husband_wife { get; set; }
    public string Name_parent { get; set; }
    public string status_patient { get; set; }
    public string Address_parent { get; set; }
    public string Tel_work_parent { get; set; }
    public string Tel_home { get; set; }
    public string type_patient { get; set; }

    static Patient()
    {
        /*     string strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
             conn = new MySqlConnection(strConnString);
             command = new MySqlCommand("", conn); */

        string connectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }

    public Patient(int Patient_id, string name ,
    string age,string birthday ,string belong_to, string Tel_working, string address,
    string Tel_myself, string Name_dad,string Name_mom, string Name_husband_wife,
    string Name_parent,string status_patient, string Address_parent,string Tel_home, string type_patient)
    {
        //
        // TODO: Add constructor logic here
        //

        this.Patient_id = Patient_id;
        this.name = name;
        this.age = age;
        this.birthday = birthday;
        this.belong_to = belong_to;
        this.Tel_working = Tel_working;
        this.address = address;
        this.Tel_myself = Tel_myself;
        this.Name_dad = Name_dad;
        this.Name_mom = Name_mom;
        this.Name_husband_wife = Name_husband_wife;
        this.Name_parent = Name_parent;
        this.status_patient = status_patient;
        this.Address_parent = Address_parent;
        this.Tel_home = Tel_home;
        this.type_patient = type_patient;
    }

    public Patient(string name,
    string age, string birthday, string belong_to, string Tel_working, string address,
    string Tel_myself, string Name_dad, string Name_mom, string Name_husband_wife,
    string Name_parent,string status_patient, string Address_parent, string Tel_home, string type_patient)
    {

        this.name = name;
        this.age = age;
        this.birthday = birthday;
        this.belong_to = belong_to;
        this.Tel_working = Tel_working;
        this.address = address;
        this.Tel_myself = Tel_myself;
        this.Name_dad = Name_dad;
        this.Name_mom = Name_mom;
        this.Name_husband_wife = Name_husband_wife;
        this.Name_parent = Name_parent;
        this.status_patient = status_patient;
        this.Address_parent = Address_parent;
        this.Tel_home = Tel_home;
        this.type_patient = type_patient;
    }
    /*   public static string Register_opdcard1(Patient Patient)
       {
           string query = String.Format("SELECT COUNT(*) FROM patient WHERE Name = '{0}'", Patient.name);
           try
           {
               conn.Open();
               command.CommandText = query;
               int amountOfPatient = (int)command.ExecuteScalar();
               if (amountOfPatient < 1)
               {
                   query = String.Format("INSERT INTO patient (NAME, age) VALUES('{0}', '{1}')",
                                          Patient.name, Patient.age);
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
       */
    //select name, age, birthday, belong_to, Tel_working, address, Tel_myself from patient
    public Patient(string name,
 string age, string birthday, string belong_to, string Tel_working, string address,
 string Tel_myself)
    {

        this.name = name;
        this.age = age;
        this.birthday = birthday;
        this.belong_to = belong_to;
        this.Tel_working = Tel_working;
        this.address = address;
        this.Tel_myself = Tel_myself;
    }
    public static string Register_opdcard(Patient Patient)
    {
        string query = String.Format("SELECT COUNT(*) FROM patient WHERE Name = '{0}'", Patient.name);
        try
        {
            conn.Open();
            command.CommandText = query;
           
            int amountOfPatient = (int)command.ExecuteScalar();
            if (amountOfPatient < 1)
            {
                query = String.Format("INSERT INTO patient (NAME, age ,"+
                                        "birthday,belong_to , Tel_working ,Address,Tel_myself," +
                                        "Name_dad, Name_mom, Name_hasband_wife,"+
                                        " Name_parent,status_parent, Address_parent," +
                                        "Tel_work_parent, Tel_home,type_Patient)" +
                                        " VALUES('{0}', '{1}','{2}', '{3}', '{4}', '{5}', '{6}', '{7}', " +
                                       " '{8}', '{9}', '{10}', '{11}','{12}','{13}','{14}','{15}')",
                                       Patient.name,
                                       Patient.age,
                                       Patient.birthday,
                                       Patient.belong_to,
                                       Patient.Tel_working,
                                       Patient.address,
                                       Patient.Tel_myself,
                                       Patient.Name_dad,
                                       Patient.Name_mom,
                                       Patient.Name_husband_wife,
                                       Patient.Name_parent,
                                       Patient.status_patient,
                                       Patient.Address_parent
                                       ,Patient.Tel_work_parent,
                                       Patient.Tel_home,
                                       Patient.type_patient);
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


    public Patient(int Patient_id)
    {

        this.Patient_id = Patient_id;
    
    }

    public static Patient show_namePatient(string id_name)
    {
        string query = string.Format("Select Patient_id from Patient where NAME = '{0}'", id_name);

        try
        {
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {


                int Pat_id = reader.GetInt32(0);
                Patient p = new Patient(Pat_id);
                return p;
            }

        }
        finally
        {
            conn.Close();
        }
        return null;
    }

    /* public static DataSet showdatapatient(string patient)
     {
         DataSet list = new DataSet();
         SqlDataAdapter dtAdapter = new SqlDataAdapter();

         string query = string.Format("select name,age,birthday,belong_to,Tel_working,address,Tel_myself from patient WHERE name LIKE '{0}'", patient);

         try
         {
             conn.Open();
             command.CommandText = query;

             SqlDataReader reader = command.ExecuteReader();
             while (reader.Read())
             {
                 string name = reader.GetString(0);
                 string Age = reader.GetString(1);
                 string birthday = reader.GetString(2);
                 string belongto = reader.GetString(3);
                 string Telworking = reader.GetString(4);
                 string address = reader.GetString(5);
                 string Telmyself = reader.GetString(6);
                 Patient P = new Patient(name,Age,birthday,belongto, Telworking, address,Telmyself);
                 return P;

                 //   list.Add(P);
                 //Wearable wearable = new Wearable(idwearable, name, type, price, image, review);
                 //list.Add(wearable);
             }
         }
         finally
         {
             conn.Close();
         }

         return list;
     }
     */
    public static DataTable showdatapatient(string patient)
    {
       // DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlDataAdapter dtAdapter = new SqlDataAdapter();

        //   string query = string.Format("select name,age,birthday,belong_to,Tel_working,address,Tel_myself from patient WHERE name LIKE '%{0}%'", patient);
        string query = string.Format("select * from patient WHERE name LIKE '%{0}%'", patient);
        try
        {
            conn.Open();
            command.CommandText = query;
            command.CommandType = CommandType.Text;
       
            dtAdapter.SelectCommand = command;
 
            dtAdapter.Fill(dt);
            dtAdapter = null;
        }
        finally
        {
            conn.Close();
        }

        return dt;
    }



}