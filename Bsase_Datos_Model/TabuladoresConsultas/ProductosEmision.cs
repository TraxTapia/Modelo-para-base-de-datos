namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductosEmision")]
    public partial class ProductosEmision
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string ICodCobertura { get; set; }

        [Required]
        [StringLength(250)]
        public string VCHCodProducto { get; set; }

        public bool Activo { get; set; }
    }
}
