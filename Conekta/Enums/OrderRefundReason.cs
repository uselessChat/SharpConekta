using System;
using System.Collections.Generic;
using System.Text;

namespace Conekta.Enums
{
    public enum OrderRefundReason
    {
        requested_by_client,
        cannot_be_fulfilled,
        duplicated_transaction,
        suspected_fraud,
        other
    }
}