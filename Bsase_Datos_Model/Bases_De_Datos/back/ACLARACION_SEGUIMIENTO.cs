namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACLARACION_SEGUIMIENTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int folio { get; set; }

        [StringLength(20)]
        public string usuario { get; set; }

        [StringLength(1000)]
        public string seguimiento { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha { get; set; }
    }
}
