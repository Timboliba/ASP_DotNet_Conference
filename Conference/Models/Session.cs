using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conference.Models
{
    public class Session
    {

        public Guid Id { get; set; }
        public string titre { get; set; }
        public Responsable Responsable { get; set; }
        public int CongrésId { get; set; }
        public Congre Congres { get; set; }
    }
}