

namespace GoodCode.Library
{
    public class SendMailComponent
    {
        public void SendMailSimulation(List<TimeSheetEntry> timeSheetEntries, List<Company> companies)
        {

            foreach (var company in companies)
            {
                double totalPaymentInAWeekForCompany = new TimeSheetBillCalculator().GetTotalPaymentForCompany(timeSheetEntries, company);

                Console.WriteLine("Simulating Sending email to Acme");
                Console.WriteLine("Your bill is $" + totalPaymentInAWeekForCompany + " for the hours worked.");
            }

        }
    }
}
