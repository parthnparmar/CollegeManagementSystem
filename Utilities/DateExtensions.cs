using System;

namespace CollegeManagementSystem.Utilities
{
    public static class DateExtensions
    {
        public static string ToShortDate(this DateTime date)
            => date.ToString("dd-MM-yyyy");

        public static int GetMonthWorkingDays(int year, int month)
        {
            int days = DateTime.DaysInMonth(year, month);
            int workingDays = 0;

            for (int i = 1; i <= days; i++)
            {
                var day = new DateTime(year, month, i);
                if (day.DayOfWeek != DayOfWeek.Saturday && day.DayOfWeek != DayOfWeek.Sunday)
                    workingDays++;
            }
            return workingDays;
        }
    }
}
