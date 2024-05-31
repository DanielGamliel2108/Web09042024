using BLL;
using DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DAL
{
    public class CategoryDAL
    {
        public static List<Category> GetAll()
        {
            DbContext Db = new DbContext();//יצירת אובייקט מסוג גישת לבסיס הנתונים 
            string Sql = "SELECT * FROM T_Category";//הגדרת משפט השאילתה
            DataTable Dt = Db.Execute(Sql);//הפעלת השאילתה ורבלת התוצאות לתוך טבלת נתונים

            //נעבור על כל הנתונים שחזרו ונכניס לתוך רשימה של מוצרים

            List<Category> LstCat = new List<Category>(); // יצירת רשימה של המוצרים
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                Category Tmp = new Category()
                {
                    CategoryCode = int.Parse(Dt.Rows[i]["CategoryCode"] + ""),
                    CategoryName = Dt.Rows[i]["CategoryName"] + "",
                    CategoryDescription = Dt.Rows[i]["CategoryDescription"] + "",
                    CategoryImageName = Dt.Rows[i]["CategoryImageName"] + "",
                    AvCategoryCode = int.Parse(Dt.Rows[i]["AvCategoryCode"] + ""),
                };
                LstCat.Add(Tmp);
            }
            Db.Close();
            return LstCat;
        }

        public static Category GetById(int Id)
        {
            DbContext Db = new DbContext();//יצירת אובייקט מסוג גישת לבסיס הנתונים 
            string Sql = $"SELECT * FROM T_Category WHERE CategoryCode ={Id}";//הגדרת משפט השאילתה
            DataTable Dt = Db.Execute(Sql);//הפעלת השאילתה ורבלת התוצאות לתוך טבלת נתונים
                                           //נעבור על כל הנתונים שחזרו ונכניס לתוך רשימה של מוצרים
            Category Tmp = null;
            if (Dt.Rows.Count > 0)
            {
                Tmp = new Category()
                {
                    CategoryCode = int.Parse(Dt.Rows[0]["CategoryCode"] + ""),
                    CategoryName = Dt.Rows[0]["CategoryName"] + "",
                    CategoryDescription = Dt.Rows[0]["CategoryDescription"] + "",
                    CategoryImageName = Dt.Rows[0]["CategoryImageName"] + "",
                    AvCategoryCode = int.Parse(Dt.Rows[0]["AvCategoryCode"] + ""),
                };
            }

            Db.Close();
            return Tmp;
        }
    }
}