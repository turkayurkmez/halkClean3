namespace GoodCode.Library
{
    public class FakeCompanyService : ICompanyService
    {
        public List<Company> GetCompanies()
        {
            return new List<Company>()
           {
                new(){ Name="abc", HourlyPayment=125},
                new(){ Name="acme", HourlyPayment=150},
           };
        }
    }
}
