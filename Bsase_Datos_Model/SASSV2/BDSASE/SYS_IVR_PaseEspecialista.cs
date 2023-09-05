namespace Bsase_Datos_Model.SASSV2.BDSASE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_IVR_PaseEspecialista
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        public int? Codempresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CodAfiliado { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int correlativo { get; set; }

        [StringLength(20)]
        public string Elegibilidad { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string PaseEspecialista { get; set; }

        [StringLength(255)]
        public string Clinica { get; set; }

        [StringLength(255)]
        public string xUsrInsert { get; set; }

        public int? codespecialidad { get; set; }

        public DateTime? xDateInsert { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodEstatus { get; set; }
    }
}
