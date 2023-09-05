namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CondicionesGenerales
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Agrupacion { get; set; }

        [Required]
        [StringLength(100)]
        public string Archivo { get; set; }

        [Required]
        [StringLength(50)]
        public string Size { get; set; }

        public bool Activo { get; set; }
    }
}
