namespace Bsase_Datos_Model.VentasWeb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Productos
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Producto { get; set; }

        public double PrecioCompra { get; set; }

        public double precioVenta { get; set; }

        public int Stock { get; set; }
    }
}
