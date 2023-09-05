namespace Bsase_Datos_Model.macmedi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoGasto")]
    public partial class TipoGasto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodTipoGasto { get; set; }

        [Column("TipoGasto")]
        [Required]
        [StringLength(50)]
        public string TipoGasto1 { get; set; }
    }
}
