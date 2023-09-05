namespace Bsase_Datos_Model.REMESASECE.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServicioAusentismo")]
    public partial class ServicioAusentismo
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string CodServicio { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CodMotivo { get; set; }

        public virtual Servicio Servicio { get; set; }
    }
}
