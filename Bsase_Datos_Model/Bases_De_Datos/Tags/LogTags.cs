namespace Bsase_Datos_Model.Bases_De_Datos.Tags
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LogTags
    {
        [Key]
        public int IdLogTag { get; set; }

        public int IdTag { get; set; }

        [Required]
        [StringLength(50)]
        public string Tag { get; set; }

        [Required]
        [StringLength(100)]
        public string DescripcionLarga { get; set; }

        public bool? Activo { get; set; }

        public DateTime DateInsert { get; set; }

        [Required]
        [StringLength(100)]
        public string UserInsert { get; set; }
    }
}
