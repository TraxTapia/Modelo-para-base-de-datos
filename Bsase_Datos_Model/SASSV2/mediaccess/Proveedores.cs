namespace Bsase_Datos_Model.SASSV2.mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Proveedores
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cve_prov { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(13)]
        public string rfc_prov { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string nom_fiscal { get; set; }

        [StringLength(200)]
        public string nom_comercial { get; set; }

        [StringLength(200)]
        public string direc_fiscal { get; set; }

        public int? cve_colonia { get; set; }
    }
}
