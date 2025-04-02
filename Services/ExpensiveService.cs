using BudgetTrackerAppBlazorWebassembly.Models;
using Microsoft.Extensions.Logging;
using Blazored.Toast.Services;
namespace BudgetTrackerAppBlazorWebassembly.Services
{
    public class ExpensiveService : IExpensiveService
    {
        private List<Expense> _expenses = new List<Expense>();

        public List<Expense> Expenses => _expenses;

        private readonly IToastService _toastService;

        public string ExpenseName { get; set; }

        private readonly ILogger _logger;

        public ExpensiveService(ILogger<Expense> logger, IToastService toastService)
        {
            _logger = logger;
            _toastService = toastService;
        }
        public void AddExpense()
        {

            _logger.LogInformation($"{ExpenseName}");
            if (string.IsNullOrEmpty(ExpenseName))
            {
                _toastService.ShowError("Please enter a name for the expense");
                return;
            }
        }
    }
}
