namespace Bsase_Datos_Model.Bases_De_Datos.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ReporteProveedores_nafin
    {
        [Key]
        [Column(Order = 0)]
        public int CONSECUTIVO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CVE_PROVEEDOR { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string CVE_TIPO_PROVEEDOR { get; set; }

        [Column("NOMBRE DEL PROVEEDOR")]
        [StringLength(100)]
        public string NOMBRE_DEL_PROVEEDOR { get; set; }

        [Key]
        [Column("APELLIDO PATERNO", Order = 3)]
        [StringLength(50)]
        public string APELLIDO_PATERNO { get; set; }

        [Key]
        [Column("APELLIDO MATERNO", Order = 4)]
        [StringLength(50)]
        public string APELLIDO_MATERNO { get; set; }

        [Key]
        [Column("TIPO_MOVIMIENTO ", Order = 5)]
        [StringLength(1)]
        public string TIPO_MOVIMIENTO_ { get; set; }

        public DateTime? FECHA_MOVIMIENTO { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1)]
        public string CLAVE_ESPECIALIDAD { get; set; }

        [Column("PORCENTAJE DE DESCUENTO")]
        public double? PORCENTAJE_DE_DESCUENTO { get; set; }

        [Key]
        [Column("TIPO DE FARMACIA", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TIPO_DE_FARMACIA { get; set; }

        [Column("RFC LETRAS")]
        [StringLength(4)]
        public string RFC_LETRAS { get; set; }

        [Column("RFC FECHA")]
        [StringLength(6)]
        public string RFC_FECHA { get; set; }

        [Column("RFC HOMOCLAVE")]
        [StringLength(3)]
        public string RFC_HOMOCLAVE { get; set; }

        [StringLength(50)]
        public string CURP { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(1)]
        public string FECHA_INICIO_CONVENIO { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(1)]
        public string FECHA_FIN_CONVENIO { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(100)]
        public string TELEFONO1 { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(100)]
        public string TELEFONO2 { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(20)]
        public string FAX { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(300)]
        public string EMAIL { get; set; }

        [StringLength(10)]
        public string CVE_ESTADO_PROVINCIA { get; set; }

        [StringLength(50)]
        public string POBLACION { get; set; }

        [StringLength(60)]
        public string DIRECCION { get; set; }

        [Column("NO.EXTERIOR")]
        [StringLength(25)]
        public string NO_EXTERIOR { get; set; }

        [Column("NO. INTERIOR")]
        [StringLength(25)]
        public string NO__INTERIOR { get; set; }

        [StringLength(30)]
        public string COLONIA { get; set; }

        [StringLength(5)]
        public string CP { get; set; }

        [Key]
        [Column("ZONA QUIRURJICA", Order = 14)]
        [StringLength(2)]
        public string ZONA_QUIRURJICA { get; set; }

        [Key]
        [Column("FECHA MODIFICACION", Order = 15)]
        [StringLength(1)]
        public string FECHA_MODIFICACION { get; set; }

        [Column("TIPO DE PROVEEDOR / PARA CECITEC")]
        [StringLength(50)]
        public string TIPO_DE_PROVEEDOR___PARA_CECITEC { get; set; }

        [StringLength(255)]
        public string ESPECIALIDAD { get; set; }

        [StringLength(50)]
        public string ESTADO { get; set; }
    }
}
