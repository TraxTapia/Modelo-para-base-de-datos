namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("concentradox")]
    public partial class concentradox
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string codafiliado { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int correlativo { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string codestatus { get; set; }

        public int? No { get; set; }
    }
}
