using BLL;
using DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DAL
{
    public class ProductDAL
    {
        public static List<Product> GetAll()
        {
            DbContext Db = new DbContext();//יצירת אובייקט מסוג גישת לבסיס הנתונים 
            string Sql = "SELECT * FROM T_Product";//הגדרת משפט השאילתה
            DataTable Dt = Db.Execute(Sql);//הפעלת השאילתה ורבלת התוצאות לתוך טבלת נתונים

            //נעבור על כל הנתונים שחזרו ונכניס לתוך רשימה של מוצרים
           
            List<Product> LstProd = new List<Product>(); // יצירת רשימה של המוצרים
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                Product Tmp = new Product()
                {
                    ProductCode = int.Parse(Dt.Rows[i]["ProductCode"] + ""),
                    ProductName = Dt.Rows[i]["ProductName"] + "",
                    ProductPrice = float.Parse(Dt.Rows[i]["ProductPrice"] + ""),
                    ProductDescription = Dt.Rows[i]["ProductDescription"] + "",
                    ProductCategoryCode = int.Parse(Dt.Rows[i]["ProductCategoryCode"] + ""),
                    ProductImageName = Dt.Rows[i]["ProductImageName"] + ""
                };
                LstProd.Add(Tmp);
            }
            Db.Close();
            return LstProd;
        }
        public static Product GetById(int Id)
        {
            DbContext Db = new DbContext();//יצירת אובייקט מסוג גישת לבסיס הנתונים 
            string Sql = $"SELECT * FROM T_Product WHERE ProductCode ={Id}";//הגדרת משפט השאילתה
            DataTable Dt = Db.Execute(Sql);//הפעלת השאילתה ורבלת התוצאות לתוך טבלת נתונים
                                           //נעבור על כל הנתונים שחזרו ונכניס לתוך רשימה של מוצרים
            Product Tmp = null;
            if(Dt.Rows.Count > 0)
            {
                Tmp = new Product()
                {
                    ProductCode = int.Parse(Dt.Rows[0]["ProductCode"] + ""),
                    ProductName = Dt.Rows[0]["ProductName"] + "",
                    ProductPrice = float.Parse(Dt.Rows[0]["ProductPrice"] + ""),
                    ProductDescription = Dt.Rows[0]["ProductDescription"] + "",
                    ProductCategoryCode = int.Parse(Dt.Rows[0]["ProductCategoryCode"] + ""),
                    ProductImageName = Dt.Rows[0]["ProductImageName"] + ""
                };
            }
            
            Db.Close();
            return Tmp;
        }
        public static void Save(Product product)
        {
            DbContext Db = new DbContext(); // יצירת אובייקט מסוג גישה לבסיס הנתונים
            string Sql = "";
            if (product.ProductCode == -1)
            {
                Sql = $"INSERT INTO T_Product (ProductName, ProductPrice, ProductDescription, ProductImageName, ProductCategoryCode, ProductDateAdded) VALUES ('{product.ProductName}', {product.ProductPrice}, '{product.ProductDescription}', '{product.ProductImageName}', {product.ProductCategoryCode}, GETDATE())";
            }
            else
            {
                Sql = $"UPDATE T_Product SET ProductName='{product.ProductName}', ProductPrice={product.ProductPrice}, ProductDescription='{product.ProductDescription}', ProductImageName='{product.ProductImageName}', ProductCategoryCode={product.ProductCategoryCode}, ProductStatus='{product.ProductStatus}' WHERE ProductCode={product.ProductCode}";
            }
            DbContext db = new DbContext();
            Db.ExecuteNonQuery(Sql); // הפעלת השאילתה לביצוע פעולה על בסיס הנתונים
            
        }
    }
    
}