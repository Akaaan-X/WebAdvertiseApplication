using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebAdvertiseApplication.Models
{
    public partial class Consultants : DbContext
    {
        public Consultants()
            : base("name=Consultants")
        {
        }

        public virtual DbSet<Consultant> Consultant { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Consultant>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Consultant>()
                .Property(e => e.gender)
                .IsUnicode(false);
        }

        public System.Data.Entity.DbSet<WebAdvertiseApplication.Models.Events> Events { get; set; }
    }
}
