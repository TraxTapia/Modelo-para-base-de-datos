namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PermisoDocumentoAfiliado")]
    public partial class PermisoDocumentoAfiliado
    {
        public int Id { get; set; }

        public int IdDocumento { get; set; }

        [Required]
        [StringLength(50)]
        public string Agrupacion { get; set; }

        public bool Activo { get; set; }
    }
}
