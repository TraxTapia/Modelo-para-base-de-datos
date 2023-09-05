namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transferencias_TB_CargoLOG
    {
        public int? Id { get; set; }

        [StringLength(50)]
        public string Cuenta { get; set; }

        [StringLength(255)]
        public string cve_empresa { get; set; }

        public bool? estatus { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string operacion { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime fechaCambio { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string usuarioCambio { get; set; }
    }
}
