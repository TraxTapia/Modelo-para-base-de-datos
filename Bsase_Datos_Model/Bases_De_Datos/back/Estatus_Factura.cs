namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Estatus_Factura
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodStatusFactura { get; set; }

        [StringLength(50)]
        public string StatusFactura { get; set; }
    }
}
