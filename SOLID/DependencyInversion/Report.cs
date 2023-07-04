namespace DependencyInversion
{
    public class Report
    {
        public Report(ISender sender)
        {
            this.sender = sender;
        }
        ISender sender;
        public void Send(string to)
        {
            //MailSender mailSender = new MailSender();
            sender.Send(to);
        }
    }

    public interface ISender
    {
        void Send(string to);
    }
    public class MailSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine($"{to} adresine mail atıldı");
        }
    }

    public class WASender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine($"{to} numarasına  Whatsapp ile gönderildi");
        }
    }
}
