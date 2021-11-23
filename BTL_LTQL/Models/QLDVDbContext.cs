using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BTL_LTQL.Models
{
    public partial class QLDVDbContext : DbContext
    {
        public QLDVDbContext() : base("name=QLDVDbContext")
        {
        }
        public virtual DbSet<ChiDoan> ChiDoans { get; set; }
        public virtual DbSet<DoanVien> DoanViens { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiDoan>()
            .Property(e => e.IDChiDoan)
            .IsUnicode(false);
         
        }

    }
}