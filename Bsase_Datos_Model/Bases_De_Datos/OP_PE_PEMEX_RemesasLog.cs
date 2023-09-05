namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OP_PE_PEMEX_RemesasLog
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string Remesa { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime F_Factura { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime F_Proceso { get; set; }

        public bool? Validacion { get; set; }

        public string MsgError { get; set; }
    }
}
