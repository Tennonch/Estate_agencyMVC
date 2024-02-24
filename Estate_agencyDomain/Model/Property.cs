using System;
using System.Collections.Generic;

namespace Estate_agencyDomain.Model;

public partial class Property : Entity
{
    public int PropertyId { get; set; }

    public int? PropertyTypeId { get; set; }

    public int? AgentId { get; set; }

    public int? AddressId { get; set; }

    public decimal? Price { get; set; }

    public int? Size { get; set; }

    public int? Bedrooms { get; set; }

    public int? Bathrooms { get; set; }

    public string? Status { get; set; }

    public virtual Address? Address { get; set; }

    public virtual Agent? Agent { get; set; }

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual PropertyType? PropertyType { get; set; }

    public virtual ICollection<Transaction1> Transaction1s { get; set; } = new List<Transaction1>();
}
