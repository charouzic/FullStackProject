using System.ComponentModel.DataAnnotations;

namespace FibonacciNumber.Models
{
    public class FibonacciNumberObj
    {
        [Key]
        public int Id { get; set; }
        // n
        [Required]
        public int Sequence { get; set; }
        // x
        [Required]
        public int Value { get; set; }
    }
}