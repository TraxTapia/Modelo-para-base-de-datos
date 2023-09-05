namespace Bsase_Datos_Model.MaedicusCPTTabuladores
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FilesByListaRechazos
    {
        public int Id { get; set; }

        public int IdFileRechazo { get; set; }

        [Required]
        [StringLength(100)]
        public string FileJustificacion { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Justificacion { get; set; }

        public DateTime FechaCreacion { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        public virtual FilePreciosRechazos FilePreciosRechazos { get; set; }
    }
}
