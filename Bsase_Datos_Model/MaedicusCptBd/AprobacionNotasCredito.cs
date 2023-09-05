namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AprobacionNotasCredito")]
    public partial class AprobacionNotasCredito
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Agrupador { get; set; }

        [Required]
        [StringLength(100)]
        public string Remesa { get; set; }

        public int IdOperaciones { get; set; }

        public decimal Importe { get; set; }

        public int Cantidad { get; set; }

        public decimal Descuento { get; set; }

        public decimal PrecioPublico { get; set; }

        public decimal Iva { get; set; }

        public decimal Isr { get; set; }

        public decimal Retiva { get; set; }

        public decimal ImpCedular { get; set; }

        public decimal Total { get; set; }

        public bool Aprobada { get; set; }

        public DateTime FechaRegistro { get; set; }

        public DateTime? FechaAprobacion { get; set; }
    }
}
