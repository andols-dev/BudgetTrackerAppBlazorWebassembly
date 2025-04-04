using BudgetTrackerAppBlazorWebassembly.Services;
using Microsoft.Extensions.Logging;
using Blazored.Toast.Services;
using Blazored.LocalStorage;
using System.Threading.Tasks;

namespace BudgetTrackerAppBlazorWebassembly.Models
{
    public class IncomeService : IIncomeService
    {
        private readonly ILogger _logger;
        private readonly IToastService _toastService;
        private readonly ILocalStorageService _localStorage;
        private List<Income> _incomes = new List<Income>();
        public List<Income> Incomes => _incomes;




        public IncomeService(ILogger<Income> logger, IToastService toastService, ILocalStorageService localStorageService)
        {
            _logger = logger;
            _toastService = toastService;
            _localStorage = localStorageService;
        }

        public decimal? IncomeNumber { get; set; } = null;
        public string IncomeName { get; set; }

        public decimal TotalIncome => _incomes.Sum(i => i.Amount);

        public void AddIncome()
        {

            if (string.IsNullOrEmpty(IncomeName) || IncomeNumber == null)
            {
                if (string.IsNullOrEmpty(IncomeName))
                {
                    _toastService.ShowError(LogMessage.IncomeNameEmpty);
                }
                if (IncomeNumber == null)
                {
                    _toastService.ShowError(LogMessage.IncomeNumberEmpty);
                }

            }

            if (!string.IsNullOrEmpty(IncomeName) && IncomeNumber > 0)
            {
                _incomes.Add(new Income(IncomeName, (decimal)IncomeNumber));
                IncomeName = string.Empty;
                IncomeNumber = null;
                _toastService.ShowSuccess(LogMessage.IncomeAdded);
                SaveIncomesAsync().ConfigureAwait(false);
            }
        }

        public async Task LoadIncomesAsync()
        {
            _incomes = await _localStorage.GetItemAsync<List<Income>>("incomes") ?? new List<Income>();
        }

        public async Task SaveIncomesAsync()
        {
            await _localStorage.SetItemAsync("incomes", _incomes);
        }



        public void RemoveIncome(Guid id)
        {
            var income = _incomes.FirstOrDefault(i => i.Id == id);
            if (income != null) {
                _incomes.Remove(income);
                _toastService.ShowSuccess(LogMessage.IncomeRemoved);
                SaveIncomesAsync().ConfigureAwait(false);
            }
            else
            {
                _toastService.ShowError(LogMessage.NotFound);
            }
        }
    }
    }
