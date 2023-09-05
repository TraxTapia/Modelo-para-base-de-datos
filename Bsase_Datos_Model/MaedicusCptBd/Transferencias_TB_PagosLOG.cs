namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transferencias_TB_PagosLOG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string no_fac { get; set; }

        public DateTime fecha { get; set; }

        [StringLength(50)]
        public string hora { get; set; }

        [StringLength(200)]
        public string suc { get; set; }

        [StringLength(200)]
        public string descripcion { get; set; }

        [StringLength(200)]
        public string cargo { get; set; }

        [StringLength(200)]
        public string abono { get; set; }

        [StringLength(200)]
        public string saldo { get; set; }

        [StringLength(200)]
        public string referencia { get; set; }

        [StringLength(500)]
        public string concepto { get; set; }

        [StringLength(500)]
        public string interbancaria { get; set; }

        [StringLength(255)]
        public string Archivo { get; set; }

        public DateTime XFecha { get; set; }

        [StringLength(50)]
        public string Xuser { get; set; }

        public int? SecuenciaMac { get; set; }

        public virtual Facturas Facturas { get; set; }
    }
}
