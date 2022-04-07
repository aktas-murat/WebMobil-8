using MVC_101.Models;
using System.Diagnostics;
namespace MVC_101.Services.SmsService
{

    public class WissenSmsService : ISmsService
    {
        public SmsStates Send(SmsModel model)
        {
            Debug.Write(message: $"Wissen:{model.TelefonNo}-{model.Mesaj}");
            return SmsStates.Sent;
        }
    }
}
