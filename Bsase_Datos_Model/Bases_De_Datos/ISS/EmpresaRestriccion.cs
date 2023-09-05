namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmpresaRestriccion")]
    public partial class EmpresaRestriccion
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CodRestriccion { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodEmpresa { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string CodAfiliado { get; set; }

        [Required]
        [StringLength(6)]
        public string Cveg_Permiso { get; set; }

        public DateTime? FechaIniVigencia { get; set; }

        public DateTime? FechaFinVigencia { get; set; }

        [StringLength(20)]
        public string UsuarioRegistro { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public virtual Empresa Empresa { get; set; }

        public virtual Restriccion Restriccion { get; set; }
    }
}
