namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("centrosCostoSantander")]
    public partial class centrosCostoSantander
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string nomina { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int nseq { get; set; }

        [StringLength(50)]
        public string centrocosto { get; set; }
    }
}
