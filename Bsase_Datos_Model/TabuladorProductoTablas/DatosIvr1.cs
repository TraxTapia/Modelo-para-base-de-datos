namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dcorona.DatosIvr")]
    public partial class DatosIvr1
    {
        [Key]
        [StringLength(20)]
        public string Autorizacion { get; set; }

        [Required]
        [StringLength(50)]
        public string Numero { get; set; }

        [Required]
        [StringLength(50)]
        public string CodAfiliado { get; set; }

        public int CodParentesco { get; set; }
    }
}
