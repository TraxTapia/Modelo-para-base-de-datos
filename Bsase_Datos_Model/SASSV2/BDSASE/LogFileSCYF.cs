namespace Bsase_Datos_Model.SASSV2.BDSASE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogFileSCYF")]
    public partial class LogFileSCYF
    {
        public int Id { get; set; }

        public int IdFile { get; set; }

        public DateTime? FCreacion { get; set; }

        public DateTime? FModificacion { get; set; }

        public DateTime? FEliminacion { get; set; }

        [Required]
        [StringLength(30)]
        public string Estatus { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }
    }
}
