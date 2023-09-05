namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OP_VF_pemex_Carga
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string no_fac { get; set; }

        [StringLength(50)]
        public string secuenciaMac { get; set; }

        [StringLength(18)]
        public string consecutivo { get; set; }

        [StringLength(20)]
        public string folio { get; set; }

        public DateTime? f_ocurrido { get; set; }

        [StringLength(2)]
        public string CodFormato { get; set; }

        [StringLength(10)]
        public string CodCopiaFormato { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string cve_empresa { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Nomina { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numbenef { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(10)]
        public string cve_cie { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(4)]
        public string cve_espec { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(20)]
        public string cve_proc { get; set; }

        [Key]
        [Column(Order = 9)]
        public double importe { get; set; }

        [Key]
        [Column(Order = 10)]
        public double iva { get; set; }

        [Key]
        [Column(Order = 11)]
        public double isr { get; set; }

        [Key]
        [Column(Order = 12)]
        public double retiva { get; set; }

        public double? impCedular { get; set; }

        [Key]
        [Column(Order = 13)]
        public double total { get; set; }

        [StringLength(10)]
        public string articulo { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(25)]
        public string CodLogin { get; set; }

        [Key]
        [Column(Order = 15)]
        public double cantidad { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(50)]
        public string CodTabulador { get; set; }

        [StringLength(150)]
        public string Exadmin { get; set; }

        [StringLength(10)]
        public string ccostos { get; set; }

        [StringLength(50)]
        public string autorizacion { get; set; }

        public DateTime? f_ingreso { get; set; }

        public DateTime? f_egreso { get; set; }

        [StringLength(200)]
        public string sucursal { get; set; }

        [StringLength(10)]
        public string provOrigen { get; set; }

        [StringLength(50)]
        public string tipoEmpleado { get; set; }

        public double? porCopago { get; set; }

        public double? impCopago { get; set; }

        public DateTime? fecha { get; set; }

        public int? anioLP { get; set; }

        public double? descuento { get; set; }

        [StringLength(50)]
        public string Elegibilidad { get; set; }

        [StringLength(255)]
        public string Nombre_Medico { get; set; }

        [StringLength(255)]
        public string nombre_afiliado { get; set; }

        public bool? Valida { get; set; }

        [StringLength(255)]
        public string Valmsg { get; set; }
    }
}
