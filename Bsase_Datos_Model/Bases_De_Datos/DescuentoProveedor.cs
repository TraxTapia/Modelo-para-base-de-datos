namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DescuentoProveedor")]
    public partial class DescuentoProveedor
    {
        [Key]
        [StringLength(150)]
        public string cve_prov { get; set; }

        public double? descuento { get; set; }
    }
}
