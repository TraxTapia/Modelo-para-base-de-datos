namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OP_PEMEX_RecepcionLog
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string Remesa { get; set; }

        [Required]
        [StringLength(255)]
        public string CodControl { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string F_sapi { get; set; }

        [StringLength(255)]
        public string Guia { get; set; }

        [StringLength(255)]
        public string F_Envio { get; set; }

        [StringLength(255)]
        public string F_Entrega { get; set; }

        public string Recibe { get; set; }

        [StringLength(255)]
        public string Estatus { get; set; }

        [StringLength(255)]
        public string StFactura { get; set; }

        [StringLength(255)]
        public string Dias_Trans { get; set; }

        [Required]
        [StringLength(50)]
        public string Usr { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime Fecha { get; set; }
    }
}
