using BudgetTrackerAppBlazorWebassembly.Models;

namespace BudgetTrackerAppBlazorWebassembly.Services
{
    public interface IIncomeService
    {
        decimal? IncomeNumber { get; set; }
        string IncomeName { get; set; }
        List<Income> Incomes { get;  }
        public  decimal TotalIncome { get;}
        void AddIncome();
        void RemoveIncome(Guid id);
        Task LoadIncomesAsync();
        Task SaveIncomesAsync();
    }
}
