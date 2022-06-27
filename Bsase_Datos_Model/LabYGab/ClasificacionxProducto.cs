namespace Bsase_Datos_Model.LabYGab
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClasificacionxProducto")]
    public partial class ClasificacionxProducto
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdClasificacion { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdEstudio { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string CveAutrizacion { get; set; }

        public virtual CatalogoEstudio CatalogoEstudio { get; set; }
    }
}
