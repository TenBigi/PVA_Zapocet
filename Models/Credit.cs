using System.ComponentModel.DataAnnotations;

namespace PVA_Zápočet.Models
{
    public class Credit
    {
        [Key]
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public int Value { get; set; }
        public bool Success { get; set; }
    }
}
