namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Samiweb_Devoluciones_Email
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CodEstado { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string Zona { get; set; }

        [Key]
        [Column(Order = 3)]
        public string Correo { get; set; }

        [Key]
        [Column(Order = 4)]
        public string Cc { get; set; }

        public string Cco { get; set; }
    }
}
