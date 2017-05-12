using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for diagnose
/// </summary>
public class diagnose
{
    private static SqlConnection conn;
    private static SqlCommand command;
    public int diagnose_ID { get; set; }
    public string Symptoms_host { get; set; }
    public string Subsymptom { get; set; }
    public string result_comment { get; set; }
    public int Symptoms_ID { get; set; }
    public string Diagnose_name { get; set; }
    public string Group_Diagnose_name { get; set; }
    public int Group_Diagnose_ID { get; set; }
    static diagnose()
    {
        /*     string strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
             conn = new MySqlConnection(strConnString);
             command = new MySqlCommand("", conn); */

        string connectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        conn = new SqlConnection(connectionString);
        command = new SqlCommand("", conn);
    }

    
    public diagnose(int diagnose_ID,string Symptoms_host,string Subsymptom, string result_comment,int Symptoms_ID
                    , string Diagnose_name, string Group_Diagnose_name,int Group_Diagnose_ID)
    {
        this.diagnose_ID = diagnose_ID;
        this.Symptoms_host = Symptoms_host;
        this.Subsymptom = Subsymptom;
        this.result_comment = result_comment;
        this.Symptoms_ID = Symptoms_ID;
        this.Diagnose_name = Diagnose_name;
        this.Group_Diagnose_name = Group_Diagnose_name;
        this.Group_Diagnose_ID = Group_Diagnose_ID;
    }
    public diagnose(string Symptoms_host, string Subsymptom, string result_comment
                , string Diagnose_name)
    {
    
        this.Symptoms_host = Symptoms_host;
        this.Subsymptom = Subsymptom;
        this.result_comment = result_comment;
        this.Diagnose_name = Diagnose_name;
    }
    public diagnose(string Diagnose_name, int Group_Diagnose_ID)
    {

        this.Diagnose_name = Diagnose_name;
        this.Group_Diagnose_ID = Group_Diagnose_ID;
    }

    public diagnose(string Group_Diagnose_name)
    {

        this.Group_Diagnose_name = Group_Diagnose_name;
    }

    public static diagnose Diagnose_data_result(int diagnose_id)
     {
           string query = string.Format("select Diagnose_name,Diagnose_group from Diagnose where Diagnose_ID = {0}", diagnose_id);

         try
         {
             conn.Open();
             command.CommandText = query;
             SqlDataReader reader = command.ExecuteReader();
             while (reader.Read())
             {

           
                 string Diagnose_name = reader.GetString(0);
                int group_id = reader.GetInt32(1);
                 diagnose dia = new diagnose(Diagnose_name,group_id);
                return dia;
             }
       
         }
         finally
         {
             conn.Close();
         }
        return null;
    }



    public static diagnose Diagnose_data_group_id(int diagnose_id)
    {
        string query = string.Format("select Name_diagnose from Diagnose_group where Diagnose_group = {0}", diagnose_id);

        try
        {
            conn.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {


                string Group_Diagnose_name = reader.GetString(0);
         
                diagnose dia = new diagnose(Group_Diagnose_name);
                return dia;
            }

        }
        finally
        {
            conn.Close();
        }
        return null;
    }
    /*

       public static int num_symtoms_Diagnose(string symtom)
       {
           string query = string.Format("SELECT COUNT(Diagnose.Diagnose_name),COUNT(Symptoms_detail.subSymtoms)," +
                                        "COUNT(Symptoms_detail.Symptoms_host),COUNT(Symptoms_detail.result_comment)" +
                                         "FROM Diagnose" +
                                         "INNER JOIN Symptoms_detail ON Symptoms_detail.Diagnose_ID = Diagnose.Diagnose_ID" +
                                         "INNER JOIN Symptoms ON Symptoms.Symptoms_ID = Symptoms_detail.Symptoms_ID" +
                                         "Where Symptoms_detail.Symptoms_host LIKE '%{0}%' ", symtom);

           try
           {
               conn.Open();
               command.CommandText = query;
               int amountOfUsers = (int)command.ExecuteScalar();
               if (amountOfUsers > 0)
               {
                   return 1;
               }
               else
               {
                   return 0;
               }

           }
           finally
           {
               conn.Close();
           }
           return 0;
       }
       */
}