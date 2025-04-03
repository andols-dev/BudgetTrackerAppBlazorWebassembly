using BudgetTrackerAppBlazorWebassembly.Services;
using Microsoft.Extensions.Logging;
using Blazored.Toast.Services;
namespace BudgetTrackerAppBlazorWebassembly.Models
{
    public class IncomeService : IIncomeService
    {
        private readonly ILogger _logger;
        private readonly IToastService _toastService;
        private List<Income> _incomes = new List<Income>();
        public List<Income> Incomes => _incomes;




        public IncomeService(ILogger<Income> logger, IToastService toastService)
        {
            _logger = logger;
            _toastService = toastService;
        }

        public decimal? IncomeNumber { get; set; } = null;
        public string IncomeName { get; set; }
        

        public void AddIncome()
        {

            if (string.IsNullOrEmpty(IncomeName) || IncomeNumber == null)
            {
                if (string.IsNullOrEmpty(IncomeName))
                {
                    _toastService.ShowError("Please enter a name for the income");
                }
                if (IncomeNumber == null)
                {
                    _toastService.ShowError("Please enter a number for the income");
                }

            }

            if (!string.IsNullOrEmpty(IncomeName) && IncomeNumber > 0)
            {
                _incomes.Add(new Income(IncomeName, (decimal)IncomeNumber));
                IncomeName = string.Empty;
                IncomeNumber = null;
                _toastService.ShowSuccess("Income added successfully");
            }
        }
    }
}
