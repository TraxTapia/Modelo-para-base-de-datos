namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_SICAS_Endosos
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Consecutivo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string CodAfiliado { get; set; }

        public string Exclusion { get; set; }
    }
}
