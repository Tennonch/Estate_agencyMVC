using System;
using System.Collections.Generic;

namespace Estate_agencyDomain.Model;

public partial class Client : Entity
{
    public int ClientId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual ICollection<Transaction1> Transaction1s { get; set; } = new List<Transaction1>();
}
