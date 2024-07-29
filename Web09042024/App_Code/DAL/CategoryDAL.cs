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
                    Cid = int.Parse(Dt.Rows[i]["Cid"] + ""),
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
            string Sql = $"SELECT * FROM T_Category WHERE Cid ={Id}";//הגדרת משפט השאילתה
            DataTable Dt = Db.Execute(Sql);//הפעלת השאילתה ורבלת התוצאות לתוך טבלת נתונים
                                           //נעבור על כל הנתונים שחזרו ונכניס לתוך רשימה של מוצרים
            Category Tmp = null;
            if (Dt.Rows.Count > 0)
            {
                Tmp = new Category()
                {
                    Cid = int.Parse(Dt.Rows[0]["Cid"] + ""),
                    CategoryName = Dt.Rows[0]["CategoryName"] + "",
                    CategoryDescription = Dt.Rows[0]["CategoryDescription"] + "",
                    CategoryImageName = Dt.Rows[0]["CategoryImageName"] + "",
                    AvCategoryCode = int.Parse(Dt.Rows[0]["AvCategoryCode"] + ""),
                };
            }

            Db.Close();
            return Tmp;
        }
        public static void Save(Category category)
        {
            DbContext Db = new DbContext(); // יצירת אובייקט מסוג גישה לבסיס הנתונים
            string Sql = "";
            if (category.Cid == -1)
            {
                Sql = $"INSERT INTO T_Category (CategoryName, CategoryDescription, CategoryImageName, AvCategoryCode, DateAdded) VALUES ('{category.CategoryName}', '{category.CategoryDescription}', '{category.CategoryImageName}', {category.AvCategoryCode}, GETDATE())";
            }
            else
            {
                Sql = $"UPDATE T_Category SET CategoryName='{category.CategoryName}', CategoryDescription='{category.CategoryDescription}', CategoryImageName='{category.CategoryImageName}', AvCategoryCode={category.AvCategoryCode} WHERE Cid={category.Cid}";
            }
            DbContext db = new DbContext();
            Db.ExecuteNonQuery(Sql); // הפעלת השאילתה לביצוע פעולה על בסיס הנתונים
        }

    }
}