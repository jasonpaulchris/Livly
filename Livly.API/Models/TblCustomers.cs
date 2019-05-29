using System.ComponentModel.DataAnnotations;

namespace Livly.API.Models
{
    public partial class TblCustomers
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public virtual TblOrders Orders { get; set; }

    }
}
