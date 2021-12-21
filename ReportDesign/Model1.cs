using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ReportDesign
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Northwind")
        {
        }

        public virtual DbSet<employeedata> employeedatas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<employeedata>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<employeedata>()
                .Property(e => e.town)
                .IsUnicode(false);
        }
    }
}
