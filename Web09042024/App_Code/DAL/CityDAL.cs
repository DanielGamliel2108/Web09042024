using BLL;
using DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DAL
{
    public class CityDAL
    {
        public static List<City> GetAll()
        {
            DbContext Db = new DbContext();//יצירת אובייקט מסוג גישת לבסיס הנתונים 
            string Sql = "SELECT * FROM T_City";//הגדרת משפט השאילתה
            DataTable Dt = Db.Execute(Sql);//הפעלת השאילתה ורבלת התוצאות לתוך טבלת נתונים

            //נעבור על כל הנתונים שחזרו ונכניס לתוך רשימה של מוצרים

            List<City> LstCity = new List<City>(); // יצירת רשימה של המוצרים
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                City Tmp = new City()
                {
                    CityCode = int.Parse(Dt.Rows[i]["CityCode"] + ""),
                    CityName = Dt.Rows[i]["CityName"] + "",
                };
                LstCity.Add(Tmp);
            }
            Db.Close();
            return LstCity;
        }

        public static City GetById(int Id)
        {
            DbContext Db = new DbContext();//יצירת אובייקט מסוג גישת לבסיס הנתונים 
            string Sql = $"SELECT * FROM T_City WHERE CityCode ={Id}";//הגדרת משפט השאילתה
            DataTable Dt = Db.Execute(Sql);//הפעלת השאילתה ורבלת התוצאות לתוך טבלת נתונים
                                           //נעבור על כל הנתונים שחזרו ונכניס לתוך רשימה של מוצרים
            City Tmp = null;
            if (Dt.Rows.Count > 0)
            {
                Tmp = new City()
                {
                    CityCode = int.Parse(Dt.Rows[0]["CityCode"] + ""),
                    CityName = Dt.Rows[0]["CityName"] + "",
                };
            }

            Db.Close();
            return Tmp;
        }
    }
}