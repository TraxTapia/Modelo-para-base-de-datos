namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CalculoReservaProveedor")]
    public partial class CalculoReservaProveedor
    {
        public int Id { get; set; }

        public int IdCuadro { get; set; }

        public int CveProveedor { get; set; }

        public bool Activo { get; set; }
    }
}
