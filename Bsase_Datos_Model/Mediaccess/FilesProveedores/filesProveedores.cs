 namespace Bsase_Datos_Model.Mediaccess.FilesProveedores
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class filesProveedores
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string NombreArchivo { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        [Required]
        public string Archivo { get; set; }

        public int IdCatFiles { get; set; }

        public bool? Activo { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public virtual CatArchivos CatArchivos { get; set; }
    }
}
