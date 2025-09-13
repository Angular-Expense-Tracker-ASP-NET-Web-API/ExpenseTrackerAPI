using ExpenseTracker.API.Models.Base;

namespace ExpenseTracker.API.Models;

public class User : BaseEntity
{
    public string Email { get; set; }
    public string Password { get; set; }
}
