namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CatDocumentosAfiliado")]
    public partial class CatDocumentosAfiliado
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Clave { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        public int Tipo { get; set; }

        public bool Membrete { get; set; }

        public bool Obligatorio { get; set; }
    }
}
