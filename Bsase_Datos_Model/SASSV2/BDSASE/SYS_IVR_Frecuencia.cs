namespace Bsase_Datos_Model.SASSV2.BDSASE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_IVR_Frecuencia
    {
        [Key]
        [Column(Order = 0)]
        public int IdPeriodo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string Nombre { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Frecuencia { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumEvento { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(7)]
        public string CodEvento { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Codempresa { get; set; }
    }
}
