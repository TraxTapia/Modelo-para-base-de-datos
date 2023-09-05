namespace Bsase_Datos_Model.REMESASECE.Mediaccess
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
        [StringLength(100)]
        public string Parentesco1 { get; set; }
    }
}
