using System.Collections.Generic;
using System.Linq;

namespace CollegeManagementSystem.Utilities
{
    public static class ChartHelper
    {
        public static Dictionary<string, double> CalculateAttendanceChart(List<(string course, int present, int total)> records)
        {
            return records.ToDictionary(
                r => r.course,
                r => r.total == 0 ? 0 : (double)r.present / r.total * 100
            );
        }
    }
}
