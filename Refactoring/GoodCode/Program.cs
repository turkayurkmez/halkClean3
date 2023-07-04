using GoodCode.Library;

namespace GoodCode
{
    class Program
    {
        static void Main(string[] args)
        {
            SendMailComponent sendMailComponent = new SendMailComponent();

            List<TimeSheetEntry> timeSheetEntries = loadEntries();
            List<Company> companies = new FakeCompanyService().GetCompanies();
            sendMailComponent.SendMailSimulation(timeSheetEntries, companies);
            var extraPayment = new TimeSheetBillCalculator().CalculateBillForExtra(timeSheetEntries, max: 40, extra: 15, standard: 10);


            Console.WriteLine($"You will get paid ${extraPayment} for your work.");
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }

        static List<TimeSheetEntry> loadEntries()
        {
            List<TimeSheetEntry> timeSheetEntries = new List<TimeSheetEntry>();
            string answer = string.Empty;
            do
            {
                Console.Write("Enter what you did: ");
                string workDone = Console.ReadLine();
                Console.Write("How long did you do it for: ");

                double timeWorked = 0;
                string rawTimeWorked = Console.ReadLine();
                while (double.TryParse(rawTimeWorked, out timeWorked) == false)
                {
                    rawTimeWorked = getRawTimeWorkedFromUser();
                }

                TimeSheetEntry ent = new TimeSheetEntry
                {
                    HoursWorked = timeWorked,
                    WorkDone = workDone
                };
                timeSheetEntries.Add(ent);
                Console.Write("Do you want to enter more time (yes/no): ");
                answer = Console.ReadLine();


            }
            while (answer.ToLower() == "yes");
            return timeSheetEntries;

        }

        private static string? getRawTimeWorkedFromUser()
        {
            Console.WriteLine();
            Console.WriteLine("Invalid number given");
            Console.Write("How long did you do it for: ");
            string rawTimeWorked = Console.ReadLine();
            return rawTimeWorked;

        }
    }
}
