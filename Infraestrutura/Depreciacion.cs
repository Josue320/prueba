using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestrutura
{
    public class Depreciacion
    {
        //public decimal[] Depreciar(ActivoFijo af)
        //{
        //    switch (af.metodoDepreciacion)
        //    {
        //        case af.metodoDepreciacion.LineaRecta:
        //            return DepreciacionLineaRecta(af);
        //        case MetodoDepreciacion.SDAIncremental:
        //            return DepreciacionSDA(af);
        //    }

        //    return null;
        //}
        //private decimal[] DepreciacionLineaRecta(ActivoFijo activoFijo)
        //{
        //    int vidaUtil = VidaUtil(activoFijo.TipoActivoFijo);
        //    return Enumerable.Repeat(activoFijo.ValorActivo / vidaUtil, vidaUtil).ToArray();
        //}

        //private decimal[] DepreciacionSDA(ActivoFijo activoFijo)
        //{
        //    return null;
        //}

        //private int VidaUtil(TipoActivoFijo tipoActivoFijo)
        //{
        //    switch (tipoActivoFijo)
        //    {
        //        case TipoActivoFijo.Edificio:
        //            return 20;
        //        case TipoActivoFijo.Vehiculo:
        //            return 5;
        //        case TipoActivoFijo.Maquinaria:
        //            return 3;
        //        case TipoActivoFijo.Mobiliario:
        //            return 2;
        //        case TipoActivoFijo.EquipoComputo:
        //            return 1;
        //        default:
        //            throw new ArgumentException("Tipo de activo fijo no existe.");
        //    }
        //}
    }
}
