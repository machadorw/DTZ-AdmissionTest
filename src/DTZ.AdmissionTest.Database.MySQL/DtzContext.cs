using DTZ.AdmissionTest.Platform.Entities;
using Microsoft.EntityFrameworkCore;

namespace DTZ.AdmissionTest.Database.MySQL
{
    public class DtzContext : DbContext
    {
        private const string ConnectionString = "server=localhost;database=dotz_db;user=sa;password=dtz12345";

        public DbSet<Addresses> Address { get; set; }
        public DbSet<Orders> Order { get; set; }
        public DbSet<Products> Product { get; set; }
        public DbSet<Users> User { get; set; }

        public DtzContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(ConnectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.CreatedAt).IsRequired();
                entity.Property(e => e.UpdatedAt).IsRequired();
                entity.Property(e => e.ZipCode).IsRequired();
                entity.Property(e => e.Number).IsRequired();
                entity.Property(e => e.State).IsRequired();
                entity.HasOne(e => e.User).WithMany(e => e.Addresses);
                entity.Ignore(e => e.Notifications);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.CreatedAt).IsRequired();
                entity.Property(e => e.UpdatedAt).IsRequired();
                entity.Property(e => e.OrderStatus).IsRequired();
                entity.HasMany(e => e.Products);
                entity.HasOne(e => e.User).WithMany(e => e.Orders);
                entity.Ignore(e => e.Notifications);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.CreatedAt).IsRequired();
                entity.Property(e => e.UpdatedAt).IsRequired();
                entity.Property(e => e.IsAvailableForRedemption).IsRequired();
                entity.Property(e => e.ProductPrice).IsRequired();
                entity.Property(e => e.Description).IsRequired();
                entity.Ignore(e => e.Notifications);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.CreatedAt).IsRequired();
                entity.Property(e => e.UpdatedAt).IsRequired();
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.IsActive).IsRequired();
                entity.HasMany(e => e.Addresses).WithOne(e => e.User);
                entity.HasMany(e => e.Orders).WithOne(e => e.User);
                entity.Ignore(e => e.Notifications);
            });
        }
    }
}
