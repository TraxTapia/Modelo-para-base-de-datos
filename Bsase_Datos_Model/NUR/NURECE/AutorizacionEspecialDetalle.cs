namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AutorizacionEspecialDetalle")]
    public partial class AutorizacionEspecialDetalle
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal IdDetalle { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal IdAutorizaion { get; set; }

        [Required]
        [StringLength(1)]
        public string MensajeValidacion { get; set; }

        public virtual AutorizacionEspecial AutorizacionEspecial { get; set; }
    }
}
