using Livly.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Livly.API.Data
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
        }

        public DbSet<TblRestaurants> Restaurants { get; set; }
        public DbSet<TblOrders> Orders { get; set; }
        public DbSet<TblCustomers> Customers { get; set; }
    }
}