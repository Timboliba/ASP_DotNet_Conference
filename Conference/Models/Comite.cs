using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conference.Models
{
    public class Comite
    {
        public Guid Id { get; set; }
        public string Nom { get; set; }
        public List<MembresComite> MembresComites { get; set; }
    }
}