using Livly.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Livly.API.Controllers
{
    public class OrdersController : Controller
    {
        private readonly OrderContext _context;

        public OrdersController(OrderContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            var customers = await _context.Customers.ToListAsync();
            var restaurants = await _context.Restaurants.ToListAsync();
            //var tblOrders = await _context.Orders.Where(x => x.OrderComplete == false).Include("Customers").ToListAsync();

            var tblOrders = await _context.Orders
                 .Where(o => o.OrderComplete == false)
            .Include("Restaurants").ToListAsync();


            return View(tblOrders);

        }

        private bool TblOrdersExists(int id)
        {
            return _context.Orders.Any(e => e.Id == id);
        }
    }
}
