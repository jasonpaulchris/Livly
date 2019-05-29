using System.Linq;

namespace Livly.API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(OrderContext context)
        {
            context.Database.EnsureCreated();

            // Look for any orders.
            if (context.Orders.Any())
            {
                return;   // DB has been seeded
            }

        }
    }
}