namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SSR")]
    public partial class SSR
    {
        [Key]
        [StringLength(20)]
        public string NoRecibo { get; set; }

        public int CodEmpresa { get; set; }

        [StringLength(20)]
        public string CodAfiliado { get; set; }

        public int? Correlativo { get; set; }

        public int Secuencia { get; set; }

        public int CodDivisa { get; set; }

        public DateTime FechaTransferencia { get; set; }

        public int CodBanco { get; set; }

        public double Importe { get; set; }

        public int CodTipoPago { get; set; }

        [Required]
        [StringLength(20)]
        public string NoCuenta { get; set; }

        public double IVA { get; set; }

        [Required]
        [StringLength(1)]
        public string CodEstatusPago { get; set; }

        public int CodDevolucion { get; set; }

        [Required]
        [StringLength(8)]
        public string NoLote { get; set; }

        public double TipoCambio { get; set; }

        public virtual Banco Banco { get; set; }

        public virtual Divisa Divisa { get; set; }

        public virtual EstatusPago EstatusPago { get; set; }

        public virtual LOTE LOTE { get; set; }

        public virtual MotivoDevolucion MotivoDevolucion { get; set; }

        public virtual Recibo Recibo { get; set; }

        public virtual TipoPago TipoPago { get; set; }
    }
}
