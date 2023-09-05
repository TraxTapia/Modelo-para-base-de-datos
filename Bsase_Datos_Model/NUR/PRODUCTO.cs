namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRODUCTO")]
    public partial class PRODUCTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cve_producto { get; set; }

        [StringLength(50)]
        public string descripcion { get; set; }

        public int? tipo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? costo { get; set; }

        public int? metodo { get; set; }

        public int? fpago { get; set; }
    }
}
