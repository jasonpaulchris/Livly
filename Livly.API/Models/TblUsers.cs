namespace Livly.API.Models
{
    public class TblUsers
    {
        public int Id { get; set; }
        public string LoginId { get; set; }
        public string LoginPassword { get; set; }
        public int OrdersAssigned { get; set; }
        public string AssignedTo { get; set; }
    }
}
