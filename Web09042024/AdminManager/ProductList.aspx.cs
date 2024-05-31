﻿using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web09042024.AdminManager
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // מדובר בטעינה ראשונה של העמוד
            {
                // נשלוף את רשימת המוצרים מתוך האפליקשיין
                // נקשר את רשימת המוצרים לפקד רפיטר
                // נבצע קשירה של הנתונים לפקד הריפטר באמצעות הפעלת הפונקציה
                // Bind()
                List<Product> LstProd;
                LstProd = (List<Product>)Application["Products"];

                // קישור רשימת המוצרים עם הריפטר
                RptProd.DataSource = LstProd;
                // עבור כל פריט במקור הנתונים , יתבצע שכפול של האייטם טמפלייט של הרשיפטר
                RptProd.DataBind(); //  קשירת הנתונים לריפטר 
            }
        }
    }
}