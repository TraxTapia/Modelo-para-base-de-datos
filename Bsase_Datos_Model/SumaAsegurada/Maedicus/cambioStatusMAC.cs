namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cambioStatusMAC")]
    public partial class cambioStatusMAC
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int secuenciaMac { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(150)]
        public string status { get; set; }

        [StringLength(20)]
        public string statusReal { get; set; }
    }
}
