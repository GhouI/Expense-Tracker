using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<
        // Define your DbSet properties here for each entity in your data model
        // For example:
        // public DbSet<User> Users { get; set; }
        // public DbSet<Expense> Expenses { get; set; }
    }
}