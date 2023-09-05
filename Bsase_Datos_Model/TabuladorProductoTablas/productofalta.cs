namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("productofalta")]
    public partial class productofalta
    {
        [Key]
        [StringLength(25)]
        public string codproducto { get; set; }
    }
}
