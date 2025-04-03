using BudgetTrackerAppBlazorWebassembly.Models;

namespace BudgetTrackerAppBlazorWebassembly.Services
{
    public interface IIncomeService
    {
        decimal? IncomeNumber { get; set; }
        string IncomeName { get; set; }
        List<Income> Incomes { get;  }
        void AddIncome();
    }
}
