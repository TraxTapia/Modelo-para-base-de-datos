namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentacionSoporte")]
    public partial class DocumentacionSoporte
    {
        public int Id { get; set; }

        public int ProcesoId { get; set; }

        [Required]
        [StringLength(25)]
        public string Identificador { get; set; }

        [Required]
        [StringLength(255)]
        public string Documento { get; set; }

        [Required]
        [StringLength(25)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [Required]
        [StringLength(25)]
        public string UsuCambio { get; set; }

        public DateTime FechaCambio { get; set; }

        public bool? Activo { get; set; }
    }
}
