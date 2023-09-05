namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("metodoPago")]
    public partial class metodoPago
    {
        [Key]
        [StringLength(2)]
        public string metodo { get; set; }

        [Required]
        [StringLength(255)]
        public string descripcion { get; set; }
    }
}
