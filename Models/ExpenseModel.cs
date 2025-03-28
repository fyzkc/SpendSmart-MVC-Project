using System.ComponentModel.DataAnnotations;

namespace SpendSmart.Models
{
    public class ExpenseModel
    {
        public int ExpenseId { get; set; }
        public decimal Value { get; set; }

        [Required]
        public string? Description { get; set; }
    }
}
