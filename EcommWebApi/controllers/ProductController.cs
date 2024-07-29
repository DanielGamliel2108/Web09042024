using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;

namespace EcommWebApi.controllers
{
    public class ProductController : ApiController
    {
        // GET: api/v1/Product
        public List<Product> Get()
        {
            return Product.GetAll();
        }

        // GET: api/Product/5
        public Product Get(int id)
        {
            return Product.GetById(id);
        }

        // POST: api/v1/Product
        public void Post([FromBody]Product Data)
        {
            Data.ProductCode = -1;
            Data.Save();
        }

        // PUT: api/v1/Product/5
        public void Put(int id, [FromBody] Product Data)
        {
            Data.ProductCode = -1;
            Data.Save();
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
