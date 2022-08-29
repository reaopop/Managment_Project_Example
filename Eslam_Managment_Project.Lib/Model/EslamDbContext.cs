using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Eslam_Managment_Project.Lib.Model
{
    public partial class EslamDbContext : DbContext
    {
        public EslamDbContext()
            : base(Properties.Settings1.Default.ConnectionString)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Drawer> Drawers { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceLog> ServiceLogs { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Services)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.category_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Drawer>()
                .HasMany(e => e.ServiceLogs)
                .WithRequired(e => e.Drawer)
                .HasForeignKey(e => e.drawer_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Journal>()
                .Property(e => e.Debit)
                .HasPrecision(12, 4);

            modelBuilder.Entity<Journal>()
                .Property(e => e.Credit)
                .HasPrecision(12, 4);

            modelBuilder.Entity<ServiceLog>()
                .Property(e => e.amount)
                .HasPrecision(12, 4);
        }
    }
}
