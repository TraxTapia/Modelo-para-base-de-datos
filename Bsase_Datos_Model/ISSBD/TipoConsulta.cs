namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoConsulta")]
    public partial class TipoConsulta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodTipoConsulta { get; set; }

        [Column("TipoConsulta")]
        [Required]
        [StringLength(50)]
        public string TipoConsulta1 { get; set; }
    }
}
