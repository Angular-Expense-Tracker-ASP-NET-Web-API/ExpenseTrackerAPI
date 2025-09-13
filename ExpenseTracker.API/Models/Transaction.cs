using ExpenseTracker.API.Models.Base;

namespace ExpenseTracker.API.Models;

public class Transaction : BaseEntity
{
    public string Type { get; set; } // "income" or "expense"
    public double Amount { get; set; }
    public string Category { get; set; }
}
