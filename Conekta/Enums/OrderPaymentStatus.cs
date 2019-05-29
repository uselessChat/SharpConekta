using System;
using System.Collections.Generic;
using System.Text;

namespace Conekta.Enums
{
    public enum OrderPaymentStatus
    {
        Charged_Back,
        Declined,
        Expired,
        Paid,
        Partially_Refunded,
        Pending_Payment,
        Pre_Authorized,
        Refunded,
        Voided
    }
}
