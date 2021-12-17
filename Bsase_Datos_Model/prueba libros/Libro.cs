namespace Bsase_Datos_Model.prueba_libros
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Libro")]
    public partial class Libro
    {
        public int Id { get; set; }

        [Required]
        [StringLength(4)]
        public string NombreLibro { get; set; }

        public int IdAutor { get; set; }

        public virtual Autor Autor { get; set; }
    }
}
