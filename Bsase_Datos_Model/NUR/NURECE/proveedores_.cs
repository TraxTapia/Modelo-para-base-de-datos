namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.proveedores#")]
    public partial class proveedores_
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codcuenta { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codubicacion { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string NMP { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string HB { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string CF { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string PRAXIS { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1)]
        public string SHENKEL { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(1)]
        public string ZONGOLICA { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(1)]
        public string CHROBINSON { get; set; }

        [StringLength(50)]
        public string NumGNP { get; set; }

        [StringLength(20)]
        public string rfc { get; set; }

        [StringLength(50)]
        public string tipopersona { get; set; }

        [StringLength(50)]
        public string apellidoP { get; set; }

        [StringLength(50)]
        public string apellidoM { get; set; }

        [StringLength(50)]
        public string Nombres { get; set; }

        [StringLength(255)]
        public string nombrecompleto { get; set; }

        [StringLength(100)]
        public string restonombre { get; set; }

        [StringLength(50)]
        public string curp { get; set; }

        [StringLength(50)]
        public string email1 { get; set; }

        [StringLength(40)]
        public string Especialidad { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(4)]
        public string subespecialidad { get; set; }

        [StringLength(40)]
        public string Estado { get; set; }

        [StringLength(30)]
        public string Poblacion { get; set; }

        [StringLength(50)]
        public string tipocuenta { get; set; }

        [StringLength(50)]
        public string TipoUbicacion { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(4)]
        public string fiscal { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(4)]
        public string servicio { get; set; }

        [StringLength(60)]
        public string direccion { get; set; }

        [StringLength(30)]
        public string Colonia { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(4)]
        public string delegación { get; set; }

        [StringLength(5)]
        public string cp { get; set; }

        [StringLength(8000)]
        public string lada { get; set; }

        [StringLength(8000)]
        public string telefono1 { get; set; }

        [StringLength(8000)]
        public string telefono2 { get; set; }

        [StringLength(50)]
        public string cedulaprofesional { get; set; }

        [StringLength(50)]
        public string cedespecialidad { get; set; }

        [StringLength(50)]
        public string certificacion { get; set; }

        public DateTime? fechaCertificacion { get; set; }

        [StringLength(50)]
        public string banco { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(4)]
        public string sucursal { get; set; }

        [StringLength(50)]
        public string cuentabancaria { get; set; }

        [StringLength(50)]
        public string clabe { get; set; }
    }
}
