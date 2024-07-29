using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class Product
    {

        public int ProductCode { get; set; }

        public string ProductName { get; set; }

        public float ProductPrice { get; set; }

        public string ProductDescription { get; set; }

        public string ProductImageName { get; set; }

        public int ProductCategoryCode { get; set; }

        public string ProductStatus { get; set; }

        public DateTime ProductDateAdded { get; set; }

        public static List<Product> GetAll()
        {
            return ProductDAL.GetAll();
        }
        public static Product GetById(int Id)
        {
            return ProductDAL.GetById(Id);
        }
        public void Save()
        {
            ProductDAL.Save(this);
        }


    }
}