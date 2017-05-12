using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Symptoms
/// </summary>
public class Symptoms
{
    private static SqlConnection conn;
    private static SqlCommand command;
    public int Symptoms_detail_ID { get; set; }
    public string Symptoms_host { get; set; }
    public string Subsymptom { get; set; }
    public string result_comment { get; set; }
    public int Symptoms_ID { get; set; }
    public int Diagnose_ID { get; set; }

    static Symptoms()
    {
        /*     string strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
             conn = new MySqlConnection(strConnString);
             command = new MySqlCommand("", conn); */

        string connectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }
    public Symptoms(int Symptoms_detail_ID,string Symptoms_host, string Subsymptom, 
        string result_comment,int Symptoms_ID, int Diagnose_ID)
    {
        this.Symptoms_detail_ID = Symptoms_detail_ID;
        this.Symptoms_host = Symptoms_host;
        this.Subsymptom = Subsymptom;
        this.result_comment = result_comment;
        this.Symptoms_ID = Symptoms_ID;
        this.Diagnose_ID = Diagnose_ID;
    }

    public Symptoms(string Symptoms_host, string Subsymptom,
         string result_comment, int Symptoms_ID, int Diagnose_ID)
    {
        this.Symptoms_host = Symptoms_host;
        this.Subsymptom = Subsymptom;
        this.result_comment = result_comment;
        this.Symptoms_ID = Symptoms_ID;
        this.Diagnose_ID = Diagnose_ID;
    }

    public Symptoms(string Symptoms_host, string Subsymptom,
     string result_comment, int Diagnose_ID)
    {
        this.Symptoms_host = Symptoms_host;
        this.Subsymptom = Subsymptom;
        this.result_comment = result_comment;
        this.Diagnose_ID = Diagnose_ID;
    }

    public static string sent_savesym(Symptoms Sym)
    {
        string query = String.Format("SELECT COUNT(*) FROM Symptoms_detail WHERE Symptoms_detail_ID = '{0}'", Sym.Symptoms_detail_ID);
        try
        {
            conn.Open();
            command.CommandText = query;

            int amountOfPatient = (int)command.ExecuteScalar();
            if (amountOfPatient < 1)
            {
                query = String.Format("INSERT INTO Symptoms_detail (Symptoms_host, Sub_Symtoms," +
                                        "result_comment,Symptoms_ID,Diagnose_ID)" +
                                        " VALUES('{0}', '{1}','{2}', '{3}','{4}')",
                                       Sym.Symptoms_host,
                                      Sym.Subsymptom,
                                      Sym.result_comment,
                                    Sym.Symptoms_ID,
                                    Sym.Diagnose_ID
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

    public static Symptoms GetQuiz(int quiz)
    {

     //   ArrayList list = new ArrayList();
        string query = string.Format("select Symptoms_host,Sub_Symtoms,result_comment,Diagnose_ID from Symptoms_detail Where Symptoms_ID = {0} ", quiz);

        try
        {
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
       
                string symtom_host = reader.GetString(0);
                string sub_symtom = reader.GetString(1);
                string result = reader.GetString(2);
                int Diagnose_ID = reader.GetInt32(3);
       

                Symptoms symptoms = new Symptoms(symtom_host, sub_symtom, result, Diagnose_ID);
                return symptoms;
         
            }
        }
        finally
        {
            conn.Close();
        }

        return null;
    }

    public static DataTable showdataquiz(int quiz)
    {
        // DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlDataAdapter dtAdapter = new SqlDataAdapter();

        //   string query = string.Format("select name,age,birthday,belong_to,Tel_working,address,Tel_myself from patient WHERE name LIKE '%{0}%'", patient);
        string query = string.Format("select Symptoms_host,Sub_Symtoms,result_comment,Diagnose_ID from Symptoms_detail  Where Symptoms_ID = {0}  ", quiz);
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

    /*
    public static DataTable showdataquiz()
    {
        // DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlDataAdapter dtAdapter = new SqlDataAdapter();

        //   string query = string.Format("select name,age,birthday,belong_to,Tel_working,address,Tel_myself from patient WHERE name LIKE '%{0}%'", patient);
        string query = string.Format("select Symptoms_host,Sub_Symtoms,result_comment,Diagnose_ID from Symptoms_detail");
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
    /*
    public static Symptoms valid_symtoms_Diagnose(string symtom )
    {
        string query = string.Format("SELECT Diagnose.Diagnose_name,Symptoms_detail.subSymtoms,Symptoms_detail.Symptoms_host" +
                                      "FROM Diagnose"+
                                      "INNER JOIN Symptoms_detail ON Symptoms_detail.Diagnose_ID = Diagnose.Diagnose_ID"+
                                      "INNER JOIN Symptoms ON Symptoms.Symptoms_ID = Symptoms_detail.Symptoms_ID"+
                                      "Where Symptoms_detail.Symptoms_host LIKE '%{1}%' ", symtom);

        try
        {
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int idwearable = reader.GetInt32(0);
                string name = reader.GetString(1);
                string type = reader.GetString(2);
                double price = reader.GetDouble(3);
                string image = reader.GetString(4);
                string review = reader.GetString(5);

                Symptoms wearable = new Symptoms(idwearable, name, type, price, image, review);
                return wearable;
            }
            return null;
        }
        finally
        {
            conn.Close();
        }

    }
    */
    /*  public static string showSymptoms(string patient)
      {

    //      SqlDataAdapter dtAdapter = new SqlDataAdapter();
  //   string query = string.Format("select name,age,birthday,belong_to,Tel_working,address,Tel_myself from patient WHERE name LIKE '%{0}%'", patient);

          string query = string.Format("select * from patient WHERE name LIKE '%{0}%'", patient);

          try
          {
              conn.Open();
              command.CommandText = query;


          }
          finally
          {
              conn.Close();
          }

          return ds;
      }*/









}