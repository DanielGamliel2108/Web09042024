using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web09042024
{
    public partial class Profile1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)//טעינה ראשונה של העמוד
            {
                List<City> LstCity = (List<City>)Application["Cities"];//שליפת רשימת הערים מתוך האפליקיישן


                for (int i = 0; i < LstCity.Count; i++)
                {
                    DDLProfileCity.Items.Add(new ListItem(LstCity[i].CityName, LstCity[i].CityCode + ""));
                }
                //מילוי תיבת רשימה באופן דינאמי
                DDLProfileCity.DataSource = LstCity;//הגדרת מקור הנתונים ,יכול להיות מערך,רשימה,אוסף או כל מבנה נתונים אחר
                DDLProfileCity.DataTextField = "CityName";//הגדרת השדה שישמש עבור התצוגה
                DDLProfileCity.DataValueField = "CityCode";//הגדרת השדה שישמש עבור המפתח של הפריט
                DDLProfileCity.DataBind();//הכנסת החיבור למקור הנתונים לפעולה
            }
        }
        protected void BtnProfile_Click(object sender, EventArgs e)
        {
            if (Session["Login"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            List<City> LstCity = (List<City>)Application["Cities"]; // הגדרת רשימה עבור ערים
            List<Client> LstClient = (List<Client>)Application["Clients"]; // הגדרת רשימה עבור לקוחות
            Client tmp = (Client)Session["Login"];
            for (int i = 0; i < LstClient.Count; i++) // (Client) לולאה שעוברת על מחלקה של הלקוחות
            {
                if (LstClient[i].ClientMail == tmp.ClientMail) // אם נמצא לקוח עם המייל והסיסמה אז כנס
                {
                    LstClient[i].ClientName = TextProfileFName.Text;
                    LstClient[i].ClientCity = DDLProfileCity.SelectedValue;
                    Session["Login"] = LstClient[i];
                    Response.Redirect("ProductList.aspx"); // נעביר את הגולש לעמוד רשימת מוצרים

                }
            }
        }
    }
}