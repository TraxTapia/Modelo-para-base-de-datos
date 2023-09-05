namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NotaCreditoDetalle")]
    public partial class NotaCreditoDetalle
    {
        public int Id { get; set; }

        public int IdNotaCredito { get; set; }

        [Required]
        [StringLength(50)]
        public string Remesa { get; set; }

        [Required]
        [StringLength(50)]
        public string RemesaSeguro { get; set; }

        public int IdOperaciones { get; set; }

        public decimal Monto { get; set; }

        public decimal IVA { get; set; }

        public decimal Total { get; set; }

        [Required]
        [StringLength(10)]
        public string CveEmpresa { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [StringLength(50)]
        public string UsuCambio { get; set; }

        public DateTime? FechaCambio { get; set; }

        public bool Eliminado { get; set; }

        public virtual NotaCredito NotaCredito { get; set; }
    }
}
