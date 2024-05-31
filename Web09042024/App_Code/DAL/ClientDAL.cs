using BLL;
using DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DAL
{
    public class ClientDAL
    {
        public static List<Client> GetAll()
        {
            DbContext Db = new DbContext();//יצירת אובייקט מסוג גישת לבסיס הנתונים 
            string Sql = "SELECT * FROM T_Product";//הגדרת משפט השאילתה
            DataTable Dt = Db.Execute(Sql);//הפעלת השאילתה ורבלת התוצאות לתוך טבלת נתונים

            //נעבור על כל הנתונים שחזרו ונכניס לתוך רשימה של מוצרים

            List<Client> LstClient = new List<Client>(); // יצירת רשימה של המוצרים
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                Client Tmp = new Client()
                {
                    ClientID = int.Parse(Dt.Rows[i]["ClientID"] + ""),
                    ClientName = Dt.Rows[i]["ClientName"] + "",
                    ClientLastname = Dt.Rows[i]["ClientLastname"] + "",
                    ClientAddress = Dt.Rows[i]["ClientAddress"] + "",
                    ClientCity = Dt.Rows[i]["ClientCity"] + "",
                    ClientPhone = Dt.Rows[i]["ClientCity"] + "",
                    ClientMail = Dt.Rows[i]["ClientMail"] + "",
                    ClientPassword = Dt.Rows[i]["ClientPassword"] + "",
                  
                };
                LstClient.Add(Tmp);
            }
            Db.Close();
            return LstClient;
        }

        public static Client GetById(int Id)
        {
            DbContext Db = new DbContext();//יצירת אובייקט מסוג גישת לבסיס הנתונים 
            string Sql = $"SELECT * FROM T_Client WHERE ClientID ={Id}";//הגדרת משפט השאילתה
            DataTable Dt = Db.Execute(Sql);//הפעלת השאילתה ורבלת התוצאות לתוך טבלת נתונים
                                           //נעבור על כל הנתונים שחזרו ונכניס לתוך רשימה של מוצרים
            Client Tmp = null;
            if (Dt.Rows.Count > 0)
            {
                Tmp = new Client()
                {
                    ClientID = int.Parse(Dt.Rows[0]["ClientID"] + ""),
                    ClientName = Dt.Rows[0]["ClientName"] + "",
                    ClientLastname = Dt.Rows[0]["ClientLastname"] + "",
                    ClientAddress = Dt.Rows[0]["ClientAddress"] + "",
                    ClientCity = Dt.Rows[0]["ClientCity"] + "",
                    ClientPhone = Dt.Rows[0]["ClientCity"] + "",
                    ClientMail = Dt.Rows[0]["ClientMail"] + "",
                    ClientPassword = Dt.Rows[0]["ClientPassword"] + "",
                };
            }
            Db.Close();
            return Tmp;
        }
    }
}