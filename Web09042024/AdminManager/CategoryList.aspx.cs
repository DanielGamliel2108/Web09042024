using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Web09042024.AdminManager
{
    public partial class CategoryList : System.Web.UI.Page
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\TirgulCSharp\\Web09042024\\Web09042024\\App_Data\\Ecom.mdf;Integrated Security=True;Connect Timeout=30;"; 

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCategories();
            }
        }

        protected void BindCategories()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM T_Category", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                RptCategory.DataSource = dt;
                RptCategory.DataBind();
            }
        }
    }
}
