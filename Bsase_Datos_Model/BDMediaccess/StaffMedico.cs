namespace Bsase_Datos_Model.BDMediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.StaffMedico")]
    public partial class StaffMedico
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodCuenta { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idMedico { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(150)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string CodTipoCuenta { get; set; }

        [StringLength(50)]
        public string CodEspecialidad { get; set; }

        [StringLength(50)]
        public string CodEstatus { get; set; }

        [StringLength(50)]
        public string RFC { get; set; }

        [StringLength(50)]
        public string CURP { get; set; }

        [StringLength(50)]
        public string CodBanco { get; set; }

        [StringLength(50)]
        public string CuentaBancaria { get; set; }

        [StringLength(50)]
        public string Clabe { get; set; }

        [StringLength(50)]
        public string Telefono1 { get; set; }

        [StringLength(50)]
        public string Telefono2 { get; set; }

        [StringLength(50)]
        public string Celular { get; set; }

        public string HorarioConsulta { get; set; }

        public string Consultorio { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string CedProfesional { get; set; }

        [StringLength(50)]
        public string CedEspecialidad { get; set; }

        [StringLength(50)]
        public string CedSubEspecialidad { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string xUsrInsert { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime xDateInsert { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string xUsrUpdate { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime xDateUpdate { get; set; }

        [StringLength(50)]
        public string CodSubEspecialidad { get; set; }
    }
}
