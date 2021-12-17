namespace Bsase_Datos_Model.MaedicusCpt.Especialidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Especialidad")]
    public partial class Especialidad
    {
        [Key]
        [StringLength(4)]
        public string cve_espec { get; set; }

        [Column("Especialidad")]
        [Required]
        [StringLength(100)]
        public string Especialidad1 { get; set; }

        public int CodTipoGasto { get; set; }

        [StringLength(10)]
        public string Articulo_con_Retencion { get; set; }

        [StringLength(50)]
        public string Articulo_sin_Retencion { get; set; }

        public bool Activo { get; set; }
    }
}
