namespace Bsase_Datos_Model.BDMediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("formapago")]
    public partial class formapago
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codpago { get; set; }

        [StringLength(20)]
        public string tipopago { get; set; }
    }
}
