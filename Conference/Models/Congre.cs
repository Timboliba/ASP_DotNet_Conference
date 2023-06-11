using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conference.Models
{
    public class Congre
    {
        public Guid Id { get; set; }
        public string titre { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }

        public List<Conferencier> Conferenciers { get; set; }
        public List<Comite> Comites { get; set; }

        public Lieu Lieu { get; set; }
        public List<Session> Sessions { get; set; }
    }
}