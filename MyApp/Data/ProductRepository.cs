using MyApp.Models;

namespace MyApp.Data
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }

        // You can add custom methods for ProductRepository here
    }
}
