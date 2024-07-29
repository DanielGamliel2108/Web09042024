using BLL;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace Web09042024.AdminManager
{
    public partial class CityList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // מדובר בטעינה ראשונה של העמוד
            {
                // נשלוף את רשימת הערים מתוך האפליקשיין
                // נקשר את רשימת הערים לפקד רפיטר
                // נבצע קשירה של הנתונים לפקד הריפטר באמצעות הפעלת הפונקציה
                // Bind()
                List<City> LstCity;
                LstCity = (List<City>)Application["Cities"];

                // קישור רשימת הערים עם הריפטר
                RptCity.DataSource = LstCity;
                // עבור כל פריט במקור הנתונים, יתבצע שכפול של האייטם טמפלייט של הריפטר
                RptCity.DataBind(); // קשירת הנתונים לריפטר
            }
        }
    }
}
