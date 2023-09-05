namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FirmasDocumentos
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ClaveFormato { get; set; }

        [Required]
        [StringLength(100)]
        public string Persona { get; set; }

        [Required]
        [StringLength(50)]
        public string Puesto { get; set; }

        [Required]
        [StringLength(255)]
        public string Correo { get; set; }

        [Required]
        [StringLength(50)]
        public string usu_alta { get; set; }

        public DateTime fecha_alta { get; set; }

        [Required]
        [StringLength(50)]
        public string usu_cambio { get; set; }

        public DateTime fecha_cambio { get; set; }
    }
}
