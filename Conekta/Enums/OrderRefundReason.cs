using System;
using System.Collections.Generic;
using System.Text;

namespace Conekta.Enums
{
    public enum OrderRefundReason
    {
        Requested_By_Client,
        Cannot_Be_Fulfilled,
        Duplicated_Transaction,
        Suspected_Fraud,
        Other
    }
}