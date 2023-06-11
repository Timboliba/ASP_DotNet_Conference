using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conference.Models
{
    public class Conferencier
    {
        public Guid Id { get; set; }
        public string Nom { get; set; }
        public string Role { get; set; }
        public string ComiteID { get; set; }
    }
}