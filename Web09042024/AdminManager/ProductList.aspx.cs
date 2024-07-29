using BLL;
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
            if (!IsPostBack)
            {
                List<Product> LstProd;
                LstProd = (List<Product>)Application["Products"];
                RptProd.DataSource = LstProd;
                RptProd.DataBind();
            }
        }

        internal class CartItem
        {
            public int Quantity { get; internal set; }
            public int Price { get; internal set; }
        }
    }
}
