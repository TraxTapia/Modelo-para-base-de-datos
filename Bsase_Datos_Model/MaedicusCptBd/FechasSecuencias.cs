namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FechasSecuencias
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SecuenciaMac { get; set; }

        public DateTime? FechaEnvioCliente { get; set; }

        public DateTime? FechaPagoCliente { get; set; }

        public DateTime? FechaFactura { get; set; }

        public DateTime? FechaRecepcion { get; set; }

        public DateTime? FechaEnvioPago { get; set; }

        public DateTime? FechaVoBo { get; set; }

        public DateTime? Fecha_Envio_Facturas { get; set; }

        [StringLength(50)]
        public string Cve_Empresa { get; set; }

        [StringLength(200)]
        public string SubEstatus { get; set; }

        [StringLength(10)]
        public string CodConcepto { get; set; }

        [StringLength(50)]
        public string RGA { get; set; }

        [StringLength(50)]
        public string EstatusSistema { get; set; }

        [StringLength(2)]
        public string CodEstatusFactura { get; set; }
    }
}
