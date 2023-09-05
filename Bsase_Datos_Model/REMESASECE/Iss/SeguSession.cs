namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SeguSession")]
    public partial class SeguSession
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CodLogin { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(24)]
        public string CodSession { get; set; }

        [Required]
        [StringLength(15)]
        public string IPSession { get; set; }

        public DateTime InicioSession { get; set; }

        public virtual SeguLogin SeguLogin { get; set; }
    }
}
