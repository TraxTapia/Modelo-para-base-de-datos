namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_mediaccess_Producto_Tabulador
    {
        public int? CodTabulador { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string codProducto { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string Descripcion { get; set; }
    }
}
