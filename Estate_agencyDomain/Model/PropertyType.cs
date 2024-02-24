using System;
using System.Collections.Generic;

namespace Estate_agencyDomain.Model;

public partial class PropertyType : Entity
{
    public int PropertyTypeId { get; set; }

    public string? TypeName { get; set; }

    public virtual ICollection<Property> Properties { get; set; } = new List<Property>();
}
