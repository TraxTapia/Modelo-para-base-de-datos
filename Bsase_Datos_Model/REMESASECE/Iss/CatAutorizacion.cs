namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CatAutorizacion")]
    public partial class CatAutorizacion
    {
        [Key]
        [StringLength(5)]
        public string Clave { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(500)]
        public string Comentario { get; set; }
    }
}
