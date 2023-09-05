namespace Bsase_Datos_Model.BDMediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Banco")]
    public partial class Banco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodBanco { get; set; }

        [Column("Banco")]
        [StringLength(50)]
        public string Banco1 { get; set; }
    }
}
