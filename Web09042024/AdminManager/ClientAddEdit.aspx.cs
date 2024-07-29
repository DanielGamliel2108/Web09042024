using BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace Web09042024.AdminManager
{
    public partial class ClientAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string clientId = Request["ClientID"] + "";
                if (string.IsNullOrEmpty(clientId))
                {
                    clientId = "-1";
                }
                else
                {
                    int id = int.Parse(clientId); // המרה של המשתנה למספר שלם, לצורך חיפוש במאגר הלקוחות

                    Client client = Client.GetById(id);
                    if (client != null)
                    {
                        TxtClientName.Text = client.ClientName;
                        TxtClientLastname.Text = client.ClientLastname;
                        TxtClientAddress.Text = client.ClientAddress;
                        TxtClientCity.Text = client.ClientCity;
                        TxtClientPhone.Text = client.ClientPhone;
                        TxtClientMail.Text = client.ClientMail;
                        TxtClientPassword.Text = client.ClientPassword;
                        HidClientId.Value = clientId;
                    }
                    else
                    {
                        clientId = "-1"; // אם לא נמצא לקוח, נגדיר את הערך ל- -1
                    }
                }
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (HidClientId.Value == "-1") // הוספת לקוח חדש
            {
                sql = "INSERT INTO T_Client (ClientName, ClientLastname, ClientAddress, ClientCity, ClientPhone, ClientMail, ClientPassword) VALUES ";
                sql += $"(N'{TxtClientName.Text}', N'{TxtClientLastname.Text}', N'{TxtClientAddress.Text}', N'{TxtClientCity.Text}', '{TxtClientPhone.Text}', N'{TxtClientMail.Text}', N'{TxtClientPassword.Text}')";
            }
            else
            {
                sql = "UPDATE T_Client SET ";
                sql += $"ClientName = N'{TxtClientName.Text}', ";
                sql += $"ClientLastname = N'{TxtClientLastname.Text}', ";
                sql += $"ClientAddress = N'{TxtClientAddress.Text}', ";
                sql += $"ClientCity = N'{TxtClientCity.Text}', ";
                sql += $"ClientPhone = '{TxtClientPhone.Text}', ";
                sql += $"ClientMail = N'{TxtClientMail.Text}', ";
                sql += $"ClientPassword = N'{TxtClientPassword.Text}' ";
                sql += $"WHERE ClientID = {HidClientId.Value}";
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

            // טעינה מחודשת של רשימת הלקוחות אל האפליקציה
            List<Client> clients = Client.GetAll();
            Application["Clients"] = clients; // שמירת רשימת הלקוחות באפליקציה

            // Feedback to the user
            Response.Write("<script>alert('Client saved successfully');</script>");

            Response.Redirect("/ClientList.aspx");
        }
    }
}
