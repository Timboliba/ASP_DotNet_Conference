using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Conference.Models
{
    public class Congre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string titre { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }

        public String Details { get; set; }
        public IEnumerable<int> Conferenciers { get; set; }
        public IEnumerable<int> Comites { get; set; }

        public String Lieu { get; set; }
        public IEnumerable<int> Sessions { get; set; }
    }
}