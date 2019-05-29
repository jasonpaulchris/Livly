using Livly.API.Data;
    using Livly.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Livly.API.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly OrderContext _context;

        public RestaurantsController(OrderContext context)
        {
            _context = context;
        }

        // GET: Restaurants
        public async Task<IActionResult> Index()
        {
            return View(await _context.Restaurants.ToListAsync());
        }

        // GET: Restaurants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblRestaurants = await _context.Restaurants
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblRestaurants == null)
            {
                return NotFound();
            }

            return View(tblRestaurants);
        }

        // GET: Restaurants/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Restaurants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RestaurantName,Street,City,State,Zip")] TblRestaurants tblRestaurants)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblRestaurants);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblRestaurants);
        }

        // GET: Restaurants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblRestaurants = await _context.Restaurants.FindAsync(id);
            if (tblRestaurants == null)
            {
                return NotFound();
            }
            return View(tblRestaurants);
        }

        // POST: Restaurants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RestaurantName,Street,City,State,Zip")] TblRestaurants tblRestaurants)
        {
            if (id != tblRestaurants.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblRestaurants);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblRestaurantsExists(tblRestaurants.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tblRestaurants);
        }

        // GET: Restaurants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblRestaurants = await _context.Restaurants
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblRestaurants == null)
            {
                return NotFound();
            }

            return View(tblRestaurants);
        }

        // POST: Restaurants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblRestaurants = await _context.Restaurants.FindAsync(id);
            _context.Restaurants.Remove(tblRestaurants);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblRestaurantsExists(int id)
        {
            return _context.Restaurants.Any(e => e.Id == id);
        }
    }
}
