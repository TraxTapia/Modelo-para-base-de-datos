namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProcedimientosRecetaElectronica")]
    public partial class ProcedimientosRecetaElectronica
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string codcuenta { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string cpt { get; set; }

        public double? Importe { get; set; }
    }
}
