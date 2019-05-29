using System;
using System.Collections.Generic;
using System.Text;

namespace Conekta.Enums
{
    public enum OrderPaymentStatus
    {
        charged_back,
        declined,
        expired,
        paid,
        partially_refunded,
        pending_payment,
        pre_authorized,
        refunded,
        voided
    }
}