namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CobranzaCotsco")]
    public partial class CobranzaCotsco
    {
        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Required]
        [StringLength(50)]
        public string no_fac { get; set; }

        public int secuenciaMac { get; set; }

        [Required]
        [StringLength(80)]
        public string adicional1 { get; set; }

        [Required]
        [StringLength(80)]
        public string adicional2 { get; set; }

        [Required]
        [StringLength(80)]
        public string adicional3 { get; set; }

        [Required]
        [StringLength(80)]
        public string adicional4 { get; set; }

        [Required]
        [StringLength(80)]
        public string adicional5 { get; set; }

        [StringLength(100)]
        public string uuid { get; set; }

        public DateTime? fSecuencPagado { get; set; }

        public DateTime? fSecuencAnticipo { get; set; }

        [Required]
        [StringLength(50)]
        public string tipoPago { get; set; }

        [Required]
        [StringLength(255)]
        public string observaciones { get; set; }

        [Required]
        [StringLength(50)]
        public string rga { get; set; }

        public DateTime? fCobroRga { get; set; }

        [Required]
        [StringLength(50)]
        public string tipoCobro { get; set; }

        public decimal importeRga { get; set; }

        public decimal cobranza { get; set; }

        public decimal saldo { get; set; }

        public decimal montoNC { get; set; }

        public decimal montoPendienteCobro { get; set; }

        [Required]
        [StringLength(100)]
        public string fA { get; set; }

        [Required]
        [StringLength(25)]
        public string estatusFactura { get; set; }

        [Required]
        [StringLength(25)]
        public string factureaRelacionada { get; set; }

        [Required]
        [StringLength(50)]
        public string usu_alta { get; set; }

        public DateTime fecha_alta { get; set; }

        [Required]
        [StringLength(50)]
        public string usu_cambio { get; set; }

        public DateTime fecha_cambio { get; set; }
    }
}
