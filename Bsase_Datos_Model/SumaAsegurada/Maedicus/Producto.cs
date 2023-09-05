namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producto")]
    public partial class Producto
    {
        [StringLength(25)]
        public string CodProducto { get; set; }

        [Key]
        [Column("Producto")]
        [StringLength(500)]
        public string Producto1 { get; set; }

        [StringLength(500)]
        public string descripcion { get; set; }

        public int? codPlan { get; set; }

        [StringLength(1)]
        public string Estatus { get; set; }
    }
}
