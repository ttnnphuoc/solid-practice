namespace SOLIDExample.Email
{
    public interface IEmailSender
    {
        void Send(string emailAddress, string message);
    }
    public class EmailSender : IEmailSender
    {
        public void Send(string emailAddress, string message){}
    }

    public class NotificationService
    {
        private IEmailSender _emailSender;
        public NotificationService(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public void SendEmail(string emailAddress, string message)
        {
            _emailSender.Send(emailAddress, message);
        }
    }
}
