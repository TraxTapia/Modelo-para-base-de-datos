namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ReporteProveedores
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
        [StringLength(9)]
        public string RED { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string CVE_TIPO_PROVEEDOR { get; set; }

        [StringLength(50)]
        public string TipoProveedor { get; set; }

        [Column("NOMBRE DEL PROVEEDOR")]
        [StringLength(255)]
        public string NOMBRE_DEL_PROVEEDOR { get; set; }

        [Column("NOMBRE COMERCIAL")]
        [StringLength(100)]
        public string NOMBRE_COMERCIAL { get; set; }

        [Column("APELLIDO PATERNO")]
        [StringLength(1000)]
        public string APELLIDO_PATERNO { get; set; }

        [Column("APELLIDO MATERNO")]
        [StringLength(1000)]
        public string APELLIDO_MATERNO { get; set; }

        [StringLength(100)]
        public string NOMBRE { get; set; }

        [Key]
        [Column("PERSONA JURIDICA", Order = 4)]
        [StringLength(6)]
        public string PERSONA_JURIDICA { get; set; }

        [Key]
        [Column("TIPO_MOVIMIENTO ", Order = 5)]
        [StringLength(1)]
        public string TIPO_MOVIMIENTO_ { get; set; }

        public DateTime? FECHA_MOVIMIENTO { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1)]
        public string CLAVE_ESPECIALIDAD { get; set; }

        [Column("PORCENTAJE DE DESCUENTO", TypeName = "numeric")]
        public decimal? PORCENTAJE_DE_DESCUENTO { get; set; }

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

        [StringLength(20)]
        public string RFC { get; set; }

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

        [Column("LADA 1")]
        [StringLength(20)]
        public string LADA_1 { get; set; }

        [StringLength(1000)]
        public string TELEFONO1 { get; set; }

        [Column("LADA 2")]
        [StringLength(20)]
        public string LADA_2 { get; set; }

        [StringLength(1000)]
        public string TELEFONO2 { get; set; }

        [StringLength(50)]
        public string CELULAR { get; set; }

        [StringLength(1000)]
        public string FAX { get; set; }

        [StringLength(1000)]
        public string EMAIL { get; set; }

        [Column("HORARIO DE ATENCION")]
        [StringLength(30)]
        public string HORARIO_DE_ATENCION { get; set; }

        [StringLength(10)]
        public string CVE_ESTADO_PROVINCIA { get; set; }

        [StringLength(50)]
        public string POBLACION { get; set; }

        [StringLength(50)]
        public string MUNICIPIO { get; set; }

        [StringLength(1000)]
        public string DIRECCION { get; set; }

        [Column("NO.EXTERIOR")]
        [StringLength(1000)]
        public string NO_EXTERIOR { get; set; }

        [Column("NO. INTERIOR")]
        [StringLength(1000)]
        public string NO__INTERIOR { get; set; }

        [StringLength(1000)]
        public string COLONIA { get; set; }

        [StringLength(1000)]
        public string CP { get; set; }

        [Key]
        [Column("ZONA QUIRURJICA", Order = 10)]
        [StringLength(2)]
        public string ZONA_QUIRURJICA { get; set; }

        [Key]
        [Column("FECHA MODIFICACION", Order = 11)]
        [StringLength(1)]
        public string FECHA_MODIFICACION { get; set; }

        [Column("TIPO DE PROVEEDOR / PARA CECITEC")]
        [StringLength(50)]
        public string TIPO_DE_PROVEEDOR___PARA_CECITEC { get; set; }

        [StringLength(255)]
        public string ESPECIALIDAD { get; set; }

        [StringLength(10)]
        public string SUBESPECIALIDAD { get; set; }

        [StringLength(50)]
        public string ESTADO { get; set; }

        [Column("CUENTA BANCARIA")]
        [StringLength(50)]
        public string CUENTA_BANCARIA { get; set; }

        [StringLength(50)]
        public string CLABE { get; set; }

        [StringLength(50)]
        public string BANCO { get; set; }

        [Column(" CEDULA PROFESIONAL")]
        [StringLength(50)]
        public string C_CEDULA_PROFESIONAL { get; set; }

        [Column("CEDULA ESPECIALIDAD")]
        [StringLength(50)]
        public string CEDULA_ESPECIALIDAD { get; set; }

        [StringLength(50)]
        public string CERTIFICACION { get; set; }

        [Column("FECHA DE CERTIFICACION")]
        public DateTime? FECHA_DE_CERTIFICACION { get; set; }

        [Key]
        [Column("COSTO CONSULTA CONVENIDO", Order = 12)]
        [StringLength(1)]
        public string COSTO_CONSULTA_CONVENIDO { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(10)]
        public string CodPoblacion { get; set; }

        [StringLength(10)]
        public string codEspecialidad { get; set; }

        public int? codBanco { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(20)]
        public string Lada { get; set; }

        [Column("Celular 1")]
        [StringLength(1000)]
        public string Celular_1 { get; set; }

        [Column("Celular 2")]
        [StringLength(1000)]
        public string Celular_2 { get; set; }

        [Column("Email 2")]
        [StringLength(1000)]
        public string Email_2 { get; set; }
    }
}
