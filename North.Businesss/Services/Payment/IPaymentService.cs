using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using North.Core.Payments;

namespace North.Businesss.Services.Payment
{
   public interface IPaymentService
    {
        InstallmentModel CheckInstallments(string binNumber, decimal price);
        
    }
}
