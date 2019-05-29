using System.Collections.Generic;

namespace Livly.API.Models
{
    public class ViewModel
    {
        public List<TblOrders> orders { get; set; }
        public TblCustomers customers { get; set; }
        public TblRestaurants restaurants { get; set; }
    }
}
