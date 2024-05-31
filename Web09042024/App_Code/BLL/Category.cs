using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class Category
    {
        
        public int CategoryCode { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public string CategoryImageName { get; set; }

        public int AvCategoryCode { get; set; }

        public string CategoryStatus { get; set; }

        public string DateAdded { get; set; }

        public static List<Category> GetAll()
        {
            return CategoryDAL.GetAll();
        }
        public static Category GetById(int Id)
        {
            return CategoryDAL.GetById(Id);
        }



    }
}