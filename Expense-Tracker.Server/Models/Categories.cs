using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Server.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Type { get; set; }
    }
}