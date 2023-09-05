namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_SAE_PadronLog_
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(150)]
        public string archivo { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime F_Archivo { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string tipo { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime fechacarga { get; set; }

        [StringLength(50)]
        public string usuario { get; set; }

        public int? Registros { get; set; }
    }
}
