namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.E_Pedidos")]
    public partial class E_Pedidos
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string KxPedido { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KnFechaCaptura { get; set; }

        public int? KnFechaSurtido { get; set; }

        public int? KnCliente { get; set; }

        public int? KnGiroCliente { get; set; }

        public int? KnTipoCliente { get; set; }

        public int? KnTipoEntrega { get; set; }

        public int? KnAsesor { get; set; }

        public int? KnRuta { get; set; }

        public int? KnAlmacen { get; set; }

        public int? KnCiudad { get; set; }

        public int? KnEstado { get; set; }

        public int? KnPais { get; set; }

        public int? KnLineaProducto { get; set; }

        public int? KnProducto { get; set; }

        public int? KnUnidadNegocio { get; set; }

        public bool? KbStatus { get; set; }

        public int? KnCategoria { get; set; }

        [Key]
        [Column(Order = 2)]
        public int Flag_F { get; set; }
    }
}
