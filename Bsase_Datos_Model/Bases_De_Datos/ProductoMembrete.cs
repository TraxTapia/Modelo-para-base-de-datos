namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductoMembrete")]
    public partial class ProductoMembrete
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(50)]
        public string ClaveProducto { get; set; }

        [StringLength(50)]
        public string Producto { get; set; }

        [StringLength(50)]
        public string Membrete { get; set; }

        [StringLength(50)]
        public string ReporteCredencial { get; set; }

        public bool? Activo { get; set; }
    }
}
