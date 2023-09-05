namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FacturaEstatus
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string no_fac { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string CodEstatusFactura { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        public DateTime FechaCambioEstatus { get; set; }
    }
}
