namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("empleadosRH")]
    public partial class empleadosRH
    {
        public int? idEmpleado { get; set; }

        [StringLength(50)]
        public string nombres { get; set; }

        [StringLength(50)]
        public string aPaterno { get; set; }

        [StringLength(50)]
        public string aMaterno { get; set; }

        [StringLength(10)]
        public string codSexo { get; set; }

        [StringLength(10)]
        public string codEstado { get; set; }

        public int? codPoblacion { get; set; }

        public int? idEstadoCivil { get; set; }

        [StringLength(50)]
        public string rfc { get; set; }

        [StringLength(50)]
        public string curp { get; set; }

        [Key]
        [StringLength(50)]
        public string nss { get; set; }

        public int? idMotivo { get; set; }

        public DateTime? fechaIngreso { get; set; }

        public DateTime? fechaNacimiento { get; set; }

        public int? idNomina { get; set; }

        public int? idContratante { get; set; }

        public int? idNegocio { get; set; }

        public int? idArea { get; set; }

        public int? idJerarquia { get; set; }

        [StringLength(50)]
        public string puesto { get; set; }

        [StringLength(50)]
        public string emailMacc { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string lada { get; set; }

        [StringLength(50)]
        public string num1 { get; set; }

        [StringLength(50)]
        public string cel1 { get; set; }

        [StringLength(10)]
        public string idBanco { get; set; }

        [StringLength(50)]
        public string cuentaBancaria { get; set; }

        [StringLength(50)]
        public string cuentaClabe { get; set; }

        public string direccion { get; set; }

        public int? idContrato { get; set; }

        public int? idTipoContrato { get; set; }

        [StringLength(50)]
        public string idEmpleadoJefe { get; set; }

        public double? sueldoBruto { get; set; }

        public double? sueldoNeto { get; set; }

        public double? sueldoTerceros { get; set; }

        [StringLength(50)]
        public string usrRegistro { get; set; }

        public DateTime? fechaRegistro { get; set; }

        [StringLength(50)]
        public string usrModifico { get; set; }

        public DateTime? fechaModifico { get; set; }

        public int? idEstatusEmpleado { get; set; }

        public int? idMotivoBaja { get; set; }

        public DateTime? fechaBaja { get; set; }

        [StringLength(50)]
        public string usrBaja { get; set; }

        public int? idUbicacion { get; set; }

        public int? idNacionalidad { get; set; }
    }
}
