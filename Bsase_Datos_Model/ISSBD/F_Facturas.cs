namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.F_Facturas")]
    public partial class F_Facturas
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string KxFactura { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KnFechaEmision { get; set; }

        public int? KnFechaVencimiento { get; set; }

        public int? KnFechaPago { get; set; }

        public int? KnProducto { get; set; }

        public int? KnLineaProducto { get; set; }

        public int? KnCategoria { get; set; }

        public int? KnUnidadNegocio { get; set; }

        public int? KnAsesor { get; set; }

        public int? KnRuta { get; set; }

        public int? KnAlmacen { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KnCiudad { get; set; }

        public int? KnEstado { get; set; }

        public int? KnPais { get; set; }

        public int? KnCliente { get; set; }

        public int? KnGiroCliente { get; set; }

        public int? KnTipoCliente { get; set; }

        public bool? KbStatus { get; set; }

        public int? MnUnidades { get; set; }

        public double? MfPrecioVenta { get; set; }

        public double? MfCosto { get; set; }

        public double? MfUtilidad { get; set; }

        public int? MnPorcUtilidad { get; set; }

        [Key]
        [Column(Order = 3)]
        public int Flag_F { get; set; }
    }
}
