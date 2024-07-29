using BLL;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace Web09042024.AdminManager
{
    public partial class ClientList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // מדובר בטעינה ראשונה של העמוד
            {
                // נשלוף את רשימת הלקוחות מתוך האפליקשיין
                // נקשר את רשימת הלקוחות לפקד רפיטר
                // נבצע קשירה של הנתונים לפקד הריפטר באמצעות הפעלת הפונקציה
                // Bind()
                List<Client> LstClients;
                LstClients = (List<Client>)Application["Clients"];

                // קישור רשימת הלקוחות עם הריפטר
                RptClient.DataSource = LstClients;
                // עבור כל פריט במקור הנתונים , יתבצע שכפול של האייטם טמפלייט של הריפטר
                RptClient.DataBind(); //  קשירת הנתונים לריפטר 
            }
        }
    }
}
