using System;
using System.Collections.Generic;
using System.Text;

namespace Conekta.Enums
{
    public enum OrderPaymentStatus
    {
        ChargedBack,
        Declined,
        Expired,
        Paid,
        PartiallyRefunded,
        PendingPayment,
        PreAuthorized,
        Refunded,
        Voided
    }
}
