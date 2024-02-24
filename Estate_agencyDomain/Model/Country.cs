using System;
using System.Collections.Generic;

namespace Estate_agencyDomain.Model;

public partial class Country : Entity
{
    public int CountryId { get; set; }

    public string? CountryName { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();
}
