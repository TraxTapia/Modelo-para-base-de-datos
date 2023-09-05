namespace Bsase_Datos_Model.BDMediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.sumasporempresa#")]
    public partial class sumasporempresa_
    {
        [Key]
        [StringLength(100)]
        public string nombreempresa { get; set; }

        [StringLength(50)]
        public string autorizacion { get; set; }

        public int? Cantidad { get; set; }
    }
}
