using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Livly.API.Models
{
    public partial class TblOrders
    {

        [Key]
        public int Id { get; set; }
        public DateTime OrderTime { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal OrderAmount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? TipAmount { get; set; }
        public bool? OrderComplete { get; set; }
        [ForeignKey("Customers")]
        public int CustomerId { get; set; }
        [ForeignKey("Restaurants")]
        public int RestaurantId { get; set; }

        public virtual TblRestaurants Restaurants { get; set; }
        public virtual TblCustomers Customers { get; set; }

        public static implicit operator TblOrders(string v)
        {
            throw new NotImplementedException();
        }
    }
}
