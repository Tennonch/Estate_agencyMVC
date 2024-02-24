﻿using System;
using System.Collections.Generic;

namespace Estate_agencyDomain.Model;

public partial class Address: Entity
{
    public int AddressId { get; set; }

    public string? Street { get; set; }

    public int? CityId { get; set; }

    public virtual City? City { get; set; }

    public virtual ICollection<Property> Properties { get; set; } = new List<Property>();
}
