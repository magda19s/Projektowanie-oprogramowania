using Księgarnia.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Księgarnia.Data
{
    public class MyDbContext: IdentityDbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Client> Clients { get; set; }

        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<DeliveryMethod> Methods { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentKind> DocumentKinds { get; set; }

        public DbSet<Favourities> Favourities { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();

        }
    }
}
