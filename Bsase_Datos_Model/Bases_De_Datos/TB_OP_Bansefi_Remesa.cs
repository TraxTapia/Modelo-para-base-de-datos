namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_OP_Bansefi_Remesa
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string no_fac { get; set; }

        [StringLength(30)]
        public string f_factura { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string nombreFiscal { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Expediente { get; set; }

        [Key]
        [Column(Order = 3)]
        public string Derechohabiente { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(8000)]
        public string estatus { get; set; }

        [Key]
        [Column(Order = 5)]
        public string Medico { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string Especialidad { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(100)]
        public string Nivel_de_Atencion { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(30)]
        public string Fecha { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(255)]
        public string TipoServicio_Diagnostico { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(20)]
        public string CPT_Pase { get; set; }

        public decimal? importe { get; set; }

        [Key]
        [Column("%AplicacionCPT", Order = 11)]
        [StringLength(4000)]
        public string C_AplicacionCPT { get; set; }

        public decimal? ImporteDescuento { get; set; }

        [Key]
        [Column(Order = 12)]
        public double SubTotal { get; set; }

        [Key]
        [Column(Order = 13)]
        public double Ret_IVA { get; set; }

        [Key]
        [Column(Order = 14)]
        public double Ret_ISR { get; set; }

        public double? IVA { get; set; }

        public double? Total { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(1)]
        public string MesPago { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(255)]
        public string Observaciones { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(50)]
        public string remesa { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int secuenciaMac { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(255)]
        public string Tipo_DerechoHabiente { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(40)]
        public string Parentesco { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(255)]
        public string Descripcion { get; set; }

        [Key]
        [Column(Order = 22)]
        public double Cantidad { get; set; }

        public double? Precio_Normal { get; set; }

        [Key]
        [Column("%Descuento", Order = 23)]
        [StringLength(4000)]
        public string C_Descuento { get; set; }

        [Key]
        [Column(Order = 24)]
        [StringLength(20)]
        public string Clave_Articulo { get; set; }

        [Key]
        [Column(Order = 25)]
        [StringLength(50)]
        public string Nomina { get; set; }

        [Key]
        [Column(Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodTipoGasto { get; set; }

        [Key]
        [Column(Order = 27)]
        public string Tipo_medicamento { get; set; }

        [Key]
        [Column(Order = 28)]
        public string Laboratorio { get; set; }

        [Key]
        [Column(Order = 29)]
        public string Sucursal { get; set; }

        [Key]
        [Column(Order = 30)]
        [StringLength(50)]
        public string DescuentoFH { get; set; }

        [Key]
        [Column(Order = 31)]
        [StringLength(50)]
        public string Importe_DESCTO { get; set; }

        [Key]
        [Column(Order = 32)]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 33)]
        [StringLength(12)]
        public string TIPO { get; set; }

        [Key]
        [Column(Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(8000)]
        public string Descripcion_Monto { get; set; }

        [StringLength(50)]
        public string Expediente_FH { get; set; }

        public string Derechohabiente_FH { get; set; }

        [StringLength(50)]
        public string Tipo_DerechoHabiente_FH { get; set; }

        [StringLength(50)]
        public string Expediente_Gpo { get; set; }

        public string Derechohabiente_Gpo { get; set; }

        [StringLength(100)]
        public string Estatus_Gpo { get; set; }

        public string Medico_Gpo { get; set; }

        [StringLength(100)]
        public string Especialidad_Gpo { get; set; }

        [Column("Nivel de Atencion_Gpo")]
        [StringLength(100)]
        public string Nivel_de_Atencion_Gpo { get; set; }

        [Column("Fecha Consulta_Gpo")]
        [StringLength(50)]
        public string Fecha_Consulta_Gpo { get; set; }

        public string d_v_idx_Gpo { get; set; }

        [StringLength(50)]
        public string Pase_Gpo { get; set; }

        [Column("Tipo de Servicio o Diagnostico_Gpo")]
        [StringLength(100)]
        public string Tipo_de_Servicio_o_Diagnostico_Gpo { get; set; }

        [StringLength(255)]
        public string Diagnostico { get; set; }
    }
}
