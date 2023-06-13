using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Conference.Models
{
    public class DataEntities : DbContext
    {
        public DataEntities() : base("name=ConferenceScientifiqueApp")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
       
        public DbSet<Comite> Comites { get; set; }
        public DbSet<Conferencier> Conferenciers { get; set; }
        public DbSet<Congre> Congres { get; set; }
        public DbSet<MembresComite> MembresComites { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Responsable> Responsables { get; set; }
        public DbSet<Session> Sessions { get; set; }

        public DbSet<Participation> Participations { get; set; }
      
    }
}