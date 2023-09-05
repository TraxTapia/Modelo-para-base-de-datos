namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mcpt.CargaMasivaFarmacia")]
    public partial class CargaMasivaFarmacia
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string no_fac { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime f_factura { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string Folio { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Autoriza { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime fechaVenta { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(5)]
        public string cve_empresa { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(12)]
        public string Nomina { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numbenef { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(5)]
        public string cve_cie { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(20)]
        public string cve_proc { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cantidad { get; set; }

        [Key]
        [Column(Order = 12)]
        public double Importe { get; set; }

        [Key]
        [Column(Order = 13)]
        public double IVA { get; set; }

        [Key]
        [Column(Order = 14)]
        public double ISR { get; set; }

        [Key]
        [Column(Order = 15)]
        public double RetIVA { get; set; }

        [Key]
        [Column(Order = 16)]
        public double Total { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Flag { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int i { get; set; }
    }
}
