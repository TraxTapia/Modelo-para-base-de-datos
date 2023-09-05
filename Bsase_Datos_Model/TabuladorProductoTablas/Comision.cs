namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comision")]
    public partial class Comision
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodEmpresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodTipoVendedor { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string CodProducto { get; set; }

        public double? Importe { get; set; }

        public double? Porcentaje { get; set; }

        public virtual Empresa Empresa { get; set; }

        public virtual TipoVendedor TipoVendedor { get; set; }
    }
}
