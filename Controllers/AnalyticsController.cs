using Microsoft.AspNetCore.Mvc;
using CollegeManagementSystem.Services;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Controllers
{
    public class AnalyticsController : Controller
    {
        private readonly AnalyticsService _analyticsService;

        public AnalyticsController(AnalyticsService analyticsService)
        {
            _analyticsService = analyticsService;
        }

        public async Task<IActionResult> Dashboard()
        {
            var data = await _analyticsService.GetAttendanceStatsAsync();
            return View(data);
        }

        public async Task<IActionResult> Charts()
        {
            var chartData = await _analyticsService.GetAttendanceChartDataAsync();
            return Json(chartData);
        }
    }
}
