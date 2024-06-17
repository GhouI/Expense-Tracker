using Microsoft.AspNetCore.Identity;

namespace Expense_Tracker.Server.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public double Budget { get; set; }
        

    }
}