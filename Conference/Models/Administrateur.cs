using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conference.Models
{
    public class Administrateur
    {
        public Guid Id { get; set; }
        public string titre { get; set; }
        public string userName { get; set; }
        public int password { get; set; }
        public List<string> Permissions { get; set; }
    }
}