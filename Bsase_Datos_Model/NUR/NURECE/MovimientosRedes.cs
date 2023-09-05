namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.MovimientosRedes")]
    public partial class MovimientosRedes
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CodCuenta { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string xUsrInsert { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime xDateAction { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string TipoAccion { get; set; }

        [Column(TypeName = "text")]
        public string Observaciones { get; set; }
    }
}
