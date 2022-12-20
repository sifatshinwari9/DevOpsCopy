using DataAccess.Entities;
using DataAccess.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json.Serialization;

namespace CovidDashboard.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IBaseRepository<CovidData>? _covidDataRepository;
                
        public List<CovidData> covid_dataset { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IBaseRepository<CovidData> covidDataRepository)
        {
            _logger = logger;
            _covidDataRepository = covidDataRepository;
        }

        public void OnGet()
        {            
            covid_dataset = _covidDataRepository.GetAll();
        }
    }
}