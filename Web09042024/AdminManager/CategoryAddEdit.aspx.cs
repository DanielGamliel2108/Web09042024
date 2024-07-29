using BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace Web09042024.AdminManager
{
    public partial class CategoryAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string categoryId = Request["Cid"] + "";
                if (string.IsNullOrEmpty(categoryId))
                {
                    categoryId = "-1";
                }
                else
                {
                    int id = int.Parse(categoryId); // המרה של המשתנה למספר שלם, לצורך חיפוש במאגר הקטגוריות

                    Category category = Category.GetById(id);
                    if (category != null)
                    {
                        TxtCategoryName.Text = category.CategoryName;
                        TxtCategoryDescription.Text = category.CategoryDescription;
                        TxtAvCategoryCode.Text = category.AvCategoryCode.ToString();
                        HidCid.Value = categoryId;
                    }
                    else
                    {
                        categoryId = "-1"; // אם לא נמצאה קטגוריה, נגדיר את הערך ל- -1
                    }
                }
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (HidCid.Value == "-1") // הוספת קטגוריה חדשה
            {
                sql = "INSERT INTO T_Category (CategoryName, CategoryDescription, CategoryImageName, AvCategoryCode, DateAdded) VALUES ";
                sql += $"(N'{TxtCategoryName.Text}', N'{TxtCategoryDescription.Text}', {TxtAvCategoryCode.Text}, GETDATE())";
            }
            else
            {
                sql = "UPDATE T_Category SET ";
                sql += $"CategoryName = N'{TxtCategoryName.Text}', ";
                sql += $"CategoryDescription = N'{TxtCategoryDescription.Text}', ";
                sql += $"AvCategoryCode = {TxtAvCategoryCode.Text} ";
                sql += $"WHERE Cid = {HidCid.Value}";
            }

            string connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString; // שליפת מחרוזת ההתחברות מתוך קובץ הגדרות האפליקציה / שרת web.config

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open(); // פתיחת הצינור לבסיס הנתונים

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery(); // הפעלת השאילתה שלא מחזירה נתונים כלומר מחזירה אינסרט או אפדייט
                }
            }

            // טעינה מחודשת של רשימת הקטגוריות אל האפליקציה
            List<Category> categories = (List<Category>)Category.GetAll();
            Application["Categories"] = categories; // שמירת רשימת הקטגוריות באפליקציה

            // Feedback to the user
            Response.Write("<script>alert('Category saved successfully');</script>");

            Response.Redirect("/CategoryList.aspx");
        }
    }
}
