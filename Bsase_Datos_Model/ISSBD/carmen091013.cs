namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.carmen091013")]
    public partial class carmen091013
    {
        [Key]
        [StringLength(20)]
        public string folio { get; set; }

        public int? contador { get; set; }
    }
}
