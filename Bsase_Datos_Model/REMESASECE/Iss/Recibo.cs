namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Recibo")]
    public partial class Recibo
    {
        [Key]
        [StringLength(20)]
        public string NoRecibo { get; set; }

        public int CodEmpresa { get; set; }

        [StringLength(20)]
        public string CodAfiliado { get; set; }

        public int? Correlativo { get; set; }

        [StringLength(20)]
        public string NoFactura { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FechaRecibo { get; set; }

        public int CodAcreedor { get; set; }

        [Required]
        [StringLength(15)]
        public string CodProducto { get; set; }

        public double importeunitario { get; set; }

        public double cantidad { get; set; }

        public double iva { get; set; }

        public double isr { get; set; }

        public double retiva { get; set; }

        public double total { get; set; }

        public virtual Empresa Empresa { get; set; }

        public virtual FacturaFranquicia FacturaFranquicia { get; set; }

        public virtual SSR SSR { get; set; }
    }
}
