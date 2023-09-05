namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SEPOMEX_CP
    {
        public int id { get; set; }

        [Required]
        [StringLength(5)]
        public string d_codigo { get; set; }

        [Required]
        [StringLength(255)]
        public string d_asenta { get; set; }

        [Required]
        [StringLength(5)]
        public string d_CP { get; set; }

        [Required]
        [StringLength(2)]
        public string c_estado { get; set; }

        [Required]
        [StringLength(5)]
        public string c_oficina { get; set; }

        [Required]
        [StringLength(5)]
        public string c_CP { get; set; }

        [Required]
        [StringLength(2)]
        public string c_tipo_asenta { get; set; }

        [Required]
        [StringLength(3)]
        public string c_mnpio { get; set; }

        [Required]
        [StringLength(4)]
        public string id_asenta_cpcons { get; set; }

        [Required]
        [StringLength(2)]
        public string c_cve_ciudad { get; set; }
    }
}
