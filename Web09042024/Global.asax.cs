using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Data;//בשביל קורא הנתונים datareader
using System.Data.SqlClient;//בשביל האובייקטים לעבודה מול בסיס הנתונים
using System.Configuration; // שימוש בספריית הקונפגורציה של חיבור המחרוזת
using DATA;
using System.IO;

namespace Web09042024
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["Products"] = Product.GetAll();

            /*Product p;
            List<Product> LstProd = new List<Product>();

            string ConnStr = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString; // שליפת מחרוזת ההתחברות מתוך קובץ הגדרות האפליקציה / שרת web.config
            SqlConnection Conn = new SqlConnection(ConnStr); // יצירת אובייקט מסוג צינור והגדרת מחרוזת ההתחברות של הצינור לבסיס הנתונים 

            //Conn.ConnectionString = ConnStr; // הגדרת מחרוזת ההתחברות לאחר יצירת האובייקט, זו אופציה נוספת להגדרה

            Conn.Open(); // פתיחת הצינור לבסיס הנתונים

           string Sql = "SELECT * FROM T_Product";

            SqlCommand Cmd = new SqlCommand(Sql, Conn);

            //Cmd.Connection = Conn;
            //Cmd.CommandText = Sql;

            SqlDataReader Dr = null;

            Dr = Cmd.ExecuteReader(); // הפעלת השאילתה וקבלת תוצאות השאילתה לתוך אובייקט קורא נתונים 

            while (Dr.Read())
            {
                p = new Product()
                {
                    ProductCode = int.Parse(Dr["ProductCode"] + ""),
                    ProductName = Dr["ProductName"] + "",
                    ProductPrice = float.Parse(Dr["ProductPrice"] + ""),
                    ProductDescription = Dr["ProductDescription"] + "",
                    ProductImageName = Dr["ProductImageName"] + "",
                    ProductCategoryCode = int.Parse(Dr["ProductCategoryCode"] + ""),
                    ProductStatus = Dr["ProductStatus"] + "",
                    ProductDateAdded = DateTime.Parse(Dr["ProductDateAdded"] + "")
                };
                LstProd.Add(p); // הוספת המוצר לרשימת המוצרים
            }
            Application["Products"] = LstProd; // שמירת רשימת המוצרים באפליקשיין
            
            Conn.Close();*/


            //----------------------///
            /*Product p;//יצירת משתנה ייחוס מסוג מוצר
            List<Product> LstProd = new List<Product>();//יצירת רשימה של מוצרים
            //הגדרת מחרוזת התחברות לבסיס הנתונים 
            string Connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Ecom.mdf;Integrated Security=True;"; 
            SqlConnection Conn=new SqlConnection(Connstr);//יצירת אובייקט מסוג צינור והגדרת מחרוזת התחברות של הצינור לבסיס הנתונים 
            //Conn.ConnectionString = Connstr;//הגדרת מחרוזת ההתחברות לאחר יצירת האובייקט , זו אופציה נוספת להגדרה
            Conn.Open();//פתיחת הצינור לבסיס הנתונים 
            string Sql = "SELECT * FROM T_Product";
            SqlCommand Cmd = new SqlCommand(Sql, Conn);

            //Cmd.Connection = Conn;
            //Cmd.CommandText = Sql;
            SqlDataReader Dr = null;
            Dr = Cmd.ExecuteReader();//הפעלת השאילתה וקבלת תוצאות השאילתה לתוך האובייקט קורא נתונים
            while (Dr.Read())
            {
                p = new Product() { 
                    ProductCode = int.Parse(Dr["ProductCode"]+""),
                    ProductName = Dr["ProductName"]+"",
                    ProductPrice = float.Parse(Dr["ProductPrice"]+""),
                    ProductDescription = Dr["ProductDescription"]+"",
                    ProductImageName = Dr["ProductImageName"]+"",
                    ProductCategoryCode =int.Parse (Dr["ProductCategoryCode"]+""),
                    ProductStatus = Dr["ProductStatus"]+"",
                    ProductDateAdded = DateTime.Parse(Dr["ProductDateAdded"]+"")
                };
                LstProd.Add(p);//הוספת המוצר לרשימת המוצרים
            }
            Application["Products"] = LstProd;//שמירת רשימת המוצרים באפליקיישן */

            List<Client> LstClient = new List<Client>();//הגדרת רשימה עבור לקוחות

            Client Tmp;
            Tmp = new Client()
            {
                ClientMail = "daniel21@gmail.com",
                ClientPassword = "2323",
                ClientID = 3,
                ClientName = "daniel",
                ClientLastname = "gamliel",
                ClientAddress = "gedera"
            };
            LstClient.Add(Tmp);


            Tmp = new Client()
            {
                ClientMail = "nati21@gmail.com",
                ClientPassword = "1212",
                ClientID = 99,
                ClientName = "nati",
                ClientLastname = "azar",
                ClientAddress = "Ashkelon"
            };
            LstClient.Add(Tmp);


            Tmp = new Client()
            {
                ClientMail = "ben21@gmail.com",
                ClientPassword = "4545",
                ClientID = 88,
                ClientName = "ben",
                ClientLastname = "sinvani",
                ClientAddress = "kidron"
            };
            LstClient.Add(Tmp);

            Tmp = new Client()
            {
                ClientMail = "orel21@gmail.com",
                ClientPassword = "6767",
                ClientID = 2,
                ClientName = "orel",
                ClientLastname = "cohen",
                ClientAddress = "kirat gat"
            };
            LstClient.Add(Tmp);

            Tmp = new Client()
            {
                ClientMail = "snir21@gmail.com",
                ClientPassword = "8989",
                ClientID = 45,
                ClientName = "snir",
                ClientLastname = "halfon",
                ClientAddress = "yavne"
            };
            LstClient.Add(Tmp);
            Application["Clients"] = LstClient;//שמירת רשימת הלקוחות בתוך הזכרון מסוג אפליקיישן

            /*List<City> LstCity = new List<City>();////הגדרת רשימה עבור לקוחות

            City cty;
            cty = new City()
            {
                CityName = "Gedera",
                CityCode = "100",
            };
            LstCity.Add(cty);

          
            cty = new City()
            {
                CityName = "Ashkelon",
                CityCode = "20",
            };
            LstCity.Add(cty);

            cty = new City()
            {
                CityName = "Ashdod",
                CityCode = "30",
            };
            LstCity.Add(cty);
            cty = new City()
            {
                CityName = "Rehovot",
                CityCode = "40",
            };
            LstCity.Add(cty);
            cty = new City()
            {
                CityName = "petah tikva",
                CityCode = "50",
            };
            LstCity.Add(cty);
            Application["Cities"] = LstCity;

            //List Of Categories
            List<Category> Categories = new List<Category>();
            Categories.Add(new Category()
            {
                CategoryCode = 10,
                CategoryName = "Cars",
                CategoryDescription = "Best Car you can find",
                CategoryImageName = "Cars"
            });

            Categories.Add(new Category()
            {
                CategoryCode = 20,
                CategoryName = "TV",
                CategoryDescription = "All You Need For comfortable viewing",
                CategoryImageName = "TV"
            });

            Categories.Add(new Category()
            {
                CategoryCode = 30,
                CategoryName = "Candles",
                CategoryDescription = "Candles for your house",
                CategoryImageName = "Candles"
            });
            Application["Categories"] = Categories;

            //List Of Products
            *//*List<Product> LstProduct = new List<Product>();
            LstProduct.Add(new Product()
            {
                ProductCode = 1001,
                ProductName = "BMW",
                ProductPrice = 25000,
                ProductDescription = "A quality car is the main thing",
                ProductImageName = "BMW",
                ProductCategoryCode = 10,
                ProductStatus = "Available",
                ProductDateAdded =DateTime.Now
            });

            LstProduct.Add(new Product()
            {
                ProductCode = 1002,
                ProductName = "Samsong TV",
                ProductPrice = 5000,
                ProductDescription = "The best TV",
                ProductImageName = "Samsong",
                ProductCategoryCode = 20,
                ProductStatus = "Not Available",
                ProductDateAdded = DateTime.Now
            });

            LstProduct.Add(new Product()
            {
                ProductCode = 1003,
                ProductName = "Scented candle",
                ProductPrice = 15,
                ProductDescription = "A candle that will improve the smell of your home",
                ProductImageName = "Candle",
                ProductCategoryCode = 30,
                ProductStatus = "In Stock",
                ProductDateAdded = DateTime.Now
            });
            Application["Products"] = LstProduct;*//*
            Conn.Close();//סגירת הצינור לבסיס הנתונים*/
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}