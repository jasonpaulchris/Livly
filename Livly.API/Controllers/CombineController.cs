//using Livly.API.Data;
//using Livly.API.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Livly.API.Controllers
//{
//    public class CombineController : Controller
//    {
//        private readonly OrderContext _context;

//        public CombineController(OrderContext context)
//        {
//            _context = context;
//        }

//        public async Task<ActionResult> GetOrders()
//        {
//            ViewModel vm = new ViewModel();
//            vm.orders = await _context.Orders.Where(x => x.OrderComplete == false).ToListAsync();
//            vm.customers = await _context.Customers.ToListAsync();
//            return View(vm);
//        }
//    }
//}