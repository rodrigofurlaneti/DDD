using System;
using System.Collections.Generic;

namespace DDD.Domian.Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool Active { get; set; }
    }
}
