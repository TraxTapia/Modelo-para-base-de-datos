namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EnvioCorreosProcesos
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idProceso { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(500)]
        public string Correos { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool EnvioActivo { get; set; }
    }
}
