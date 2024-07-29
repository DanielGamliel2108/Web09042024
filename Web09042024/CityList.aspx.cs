using System;
using System.Web.UI;

namespace Web09042024
{
    public partial class CityList : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // בדיקה אם ההודעה מוצגת לאחר הרשמה
            if (!IsPostBack && Request.QueryString["registered"] == "true")
            {
                ShowWelcomeMessage();
            }
        }

        protected void btnBackToHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx"); // נתיב לדף הראשי
        }

        private void ShowWelcomeMessage()
        {
            // כאן ניתן להוסיף כל קוד הדרוש כדי להציג את הודעת הברוך הבא
        }
    }
}
