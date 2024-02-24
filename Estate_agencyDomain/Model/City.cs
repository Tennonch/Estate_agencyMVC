using System;
using System.Collections.Generic;

namespace Estate_agencyDomain.Model;

public partial class City : Entity
{
    public int CityId { get; set; }

    public string? CityName { get; set; }

    public int? CountryId { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual Country? Country { get; set; }
}
