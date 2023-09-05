namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MotivoConsulta")]
    public partial class MotivoConsulta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodMotivoConsulta { get; set; }

        [Column("MotivoConsulta")]
        [Required]
        [StringLength(50)]
        public string MotivoConsulta1 { get; set; }
    }
}
