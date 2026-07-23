namespace CustomerCommLib
{
    public class CustomerComm
    {
        IMailSender sender;

        public CustomerComm(IMailSender mailSender)
        {
            sender = mailSender;
        }

        public bool SendMailToCustomer()
        {
            sender.SendMail("abc@gmail.com", "Hello");

            return true;
        }
    }
}