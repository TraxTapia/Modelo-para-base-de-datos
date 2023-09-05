namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MotivoLlamada")]
    public partial class MotivoLlamada
    {
        [Key]
        [StringLength(10)]
        public string CodMotivoLlamada { get; set; }

        [Column("MotivoLlamada")]
        [StringLength(50)]
        public string MotivoLlamada1 { get; set; }

        [StringLength(100)]
        public string Codigo_Capacidad { get; set; }

        public bool Estatus { get; set; }
    }
}
