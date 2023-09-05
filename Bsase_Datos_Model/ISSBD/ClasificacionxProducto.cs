namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClasificacionxProducto")]
    public partial class ClasificacionxProducto
    {
        public int Id { get; set; }

        public int IdClasificacion { get; set; }

        public int IdEstudio { get; set; }

        [Required]
        [StringLength(10)]
        public string CveAutorizacion { get; set; }

        public virtual CatalogoEstudio CatalogoEstudio { get; set; }
    }
}
