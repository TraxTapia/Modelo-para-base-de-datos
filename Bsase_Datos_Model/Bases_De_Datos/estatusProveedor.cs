namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estatusProveedor")]
    public partial class estatusProveedor
    {
        [Key]
        [StringLength(50)]
        public string codEstatusProveedor { get; set; }

        [Column("estatusProveedor")]
        [StringLength(50)]
        public string estatusProveedor1 { get; set; }
    }
}
