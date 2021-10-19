using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebAdvertiseApplication.Models
{
    public partial class Clients : DbContext
    {
        public Clients()
            : base("name=Clients")
        {
        }

        public virtual DbSet<Client> Client { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
