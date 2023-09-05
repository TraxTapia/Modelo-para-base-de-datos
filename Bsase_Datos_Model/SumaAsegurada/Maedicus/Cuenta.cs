namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cuenta")]
    public partial class Cuenta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodCuenta { get; set; }

        [StringLength(10)]
        public string CodTipoCuenta { get; set; }

        public int? CodBanco { get; set; }

        [StringLength(10)]
        public string CodEspecialidad { get; set; }

        [StringLength(10)]
        public string CodMetodoPago { get; set; }

        [StringLength(10)]
        public string SubEspecialidad { get; set; }

        [StringLength(10)]
        public string Numero { get; set; }

        [StringLength(1)]
        public string CodTipoPersona { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string RestoNombre { get; set; }

        [StringLength(255)]
        public string NombreCompleto { get; set; }

        [StringLength(50)]
        public string ApellidoP { get; set; }

        [StringLength(50)]
        public string ApellidoM { get; set; }

        [StringLength(50)]
        public string Nombres { get; set; }

        [StringLength(50)]
        public string CURP { get; set; }

        [StringLength(20)]
        public string RFC { get; set; }

        public int? IVAporcentaje { get; set; }

        public int? RetencionISR { get; set; }

        public int? RetencionIVA { get; set; }

        public DateTime? FechaProceso { get; set; }

        [StringLength(1)]
        public string flgIguala { get; set; }

        public double? ImporteIguala { get; set; }

        [StringLength(50)]
        public string CedulaProfesional { get; set; }

        [StringLength(50)]
        public string CuentaBancaria { get; set; }

        [StringLength(50)]
        public string Clabe { get; set; }

        [Column(TypeName = "text")]
        public string Observacion { get; set; }

        [StringLength(1)]
        public string CodEstatusCuenta { get; set; }

        [StringLength(20)]
        public string xUsrInsert { get; set; }

        [StringLength(20)]
        public string xDateInsert { get; set; }

        [StringLength(20)]
        public string xUsrUpdate { get; set; }

        [StringLength(20)]
        public string xDateUpdate { get; set; }

        public double? Descuento { get; set; }

        public double? precioservicio { get; set; }

        [StringLength(25)]
        public string SGLogin { get; set; }

        [StringLength(255)]
        public string SGPassword { get; set; }

        public double? DescuentoMembresia { get; set; }

        public double? PrecioServicioMembresia { get; set; }

        public int? ExaMedico { get; set; }

        [StringLength(50)]
        public string cedEspecialidad { get; set; }

        [StringLength(50)]
        public string certificacion { get; set; }

        public int? prioridad { get; set; }

        public DateTime? FechaCertificacion { get; set; }
    }
}
