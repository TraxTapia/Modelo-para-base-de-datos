namespace Bsase_Datos_Model.SASSV2.BDSASE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CartasWellnessInterno")]
    public partial class CartasWellnessInterno
    {
        [Required]
        [StringLength(50)]
        public string CodAfiliado { get; set; }

        [Key]
        [StringLength(20)]
        public string FolioInterno { get; set; }

        [Required]
        [StringLength(10)]
        public string Elegibilidad { get; set; }

        [Required]
        [StringLength(10)]
        public string Autorizacion { get; set; }

        public virtual CartasWellnessExterno CartasWellnessExterno { get; set; }
    }
}
