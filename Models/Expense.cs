namespace BudgetTrackerAppBlazorWebassembly.Models
{
    public class Expense
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public Expense(string name, decimal amount)
        {
            Id = Guid.NewGuid();
            Name = name;
            Amount = amount;
            Date = DateTime.UtcNow;
        }
    }
}
