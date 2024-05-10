using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web09042024
{
    public partial class Register1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)//טעינה ראשונה של העמוד
            {
                List<City> LstCity = (List<City>)Application["Cities"];//שליפת רשימת הערים מתוך האפליקיישן

                for (int i = 0; i < LstCity.Count; i++)
                {
                    DDLCity.Items.Add(new ListItem(LstCity[i].CityName, LstCity[i].CityCode + ""));
                }
                //מילוי תיבת רשימה באופן דינאמי
                DDLCity.DataSource = LstCity;//הגדרת מקור הנתונים ,יכול להיות מערך,רשימה,אוסף או כל מבנה נתונים אחר
                DDLCity.DataTextField = "CityName";//הגדרת השדה שישמש עבור התצוגה
                DDLCity.DataValueField = "CityCode";//הגדרת השדה שישמש עבור המפתח של הפריט
                DDLCity.DataBind();//הכנסת החיבור למקור הנתונים לפעולה
            }
        }

        protected void BtnReg_Click(object sender, EventArgs e)
        {
            string FirstName = TxtFirstName.Text;
            string LastName = TxtLastName.Text;
            string Email = TxtEmail.Text;
            string City = DDLCity.SelectedValue;
            string Password = TxtPass.Text;
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(City) || string.IsNullOrEmpty(Password))
            {
                LtlMsg.Text = "כל השדות חייבים להיות מלאים";
                return;
            }
            else
            {
                List<Client> LstClient = (List<Client>)Application["Clients"];

                bool EmailExists = true;
                foreach (Client client in LstClient)
                {
                    if (client.ClientMail == Email)
                    {
                        EmailExists = true;
                        break;
                    }
                }
                if (EmailExists)
                {
                    LtlMsg.Text = "האימייל שהכנסת קיים במערכת";
                }
                else
                {
                    Client newClient = new Client()
                    {
                        ClientName = FirstName,
                        ClientLastname = LastName,
                        ClientMail = Email,
                        ClientPassword = Password,
                        ClientCity = City,
                    };


                    LstClient.Add(newClient);
                    Application["Clients"] = LstClient;
                    Session["RegisteredClient"] = newClient;
                    Response.Redirect("ProductList.aspx");

                }
            }
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {


        }

        protected void LogIn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}