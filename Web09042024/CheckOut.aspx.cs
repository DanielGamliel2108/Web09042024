using System;
using System.Collections.Generic;

namespace Web09042024
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var cart = Session["Cart"] as List<Web09042024.AdminManager.ProductList.CartItem>;
                if (cart != null)
                {
                    decimal totalPrice = 0;
                    foreach (var item in cart)
                    {
                        totalPrice += item.Quantity * item.Price;
                    }
                    TotalLabel.Text = "סה\"כ לתשלום: " + totalPrice.ToString("C");
                }
            }
        }

        protected void PayButton_Click(object sender, EventArgs e)
        {
            // Perform payment processing here (this is just a placeholder)
            var cardNumber = CardNumber.Text;
            var cardHolderName = CardHolderName.Text;
            var expirationDate = ExpirationDate.Text;
            var cvc = CVC.Text;

            // Add payment processing logic here (e.g., integrate with a payment gateway)

            // Clear the cart after successful payment
            Session["Cart"] = null;
            Response.Redirect("PaymentSuccess.aspx");
        }
    }
}
