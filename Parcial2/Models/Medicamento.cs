using System;
using System.Collections.Generic;
using Parcial2.Context;

namespace Parcial2.Models;

public partial class Medicamento
{
    public int Id { get; set; }

    public string? NombreMedicamento { get; set; }

    public string? PrecioMedicamento { get; set; }
    

    public static implicit operator Medicamento(FarmaciaUnabContext v)
    {
        throw new NotImplementedException();
    }
}
