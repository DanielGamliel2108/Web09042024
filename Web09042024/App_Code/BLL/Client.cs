using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class Client
    {
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        
        public string ClientLastname { get; set; }

        public string ClientAddress { get; set; }

        public string ClientCity { get; set; }
        
        public int ClientPhone { get; set; }

        public string ClientMail {  get; set; }

        public string ClientPassword {  get; set; }

        public string ClientStatus { get; set; }

        public string ClientDateAdded { get; set; }

        public Client()
        {
            ClientName = "daniel";
            ClientLastname = "gamliel";
        }

        public Client(string ClientMail, string ClientPassword)
        {
            this.ClientMail = ClientMail;
            this.ClientPassword = ClientPassword;
        }
        

        
    }
}