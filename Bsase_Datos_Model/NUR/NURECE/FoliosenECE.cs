namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FoliosenECE")]
    public partial class FoliosenECE
    {
        [Key]
        [Column(Order = 0)]
        public string Elegibilidad { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime FechaCita { get; set; }

        [Key]
        [Column(Order = 2)]
        public string folio { get; set; }

        [Key]
        [Column(Order = 3)]
        public string Tipo { get; set; }

        [Key]
        [Column(Order = 4)]
        public string codAutorizacion { get; set; }
    }
}
