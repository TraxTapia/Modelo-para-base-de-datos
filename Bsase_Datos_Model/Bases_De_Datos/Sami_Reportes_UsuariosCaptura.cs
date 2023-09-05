namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sami_Reportes_UsuariosCaptura
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdAreasCaptura { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string cve_usuario { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Status { get; set; }

        public virtual Sami_Reportes_AreasCaptura Sami_Reportes_AreasCaptura { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
