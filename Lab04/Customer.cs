using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab04
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [MinLength(8), MaxLength(20)] public string UserName { get; set; }
        [MinLength(8), MaxLength(20), PasswordPropertyText] public string UserPassword { get; set; }
        [MinLength(1), MaxLength(100)] public string CustomerName { get; set; }
        public DateTime Birthday { get; set; }
        [MinLength(8), MaxLength(20)] public string PassPortNbr { get; set; }
        [MaxLength(50)] public string Nationality { get; set; }
        [Column(TypeName = "BLOB")] public byte[] Avatar { get; set; } = Array.Empty<byte>();

        public List<Flight> Flights { get; set; } = new();
    }
}
