namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Estado")]
    public partial class Estado
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string CodEstado { get; set; }

        [Column("Estado")]
        [Required]
        [StringLength(50)]
        public string Estado1 { get; set; }

        [Required]
        [StringLength(2)]
        public string CodZona { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codTabulador { get; set; }
    }
}
