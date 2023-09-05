namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AnotacionesExtras_LOG
    {
        [Key]
        [StringLength(30)]
        public string Folio { get; set; }

        [Column(TypeName = "ntext")]
        public string Concepto { get; set; }

        public int? CodPlan { get; set; }

        [StringLength(20)]
        public string CodProducto { get; set; }

        [Column(TypeName = "ntext")]
        public string Descripcion { get; set; }

        [StringLength(30)]
        public string FechaInsrt { get; set; }
    }
}
