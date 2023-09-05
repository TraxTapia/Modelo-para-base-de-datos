namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CatErrores
    {
        [Key]
        public int IdError { get; set; }

        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }

        public bool Activo { get; set; }
    }
}
