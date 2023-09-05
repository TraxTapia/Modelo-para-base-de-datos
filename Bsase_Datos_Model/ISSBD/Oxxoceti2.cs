namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Oxxoceti2
    {
        [StringLength(255)]
        public string codafiliado { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int certi { get; set; }

        public long? orden { get; set; }

        [StringLength(255)]
        public string poliza { get; set; }

        public int? Folio { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Existecerti { get; set; }

        [Key]
        [Column(Order = 2)]
        public int Autoid { get; set; }
    }
}
