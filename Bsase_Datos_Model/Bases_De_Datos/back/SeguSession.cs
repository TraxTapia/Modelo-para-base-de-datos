namespace Bsase_Datos_Model.Bases_De_Datos.back
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
        [StringLength(100)]
        public string CodLogin { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(24)]
        public string CodSession { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string IPSession { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime InicioSession { get; set; }
    }
}
