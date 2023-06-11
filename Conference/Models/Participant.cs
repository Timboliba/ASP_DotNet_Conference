using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conference.Models
{
    public class Participant
    {
        public Guid Id { get; set; }
        public string Nom { get; set; }
        public string password { get; set; }
        public List<Session> Sessions { get; set; }
    }
}