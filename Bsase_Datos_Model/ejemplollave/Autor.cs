namespace Bsase_Datos_Model.ejemplollave
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Autor")]
    public partial class Autor
    {
        public int Id { get; set; }

        [Required]
        [StringLength(4)]
        public string Nombre { get; set; }

        public int IdLibro { get; set; }

        public virtual Libro Libro { get; set; }
    }
}
