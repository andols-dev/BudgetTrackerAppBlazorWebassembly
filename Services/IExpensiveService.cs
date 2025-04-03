using BudgetTrackerAppBlazorWebassembly.Models;
using System.ComponentModel;

namespace BudgetTrackerAppBlazorWebassembly.Services
{
    public interface IExpensiveService
    {
        List<Expense> Expenses { get;  }
        string ExpenseName { get; set; }

        decimal? ExpenseNumber { get; set; }

        void AddExpense();
    }
}
