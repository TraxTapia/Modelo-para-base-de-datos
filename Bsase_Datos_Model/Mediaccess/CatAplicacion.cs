namespace Bsase_Datos_Model.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CatAplicacion")]
    public partial class CatAplicacion
    {
        [Key]
        public int IdAplicacion { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }
    }
}
