namespace Bsase_Datos_Model.Red
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodRed { get; set; }

        [Column("Red")]
        [StringLength(50)]
        public string Red1 { get; set; }

        [StringLength(100)]
        public string NombreLargo { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        [Column(TypeName = "text")]
        public string Observacion { get; set; }

        [StringLength(50)]
        public string xUsrInsert { get; set; }

        public DateTime? xDateInsert { get; set; }

        [StringLength(50)]
        public string xUsrUpdate { get; set; }

        public DateTime? xDateUpdate { get; set; }

        public int? codEstatusRed { get; set; }
    }
}
