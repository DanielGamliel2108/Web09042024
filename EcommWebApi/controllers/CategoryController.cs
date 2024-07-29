using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EcommWebApi.controllers
{
    public class CategoryController : ApiController
    {
        // GET: api/v1/Category
        public List<Category> Get()
        {
            return Category.GetAll();
        }

        // GET: api/v1/Category/5
        public Category Get(int id)
        {
            return Category.GetById(id);
        }

        // POST: api/v1/Category
        public void Post([FromBody] Category Data)
        {
            Data.Cid = -1;
            Data.Save();
        }

        // PUT: api/v1/Category/5
        public void Put(int id, [FromBody] Category Data)
        {
            Data.Cid = -1;
            Data.Save();
        }

        // DELETE: api/Category/5
        public void Delete(int id)
        {
        }
    }
}
