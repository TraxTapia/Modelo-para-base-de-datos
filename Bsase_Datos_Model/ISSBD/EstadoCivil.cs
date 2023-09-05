namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstadoCivil")]
    public partial class EstadoCivil
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodEstadoCivil { get; set; }

        [Column("EstadoCivil")]
        [Required]
        [StringLength(50)]
        public string EstadoCivil1 { get; set; }
    }
}
