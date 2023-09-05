namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Producto_Comision
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ClaveProducto { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string Descripcion { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(250)]
        public string RegistroComision { get; set; }
    }
}
