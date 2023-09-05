namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Layout_SHF_Entrega
    {
        [StringLength(255)]
        public string H_ST_Serv { get; set; }

        [StringLength(255)]
        public string H_fec_Serv { get; set; }

        [StringLength(255)]
        public string H_Empl_Serv { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string cve_proc { get; set; }

        [StringLength(50)]
        public string remesa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string metodoPago { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string ComprobanteNumCheque { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string no_fac { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime fechaRecepcionFactura { get; set; }

        [StringLength(50)]
        public string Nomina { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int numbenef { get; set; }

        [StringLength(20)]
        public string folio { get; set; }

        [StringLength(255)]
        public string Datestado { get; set; }

        [StringLength(8000)]
        public string nombre { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime fechaNace { get; set; }

        [StringLength(3)]
        public string sexo { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(40)]
        public string parentesco { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime fechaServicio { get; set; }

        [StringLength(10)]
        public string fechaPago { get; set; }

        [StringLength(50)]
        public string LugarSevicio { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(5)]
        public string cve_cie { get; set; }

        [StringLength(255)]
        public string diagnostico { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(10)]
        public string ClavePrestadorCobra { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(200)]
        public string PrestadorCobra { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(50)]
        public string tipogasto { get; set; }

        [StringLength(100)]
        public string especialidad { get; set; }

        [Key]
        [Column(Order = 13)]
        public double importe { get; set; }

        [Key]
        [Column(Order = 14)]
        public double iva { get; set; }

        [Key]
        [Column(Order = 15)]
        public double isr { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(4)]
        public string tasa { get; set; }

        [Key]
        [Column(Order = 17)]
        public double retiva { get; set; }

        public double? impCedular { get; set; }

        [Key]
        [Column(Order = 18)]
        public double total { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(50)]
        public string rfc { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(20)]
        public string CodEan { get; set; }

        [StringLength(511)]
        public string Medicamento { get; set; }

        [Key]
        [Column(Order = 21)]
        public double cantidad { get; set; }

        [StringLength(255)]
        public string TipoProcedimiento { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(200)]
        public string sucursal { get; set; }

        [StringLength(50)]
        public string autorizacion { get; set; }

        [Key]
        [Column(Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int secuenciamac { get; set; }

        [Key]
        [Column(Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 25)]
        [StringLength(50)]
        public string codtabulador { get; set; }

        [StringLength(8000)]
        public string Descripcion_Monto { get; set; }

        [StringLength(1)]
        public string Identy { get; set; }

        public virtual Facturas Facturas { get; set; }
    }
}
