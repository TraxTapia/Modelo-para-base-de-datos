namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.temporal")]
    public partial class temporal
    {
        [Key]
        [StringLength(50)]
        public string codcuenta { get; set; }

        public DateTime? fecha { get; set; }

        [StringLength(15)]
        public string xusrinsert { get; set; }

        public int? Elegibilidades { get; set; }
    }
}
