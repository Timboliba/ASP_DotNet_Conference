using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conference.Models
{
    public class Responsable
    {
        public Guid Id { get; set; }
        public string Nom { get; set; }
        public string Fonction { get; set; }
    }
}