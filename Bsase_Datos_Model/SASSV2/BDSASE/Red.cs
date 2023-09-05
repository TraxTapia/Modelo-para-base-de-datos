namespace Bsase_Datos_Model.SASSV2.BDSASE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Red")]
    public partial class Red
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodRed { get; set; }

        [Key]
        [Column("Red", Order = 1)]
        [StringLength(50)]
        public string Red1 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string NombreLargo { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string xUsrInsert { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime xDateInsert { get; set; }

        [StringLength(20)]
        public string xUsrUpdate { get; set; }

        public DateTime? xDateUpdate { get; set; }

        public int? codEstatusRed { get; set; }
    }
}
