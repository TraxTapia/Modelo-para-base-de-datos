namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductoDatosComplementarios
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string CodProducto { get; set; }

        public int? codTabulador { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codPlan { get; set; }

        public virtual tabuladores tabuladores { get; set; }
    }
}
