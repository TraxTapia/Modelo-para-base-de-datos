namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dtproperties
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? objectid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        public string property { get; set; }

        [StringLength(255)]
        public string value { get; set; }

        [StringLength(255)]
        public string uvalue { get; set; }

        [Column(TypeName = "image")]
        public byte[] lvalue { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int version { get; set; }
    }
}
