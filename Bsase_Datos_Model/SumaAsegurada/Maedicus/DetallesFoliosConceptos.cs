namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DetallesFoliosConceptos
    {
        [Key]
        public int idDetalleFoliosConceptos { get; set; }

        public int idFoliosConceptos { get; set; }

        public int secuenciaMac { get; set; }

        [Required]
        [StringLength(10)]
        public string codConceptoOrigen { get; set; }

        [Required]
        [StringLength(10)]
        public string codConceptoDestino { get; set; }

        [Required]
        [StringLength(40)]
        public string usuario { get; set; }

        public DateTime fecha { get; set; }

        public virtual FoliosConceptos FoliosConceptos { get; set; }
    }
}
