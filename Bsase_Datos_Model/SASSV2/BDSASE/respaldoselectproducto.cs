namespace Bsase_Datos_Model.SASSV2.BDSASE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("respaldoselectproducto")]
    public partial class respaldoselectproducto
    {
        [Key]
        public int codcobertura { get; set; }

        public int? codselect { get; set; }

        [StringLength(20)]
        public string codproducto { get; set; }
    }
}
