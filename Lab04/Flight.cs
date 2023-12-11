using System.ComponentModel.DataAnnotations;

namespace Lab04
{
    public class Flight
    {
        public enum Type
        {
            A, B, C, D
        }
        [Key] public int FlightID { get; set; }
        public DateTime TimeDepart { get; set; }
        public DateTime TimeArrival { get; set; }
        public Type FlightType { get; set; }

        public List<Customer> Customers { get; set; } = new();
    }
}
