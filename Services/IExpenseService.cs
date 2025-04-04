using BudgetTrackerAppBlazorWebassembly.Models;
using System.ComponentModel;

namespace BudgetTrackerAppBlazorWebassembly.Services
{
    public interface IExpenseService
    {
        List<Expense> Expenses { get;  }
        string ExpenseName { get; set; }

        decimal? ExpenseNumber { get; set; }
        public decimal TotalExpenses { get; }
        void AddExpense();
        void RemoveExpense(Guid id);
        Task LoadExpensesAsync();
        Task SaveExpensesAsync();
    }
}
