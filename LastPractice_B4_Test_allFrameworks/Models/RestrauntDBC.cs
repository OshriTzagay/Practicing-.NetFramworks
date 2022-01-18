using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LastPractice_B4_Test_allFrameworks.Models
{
    public partial class RestrauntDBC : DbContext
    {
        public RestrauntDBC()
            : base("name=RestrauntDBC")
        {
        }

        public DbSet<Waiter> Waiters { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
