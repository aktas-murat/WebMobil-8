using MVC_101.Models;

namespace MVC_101.Services.EmailService
{
    public interface IEmailService
    {

        Task SendMailAsync(MailModel model);
   
    }
}
