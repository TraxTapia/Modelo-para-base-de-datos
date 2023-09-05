namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentosCargadosEliminacionLog")]
    public partial class DocumentosCargadosEliminacionLog
    {
        public int Id { get; set; }

        public int DocumentoCargado_Id { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        public virtual DocumentosCargados DocumentosCargados { get; set; }
    }
}
