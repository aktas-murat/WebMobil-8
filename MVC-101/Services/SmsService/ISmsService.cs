using MVC_101.Models;

namespace MVC_101.Services.SmsService
{
    public interface ISmsService
    {
        SmsStates Send(SmsModel model);
    }
}
