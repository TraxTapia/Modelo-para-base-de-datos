namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Endosos_PDF
    {
        [Key]
        [Column(Order = 0)]
        public int Consecutivo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Endoso { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string Poliza { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(500)]
        public string NombreArchivo { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Codempresa { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string Codafiliado { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(20)]
        public string Correlativo { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool SN_Activo { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime FechaCarga { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string UsuarioCarga { get; set; }
    }
}
