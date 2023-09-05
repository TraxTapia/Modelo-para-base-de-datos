namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductoImpresion")]
    public partial class ProductoImpresion
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string CodProducto { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(500)]
        public string Producto { get; set; }

        [StringLength(500)]
        public string descripcion { get; set; }

        public int? codPlan { get; set; }

        public int? idProducto { get; set; }
    }
}
