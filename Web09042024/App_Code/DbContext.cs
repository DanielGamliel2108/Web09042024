using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DATA
{
    public class DbContext
    {
        public string Connstr {  get; set; }//שדה עבור מחרוזת התחברות לבסיס הנתונים
        public SqlConnection Conn {  get; set; }//שדה עבור אובייקט הצינור לבסיס הנתונים

        public DbContext()
        {
            //טעינת הגדרות מחרוזת ההתחברות, יצירת אובייקט צינור ופתיחת הצינור
            Connstr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            Conn = new SqlConnection(Connstr);
            Conn.Open();
        }
        public void Close()
        {
            Conn.Close();//סגירת הצינור
        }
        public int ExecuteNonQuery(string Sql)
        {
            SqlCommand Cmd = new SqlCommand(Sql,Conn);//יצירת אובייקט תותח פקודות
            return Cmd.ExecuteNonQuery();
        }

        public DataTable Execute(string Sql)//הפונקציה משמשת לשליפת הנתונים מבסיס הנתונים 
        {
            SqlCommand Cmd = new SqlCommand(Sql,Conn);//יצירת אובייקט תותח פקודות 
            SqlDataAdapter Da = new SqlDataAdapter(Cmd); //יצירת אובייקט מסוג מתאם נתונים  
            DataTable Dt = new DataTable();//יצירת אובייקט מסוג טבלת נתונים
            Da.Fill(Dt);//מילוי טבלת הנתונים בתוצאות הפעלת השאילתה 
            return Dt;//החזרת טבלת הנתונים 
        }


    }
}