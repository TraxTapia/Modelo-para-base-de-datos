namespace Bsase_Datos_Model.MaedicusCpt.ECEREMESAS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmpresaGrupo")]
    public partial class EmpresaGrupo
    {
        [Key]
        [StringLength(5)]
        public string CveEmpresaGrupo { get; set; }

        [StringLength(40)]
        public string Descripcion { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public DateTime? FechaBaja { get; set; }

        public DateTime? FechaActualizacion { get; set; }

        public bool? Activo { get; set; }
    }
}
