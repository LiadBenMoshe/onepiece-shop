using Microsoft.EntityFrameworkCore;
using OnePiece.Services.ProductAPI.Models;

namespace OnePiece.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Gomo Gomo no Mi",
                Price = 15,
                Description = " Devil Fruit that grants the user's body the properties of rubber, effectively turning them into a Rubber Human.",
                ImageUrl = "https://onepieceshop.blob.core.windows.net/onepiece-products/Gomu_Gomu_no_Mi",
                CategoryName = "Paramecia"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Mera Mera no Mi",
                Price = 13.99,
                Description = "Devil Fruit that allows the user to create, control, and transform into fire at will..",
                ImageUrl = "https://onepieceshop.blob.core.windows.net/onepiece-products/Mera_Mera_no_Mi",
                CategoryName = "Logia"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Neko Neko no Mi Model Leopard",
                Price = 10.99,
                Description = "Devil Fruit that allows its user to transform into a leopard hybrid and a full leopard at will, making the user a Leopard Human.",
                ImageUrl = "https://onepieceshop.blob.core.windows.net/onepiece-products/Neko_Neko_no_Mi_Model_Leopard",
                CategoryName = "Zoan"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Ope Ope no Mi",
                Price = 15,
                Description = " Devil Fruit whose granted ability is creating a spherical forcefield in which the user can freely alter the orientation, movements, and configuration/anatomy of anything and anyone (themselves included) in a \"surgical\" fashion, making the user a Free Modification Human.<br/>",
                ImageUrl = "https://onepieceshop.blob.core.windows.net/onepiece-products/Ope_Ope_no_Mi",
                CategoryName = "Paramecia"
            });
        }
    }
}
