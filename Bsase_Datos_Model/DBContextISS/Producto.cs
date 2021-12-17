namespace Bsase_Datos_Model.DBContextISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producto")]
    public partial class Producto
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string CodProducto { get; set; }

        [Column("Producto")]
        [Required]
        [StringLength(500)]
        public string Producto1 { get; set; }

        [StringLength(500)]
        public string descripcion { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codPlan { get; set; }

        [StringLength(1)]
        public string Estatus { get; set; }

        public int? idProducto { get; set; }
    }
}
