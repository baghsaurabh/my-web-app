using Microsoft.EntityFrameworkCore;
using my_web_app.Entity;

namespace my_web_app.Data
{
    public class ProductDbcontext:DbContext
    {
        public ProductDbcontext(DbContextOptions<ProductDbcontext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
