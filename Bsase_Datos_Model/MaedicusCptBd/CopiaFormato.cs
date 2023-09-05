namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CopiaFormato")]
    public partial class CopiaFormato
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string CodFormato { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CodCopiaFormato { get; set; }

        [Column("CopiaFormato")]
        [Required]
        [StringLength(50)]
        public string CopiaFormato1 { get; set; }

        [StringLength(1)]
        public string CodVista { get; set; }

        [StringLength(10)]
        public string codTabulador { get; set; }
    }
}
