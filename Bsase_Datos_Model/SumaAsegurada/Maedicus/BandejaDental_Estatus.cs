namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BandejaDental_Estatus
    {
        [Key]
        [StringLength(50)]
        public string Folio { get; set; }

        [Required]
        [StringLength(50)]
        public string Elegibilidad { get; set; }

        [Required]
        public string Paciente { get; set; }

        [Required]
        public string NomTitular { get; set; }

        [Required]
        public string Parentesco { get; set; }

        [Required]
        public string Plan { get; set; }

        [Required]
        public string NombreEmpresa { get; set; }

        [Required]
        [StringLength(10)]
        public string Copago { get; set; }

        [Required]
        [StringLength(50)]
        public string cve_provMedico { get; set; }

        [Required]
        public string Medico { get; set; }

        [Required]
        [StringLength(50)]
        public string Especialidad { get; set; }

        [Required]
        [StringLength(50)]
        public string CedulaProfesional { get; set; }

        [Required]
        [StringLength(50)]
        public string Estatus { get; set; }

        [Required]
        public string requerimiento { get; set; }

        [Required]
        public string correo { get; set; }
    }
}
