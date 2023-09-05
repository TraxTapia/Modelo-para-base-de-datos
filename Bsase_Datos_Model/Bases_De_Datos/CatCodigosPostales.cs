namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CatCodigosPostales
    {
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string d_codigo { get; set; }

        [Required]
        [StringLength(3)]
        public string cve_ent { get; set; }

        [Required]
        [StringLength(80)]
        public string d_municipio { get; set; }

        [Required]
        [StringLength(10)]
        public string cve_mun { get; set; }

        [Required]
        [StringLength(70)]
        public string d_asenta { get; set; }
    }
}
