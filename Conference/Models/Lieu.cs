using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conference.Models
{
    public class Lieu
    {
        public Guid Id { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
    }
}