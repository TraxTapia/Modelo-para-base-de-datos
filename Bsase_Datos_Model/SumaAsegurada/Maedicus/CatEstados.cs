namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CatEstados
    {
        [Key]
        [StringLength(2)]
        public string cve_ent { get; set; }

        [Required]
        [StringLength(255)]
        public string nom_ent { get; set; }

        [Required]
        [StringLength(25)]
        public string nom_abr { get; set; }
    }
}
