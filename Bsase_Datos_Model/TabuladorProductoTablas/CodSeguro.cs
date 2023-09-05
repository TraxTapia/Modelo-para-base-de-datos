namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CodSeguro")]
    public partial class CodSeguro
    {
        [Key]
        [Column("CodSeguro")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodSeguro1 { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}
