using BLL;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace Web09042024
{
    public partial class CategoryList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCategories();
            }
        }

        protected void BindCategories()
        {
            List<Category> categories = Category.GetAll();
            RptCategories.DataSource = categories;
            RptCategories.DataBind();
        }
    }
}
