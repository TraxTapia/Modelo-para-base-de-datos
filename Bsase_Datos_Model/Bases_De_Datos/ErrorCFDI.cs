namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ErrorCFDI")]
    public partial class ErrorCFDI
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdErrorCFDI { get; set; }

        [StringLength(40)]
        public string UUID { get; set; }

        [Column(TypeName = "text")]
        public string Error { get; set; }

        public DateTime? Fecha { get; set; }
    }
}
