namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Layout_SHF_fac
    {
        [StringLength(50)]
        public string remesa { get; set; }

        [StringLength(2)]
        public string Metodo { get; set; }

        [StringLength(25)]
        public string comprobante { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string no_fac { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime f_recepcion { get; set; }

        public DateTime? f_pago { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(200)]
        public string RecursoMedico { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string TipoGasto { get; set; }

        [StringLength(100)]
        public string Especialidad { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string RFC { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int secuenciaMac { get; set; }

        public int? Año { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string EstatusFactura { get; set; }

        public bool? Valor { get; set; }

        public virtual Facturas Facturas { get; set; }
    }
}
