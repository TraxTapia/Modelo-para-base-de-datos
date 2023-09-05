namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.temp2")]
    public partial class temp2
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(152)]
        public string nombre { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string codafiliado { get; set; }

        public DateTime? fechafin { get; set; }

        [StringLength(8000)]
        public string cob1 { get; set; }

        [StringLength(8000)]
        public string cob2 { get; set; }

        [StringLength(8000)]
        public string cob3 { get; set; }

        [StringLength(8000)]
        public string cob4 { get; set; }

        [StringLength(8000)]
        public string cob5 { get; set; }

        [StringLength(8000)]
        public string cob6 { get; set; }

        [StringLength(8000)]
        public string cob7 { get; set; }

        [StringLength(8000)]
        public string cob8 { get; set; }
    }
}
