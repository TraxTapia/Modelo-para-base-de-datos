namespace Bsase_Datos_Model.Bases_De_Datos.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SamiEspecialidad")]
    public partial class SamiEspecialidad
    {
        [Key]
        [StringLength(4)]
        public string cve_espec { get; set; }

        [Required]
        [StringLength(100)]
        public string Especialidad { get; set; }

        public int CodTipoGasto { get; set; }

        [StringLength(10)]
        public string Articulo_con_Retencion { get; set; }

        [StringLength(50)]
        public string Articulo_sin_Retencion { get; set; }

        public DateTime fechaActualizacion { get; set; }
    }
}
