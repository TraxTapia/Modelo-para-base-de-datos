namespace Bsase_Datos_Model.REMESASECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FacturaxRemesa")]
    public partial class FacturaxRemesa
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string FolioRemesa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string UUID { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public virtual FacturaRemesa FacturaRemesa { get; set; }
    }
}
