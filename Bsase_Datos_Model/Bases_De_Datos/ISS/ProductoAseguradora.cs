namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductoAseguradora")]
    public partial class ProductoAseguradora
    {
        [Key]
        [StringLength(40)]
        public string CodProducto { get; set; }

        public bool Aseguradora { get; set; }
    }
}
