namespace Bsase_Datos_Model.Aseguradora
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogProductosEmision")]
    public partial class LogProductosEmision
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string ICodCobertura { get; set; }

        [Required]
        [StringLength(250)]
        public string VCHCodProducto { get; set; }

        [Required]
        [StringLength(250)]
        public string ICodCoberturaCambio { get; set; }

        [Required]
        [StringLength(250)]
        public string VCHCodProductoCambio { get; set; }

        [Required]
        [StringLength(30)]
        public string Estatus { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public DateTime? FechaBaja { get; set; }

        [Required]
        [StringLength(100)]
        public string Usuario { get; set; }
    }
}
