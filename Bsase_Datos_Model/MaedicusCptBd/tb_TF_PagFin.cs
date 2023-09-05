namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_TF_PagFin
    {
        [StringLength(200)]
        public string Remesa { get; set; }

        [StringLength(50)]
        public string FechadeFactura { get; set; }

        [StringLength(50)]
        public string FechadeRecepcion { get; set; }

        [StringLength(50)]
        public string FechadeEnvioaPago { get; set; }

        [StringLength(200)]
        public string No_fac { get; set; }

        [StringLength(200)]
        public string Cve_prov { get; set; }

        [StringLength(200)]
        public string Recursomedico { get; set; }

        public double? monto { get; set; }

        public double? Iva { get; set; }

        public double? Isr { get; set; }

        public double? Retiva { get; set; }

        public double? Impcedular { get; set; }

        public double? Total { get; set; }

        [StringLength(200)]
        public string Cve_empresa { get; set; }

        [StringLength(200)]
        public string EstatusFactura { get; set; }

        [StringLength(50)]
        public string Secuencia { get; set; }

        [StringLength(100)]
        public string TipoGasto { get; set; }

        [StringLength(50)]
        public string F_Pago { get; set; }

        [StringLength(50)]
        public string F_Regresada { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Fechadepago { get; set; }

        [StringLength(500)]
        public string Comprobante { get; set; }

        [StringLength(500)]
        public string MsgValida { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime xfecha { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Xuser { get; set; }
    }
}
