namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductoxClasificacion")]
    public partial class ProductoxClasificacion
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string CodProducto { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdClasificacion { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }
    }
}
