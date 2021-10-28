using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class ActivoFijo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Decimal ValorActivo { get; set; }
        public DateTime FechaDeAdquisicion { get; set; }
        public TipoActivo tipoActivo { get; set; }
        public MetodoDepreciacion metodoDepreciacion { get; set; }

    }
}
