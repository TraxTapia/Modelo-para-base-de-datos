namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Layout_SHF_Ope
    {
        [StringLength(50)]
        public string H_ST_Serv { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string cve_proc { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Nomina { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numbenef { get; set; }

        [StringLength(20)]
        public string Folio { get; set; }

        [StringLength(4)]
        public string CodEstado { get; set; }

        [StringLength(8000)]
        public string Nombre { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime F_nace { get; set; }

        [StringLength(3)]
        public string Sexo { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(40)]
        public string Parentesco { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime f_ocurrido { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(5)]
        public string cve_cie { get; set; }

        [StringLength(255)]
        public string Diagnostico { get; set; }

        [Key]
        [Column(Order = 7)]
        public double importe { get; set; }

        [Key]
        [Column(Order = 8)]
        public double iva { get; set; }

        [Key]
        [Column(Order = 9)]
        public double isr { get; set; }

        [Key]
        [Column(Order = 10)]
        public double retiva { get; set; }

        public double? impCedular { get; set; }

        [Key]
        [Column(Order = 11)]
        public double cantidad { get; set; }

        [Key]
        [Column(Order = 12)]
        public double total { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(50)]
        public string CodTabulador { get; set; }

        [StringLength(8000)]
        public string Descripcion_Monto { get; set; }

        [StringLength(200)]
        public string sucursal { get; set; }

        [StringLength(50)]
        public string autorizacion { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(50)]
        public string no_fac { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(18)]
        public string consecutivo { get; set; }

        public int? SecuenciaMac { get; set; }

        public virtual Facturas Facturas { get; set; }
    }
}
