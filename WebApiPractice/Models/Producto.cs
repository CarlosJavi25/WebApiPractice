using System;
using System.Collections.Generic;

namespace WebApiPractice.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Marca { get; set; }

    public DateTime Fechaingreso { get; set; }

    public DateTime? Fechavencimiento { get; set; }

    public DateTime Fechasalida { get; set; }

    public decimal Precio { get; set; }

    public int? Peso { get; set; }

    public string? Unidades { get; set; }

    public bool Itbis { get; set; }
}
