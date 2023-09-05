namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Parentesco")]
    public partial class Parentesco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodParentesco { get; set; }

        [Column("Parentesco")]
        [Required]
        [StringLength(50)]
        public string Parentesco1 { get; set; }

        public int? CodSicas { get; set; }
    }
}
