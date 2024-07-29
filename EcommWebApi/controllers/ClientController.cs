using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EcommWebApi.controllers
{
    public class ClientController : ApiController
    {
        // GET: api/v1/Client
        public List<Client> Get()
        {
            return Client.GetAll();
        }

        // GET: api/v1/Client/5
        public Client Get(int id)
        {
            return Client.GetById(id);
        }

        // POST: api/v1/Client
        public void Post([FromBody] Client Data)
        {
            Data.ClientID = -1;
            Data.Save();
        }

        // PUT: api/v1/Client/5
        public void Put(int id, [FromBody] Client Data)
        {
            Data.ClientID = -1;
            Data.Save();
        }

        // DELETE: api/Client/5
        public void Delete(int id)
        {
        }
    }
}
