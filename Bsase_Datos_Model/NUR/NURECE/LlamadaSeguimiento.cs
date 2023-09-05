namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LlamadaSeguimiento")]
    public partial class LlamadaSeguimiento
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string CodTipoLlamada { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CodMotivoLlamada { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string CodServicio { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodMotivoQueja { get; set; }
    }
}
