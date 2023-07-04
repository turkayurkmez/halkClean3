namespace SingleResponsibility
{
    public class ProductService
    {
        public void CreateProductOnDb(string name, decimal price)
        {

        }
        public void ChangeProductPrice(int id, decimal newPrice)
        {

        }
        public void NotifySuppliers(int supplierID)
        {
            MailSender mailSender = new MailSender();
            mailSender.Send();
        }
    }
}
