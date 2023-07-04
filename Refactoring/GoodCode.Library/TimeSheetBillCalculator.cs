

namespace GoodCode.Library
{
    public class TimeSheetBillCalculator
    {
        public double GetTotalPaymentForCompany(List<TimeSheetEntry> timeSheetEntries, Company company)
        {
            double totalWorksInAWeek = 0;
            for (int i = 0; i < timeSheetEntries.Count; i++)
            {
                if (timeSheetEntries[i].WorkDone.ToLower().Contains(company.Name.ToLower()))
                {
                    totalWorksInAWeek += timeSheetEntries[i].HoursWorked;
                }
            }
            return totalWorksInAWeek * company.HourlyPayment;
        }

        public double CalculateBillForExtra(List<TimeSheetEntry> timeSheetEntries, int max, double extra, double standard)
        {
            double totalWorksInAWeek = 0;
            for (int i = 0; i < timeSheetEntries.Count; i++)
            {
                totalWorksInAWeek += timeSheetEntries[i].HoursWorked;
            }
            if (totalWorksInAWeek > max)
            {
                var paymentForMoreThanMax = (totalWorksInAWeek - max) * extra;
                var paymentForNormalTime = max * standard;

                return paymentForMoreThanMax + paymentForNormalTime;
            }
            else
            {

                return totalWorksInAWeek * standard;

            }
        }
    }
}
