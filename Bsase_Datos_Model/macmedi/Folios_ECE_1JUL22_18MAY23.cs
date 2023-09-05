namespace Bsase_Datos_Model.macmedi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Folios_ECE_1JUL22_18MAY23
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Elegibilidad { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "datetime2")]
        public DateTime FechaCita { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string folio { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Tipo { get; set; }

        [StringLength(50)]
        public string codAutorizacion { get; set; }
    }
}
