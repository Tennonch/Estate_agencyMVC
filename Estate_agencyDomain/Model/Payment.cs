using System;
using System.Collections.Generic;

namespace Estate_agencyDomain.Model;

public partial class Payment : Entity
{
    public int PaymentId { get; set; }

    public int? TransactionId { get; set; }

    public decimal? Amount { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public virtual Transaction1? Transaction { get; set; }
}
