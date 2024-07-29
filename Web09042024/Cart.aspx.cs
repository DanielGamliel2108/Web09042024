using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web09042024.AdminManager
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCart();
            }
        }

        private void BindCart()
        {
            var cart = Session["Cart"] as List<ProductList.CartItem>;
            CartGridView.DataSource = cart;
            CartGridView.DataBind();

            if (cart != null)
            {
                decimal total = cart.Sum(item => item.Price * item.Quantity);
                TotalLabel.Text = "סה\"כ לתשלום: " + total.ToString("C");
            }
        }

        protected void CartGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var cart = Session["Cart"] as List<ProductList.CartItem>;
            int index = e.RowIndex;
            cart.RemoveAt(index);
            BindCart();
        }

        protected void CheckoutButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaymentSuccess.aspx");
        }
    }
}
