namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Oxxoceti")]
    public partial class Oxxoceti
    {
        [StringLength(255)]
        public string codafiliado { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int certi { get; set; }

        public int? orden { get; set; }

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
