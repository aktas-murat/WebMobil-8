using MVC_101.Models;
using System.Diagnostics;

namespace MVC_101.Services.SmsService
{
    public class SonicSmsService : ISmsService
    {
        public SmsStates Send(SmsModel model)
        {
            Debug.Write( $"Sonic:{model.TelefonNo}-{model.Mesaj}");
            return SmsStates.Sent;
        }
    }
}
