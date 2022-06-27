namespace Bsase_Datos_Model.CajaAhorro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ahorro")]
    public partial class Ahorro
    {
        public int Id { get; set; }

        public int Id_Usuario { get; set; }

        public decimal Cantidad { get; set; }

        public DateTime Fecha_Cobro { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
