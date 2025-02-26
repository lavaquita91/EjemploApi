using System;
using System.Collections.Generic;

namespace EjempliApi.Entities;

public partial class Persona: BaseEntity
{
    public string? Identificacion { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string? NombresCompletos { get; set; }

  
}
