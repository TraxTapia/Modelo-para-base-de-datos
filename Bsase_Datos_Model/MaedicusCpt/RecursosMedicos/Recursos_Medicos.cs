namespace Bsase_Datos_Model.MaedicusCpt.RecursosMedicos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Recursos_Medicos
    {
        [Key]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Required]
        [StringLength(50)]
        public string RFC { get; set; }

        [Required]
        [StringLength(200)]
        public string RecursoMedico { get; set; }

        [Required]
        [StringLength(4)]
        public string cve_espec { get; set; }

        [Required]
        [StringLength(2)]
        public string Estatus { get; set; }

        [Required]
        [StringLength(300)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(5)]
        public string CodEstado { get; set; }

        public int CodPoblacion { get; set; }

        [StringLength(50)]
        public string clabe { get; set; }

        [StringLength(50)]
        public string Cuenta { get; set; }

        [StringLength(50)]
        public string Sucursal { get; set; }

        [Required]
        [StringLength(25)]
        public string SegLogin { get; set; }

        [StringLength(1000)]
        public string email { get; set; }

        [StringLength(50)]
        public string lada { get; set; }

        [StringLength(50)]
        public string telefono { get; set; }

        [StringLength(50)]
        public string apellidoPaterno { get; set; }

        [StringLength(50)]
        public string apellidoMaterno { get; set; }

        [StringLength(50)]
        public string nombres { get; set; }

        [StringLength(200)]
        public string nombreComercial { get; set; }

        [StringLength(200)]
        public string nombreFiscal { get; set; }

        public DateTime? fechaBaja { get; set; }
    }
}
