using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web09042024
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)//מדובר בטעינה הראשונה של העמוד
            {
                //נשלוף את רשימת המוצרים מתוך האפליקיישן
                //נקשר את רשימת המוצרים לפקד הרפיטר
                //נבצע קשירה של הנתונים לפקד הרפיטר באמצעות הפעלת הפונקציה
                //Bind()
                List<Product> LstProd;
                LstProd = (List<Product>)Application["Products"];

                //קישור רשימת המוצרים עם הרפיטר
                RptProducts.DataSource = LstProd;
                //עבור כל פריט במקור הנתונים , יתבצע שכפול של האייטם טמפלייט של הרפיטר
                RptProducts.DataBind();//קשירת הנתונים לרפיטר
            }
        }
    }
}
