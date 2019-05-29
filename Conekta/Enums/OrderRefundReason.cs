using System;
using System.Collections.Generic;
using System.Text;

namespace Conekta.Enums
{
    public enum OrderRefundReason
    {
        RequestedByClient,
        CannotBeFulfilled,
        DuplicatedTransaction,
        SuspectedFraud,
        Other
    }
}