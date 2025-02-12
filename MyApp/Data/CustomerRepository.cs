using MyApp.Models;

namespace MyApp.Data
{
    public class CustomerRepository : Repository<Customer>
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
        }

        // You can add custom methods for CustomerRepository here
    }
}
