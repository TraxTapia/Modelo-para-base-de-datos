namespace Bsase_Datos_Model.BDMediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_EDO_HSBC
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idHSBC { get; set; }

        [StringLength(50)]
        public string idMAC { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Estado { get; set; }
    }
}
