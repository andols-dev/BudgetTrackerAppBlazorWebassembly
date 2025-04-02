using BudgetTrackerAppBlazorWebassembly.Models;
using Microsoft.Extensions.Logging;
namespace BudgetTrackerAppBlazorWebassembly.Services
{
    public class ExpensiveService : IExpensiveService
    {
        private List<Expense> _expenses = new List<Expense>();

        public List<Expense> Expenses => _expenses;

        public string ExpenseName { get; set; }

        private readonly ILogger _logger;

        public ExpensiveService(ILogger<Expense> logger)
        {
            _logger = logger;
        }
        public void AddExpense()
        {

            _logger.LogInformation($"{ExpenseName}");
        }
    }
}
