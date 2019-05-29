using Livly.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Livly.API.Controllers
{
    public class CustomersController : Controller
    {
        private readonly OrderContext _context;

        public CustomersController(OrderContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()

        {
            var customers = await _context.Customers.ToListAsync();
            return View(customers);
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerHistory = await _context.Customers
                .Include("Orders")
                .Where(x => x.Orders.CustomerId == id)
                .ToListAsync();

            return View(customerHistory);
        }

        private bool TblCustomersExists(int id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }
    }
}
