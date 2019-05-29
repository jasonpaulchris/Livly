using System.ComponentModel.DataAnnotations;

namespace Livly.API.Models
{
    public partial class TblRestaurants
    {
        [Key]
        public int Id { get; set; }
        public string RestaurantName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public virtual TblOrders Orders { get; set; }
    }
}
