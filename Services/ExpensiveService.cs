using BudgetTrackerAppBlazorWebassembly.Models;
using Microsoft.Extensions.Logging;
using Blazored.Toast.Services;
using Blazored.LocalStorage;

namespace BudgetTrackerAppBlazorWebassembly.Services
{
    public class ExpensiveService : IExpensiveService
    {
        private List<Expense> _expenses = new List<Expense>();
        private readonly ILocalStorageService _localStorage;
        public List<Expense> Expenses => _expenses;

        private readonly IToastService _toastService;

        string placeholder = "Enter Expense Name";
        public string ExpenseName { get; set; }

        public decimal? ExpenseNumber { get; set; }

        public decimal TotalExpenses => _expenses.Sum(e => e.Amount);

        private readonly ILogger _logger;

        public ExpensiveService(ILogger<Expense> logger, IToastService toastService, ILocalStorageService localStorage)
        {
            _logger = logger;
            _toastService = toastService;
            _localStorage = localStorage;
        }
        public void AddExpense()
        {
            if (string.IsNullOrEmpty(ExpenseName))
            {
                _toastService.ShowError("Please enter a name for the expense");
                return;
            }
            if (!string.IsNullOrEmpty(ExpenseName) && ExpenseNumber > 0)
            {
                _expenses.Add(new Expense(ExpenseName, (decimal)ExpenseNumber));
                ExpenseName = string.Empty;
                ExpenseNumber = null;

                _toastService.ShowSuccess("Expense added successfully");
                SaveExpensesAsync().ConfigureAwait(false);
            }



        }

        public async Task LoadExpensesAsync()
        {
            _expenses = await _localStorage.GetItemAsync<List<Expense>>("expenses") ?? new List<Expense>();
        }

        public async Task SaveExpensesAsync()
        {
           await _localStorage.SetItemAsync("expenses", _expenses);
            
        }
    }
}
