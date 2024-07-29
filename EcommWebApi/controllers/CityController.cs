using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EcommWebApi.controllers
{
    public class CityController : ApiController
    {
        // GET: api/v1/City
        public List<City> Get()
        {
            return City.GetAll();
        }

        // GET: api/v1/City/5
        public City Get(int id)
        {
            return City.GetById(id);
        }

        // POST: api/v1/City
        public void Post([FromBody] City Data)
        {
            Data.CityCode = -1;
            Data.Save();
        }

        // PUT: api/v1/City/5
        public void Put(int id, [FromBody] City Data)
        {
            Data.CityCode = -1;
            Data.Save();
        }

        // DELETE: api/City/5
        public void Delete(int id)
        {
        }
    }
}
