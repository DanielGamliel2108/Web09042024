using BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace Web09042024.AdminManager
{
    public partial class CityAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string cityCode = Request["CityCode"] + "";
                if (string.IsNullOrEmpty(cityCode))
                {
                    cityCode = "-1";
                }
                else
                {
                    int id = int.Parse(cityCode); // המרה של המשתנה למספר שלם, לצורך חיפוש במאגר הערים

                    City city = City.GetById(id);
                    if (city != null)
                    {
                        TxtCityName.Text = city.CityName;
                        TxtCityStatus.Text = city.CityStatus;
                        HidCityCode.Value = cityCode;
                    }
                    else
                    {
                        cityCode = "-1"; // אם לא נמצאה עיר, נגדיר את הערך ל- -1
                    }
                }
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (HidCityCode.Value == "-1") // הוספת עיר חדשה
            {
                sql = "INSERT INTO T_City (CityName, CityStatus, CityDateAdded) VALUES ";
                sql += $"(N'{TxtCityName.Text}', N'{TxtCityStatus.Text}', GETDATE())";
            }
            else
            {
                sql = "UPDATE T_City SET ";
                sql += $"CityName = N'{TxtCityName.Text}', ";
                sql += $"CityStatus = N'{TxtCityStatus.Text}' ";
                sql += $"WHERE CityCode = {HidCityCode.Value}";
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

            // טעינה מחודשת של רשימת הערים אל האפליקציה
            List<City> cities = City.GetAll();
            Application["Cities"] = cities; // שמירת רשימת הערים באפליקציה

            // Feedback to the user
            Response.Write("<script>alert('City saved successfully');</script>");

            Response.Redirect("/CityList.aspx");
        }
    }
}
