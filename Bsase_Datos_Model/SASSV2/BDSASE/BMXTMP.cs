namespace Bsase_Datos_Model.SASSV2.BDSASE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BMXTMP")]
    public partial class BMXTMP
    {
        [Key]
        [StringLength(100)]
        public string EAN { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        [StringLength(100)]
        public string Autorizacion { get; set; }

        public int? codAutorizacion { get; set; }
    }
}
