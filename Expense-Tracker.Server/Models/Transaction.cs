using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Expense_Tracker.Server.Models;

namespace Expense_Tracker.Server.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        [Column(TypeName = "Date")]
        public DateTime TransactionDate { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public double Amount { get; set; }
        
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}