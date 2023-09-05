namespace Bsase_Datos_Model.SASSV2.mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class planes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codPlan { get; set; }

        [StringLength(50)]
        public string descripcion { get; set; }
    }
}
