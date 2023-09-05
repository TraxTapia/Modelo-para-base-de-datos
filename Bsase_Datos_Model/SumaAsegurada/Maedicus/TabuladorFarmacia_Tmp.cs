namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TabuladorFarmacia_Tmp
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CodigoEAN { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string Descripcion { get; set; }

        [Key]
        [Column(Order = 2)]
        public double PMP { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string CodEstatus { get; set; }
    }
}
