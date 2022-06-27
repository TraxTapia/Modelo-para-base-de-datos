namespace Bsase_Datos_Model.GabyLab
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
        public string CveAutorizacion { get; set; }

        public virtual CatalogoEstudio CatalogoEstudio { get; set; }
    }
}
