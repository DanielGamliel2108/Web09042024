using BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web09042024.AdminManager
{
    public partial class ProdAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string Pid = Request["ProductCode"] + "";
                if (string.IsNullOrEmpty(Pid))
                {
                    Pid = "-1";
                }
                else
                {
                    int pid = int.Parse(Pid); // המרה של המשתנה למספר שלם, לצורך חיפוש במאגר המוצרים

                    List<Product> LstProd = (List<Product>)Application["Products"];
                    Product Tmp = Product.GetById(pid);
                    if(Tmp != null)
                    {
                        TxtPname.Text = Tmp.ProductName;
                        TxtPrice.Text = Tmp.ProductPrice + "";
                        TxtPdesc.Text = Tmp.ProductDescription;
                        ImgPicname.ImageUrl = "/image/" + Tmp.ProductImageName;
                        HidPid.Value = Pid;
                    }
                    else
                    {
                        Pid = "-1";//-1 במידה אין תשנה
                    }
                }
            }
        }
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            string ProductImageName ="";
            //נבדוק האם נבחר קובץ
            if (UploadPic.HasFile)
            {
                //נשמור את קובץ התמונה בתיקיית התמונות תחת שם חדש שנייצר בעצמינו
                //נעדכן את השדה שם
                ProductImageName = GlobFunc.GetRandStr(8);
                //"abcdefgh + ""
                string OriginFileName = UploadPic.FileName;//cnndnde.jpeg
                int index = OriginFileName.LastIndexOf(".");
                string Ext = OriginFileName.Substring(index);
                ProductImageName += Ext;//abcdefgh.jpeg
                string FullPath = Server.MapPath("/image/");
                UploadPic.SaveAs(FullPath + ProductImageName);
            }
            else
            {
                int index = ImgPicname.ImageUrl.LastIndexOf('/');
                ProductImageName = ImgPicname.ImageUrl.Substring(index + 1);
            }
            string Sql = "";
            if (HidPid.Value == "-1") // הוספת מוצר חדש
            {
                Sql = "INSERT INTO T_Product (ProductName, ProductPrice, ProductDescription, ProductImageName) VALUES ";
                Sql += $"(N'{TxtPname.Text}', {TxtPrice.Text}, N'{TxtPdesc.Text}', N'{ProductImageName}')";
            }
            else
            {
                Sql = "UPDATE T_Product SET ";
                Sql += $"ProductName = N'{TxtPname.Text}', ";
                Sql += $"ProductPrice = {TxtPrice.Text}, ";
                Sql += $"ProductDescription = N'{TxtPdesc.Text}', ";
                Sql += $"ProductImageName = N'{ProductImageName}' ";
                Sql += $"WHERE ProductCode = {HidPid.Value}";
            }

            string ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString; // שליפת מחרוזת ההתחברות מתוך קובץ הגדרות האפליקציה / שרת web.config

            SqlConnection Conn = new SqlConnection(ConnStr); // יצירת אובייקט מסוג צינור והגדרת מחרוזת ההתחברות של הצינור לבסיס הנתונים 

            Conn.Open(); // פתיחת הצינור לבסיס הנתונים

            SqlCommand Cmd = new SqlCommand(Sql, Conn);

            Cmd.ExecuteNonQuery(); // הפעלת השאילתה שלא מחזירה נתונים כלומר מחזירה אינסרט או אפדייט

            List<Product> LstProd = new List<Product>(); // טעינה מחודשת של רשימת המוצרים אל האפליקשיין

            Sql = "SELECT * FROM T_Product";

            Cmd.CommandText = Sql;

            SqlDataReader Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {
                Product Tmp = new Product()
                {
                    ProductCode = int.Parse(Dr["ProductCode"].ToString()),
                    ProductName = Dr["ProductName"].ToString(),
                    ProductPrice = float.Parse(Dr["ProductPrice"].ToString()),
                    ProductDescription = Dr["ProductDescription"].ToString(),
                    ProductImageName = Dr["ProductImageName"].ToString(),
                };
                LstProd.Add(Tmp); // הוספת המוצר לרשימת המוצרים
            }
            Application["Products"] = LstProd; // שמירת רשימת המוצרים באפליקשיין

            Conn.Close();

            // Feedback to the user
            Response.Write("<script>alert('Product saved successfully');</script>");

            Response.Redirect("/ProductList.aspx");

        }

    }
}