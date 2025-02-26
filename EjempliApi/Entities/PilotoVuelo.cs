using System;
using System.Collections.Generic;

namespace EjempliApi.Entities;

public partial class PilotoVuelo: BaseEntity
{
    

    public int? IdVuelo { get; set; }

    public int? IdPiloto { get; set; }

    public int? AnioVuelo { get; set; }

    public int? DiaInicio { get; set; }

    public int? DiaFin { get; set; }

    public int? HoraInicio { get; set; }

    public int? HoraFin { get; set; }

    
}
