namespace Bsase_Datos_Model.SASSV2.mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Grupo")]
    public partial class Grupo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodGrupo { get; set; }

        [Column("Grupo")]
        [StringLength(50)]
        public string Grupo1 { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        [Column(TypeName = "text")]
        public string Observacion { get; set; }

        [StringLength(20)]
        public string xUsrInsert { get; set; }

        public DateTime? xDateInsert { get; set; }

        [StringLength(20)]
        public string xUsrUpdate { get; set; }

        public DateTime? xDateUpdate { get; set; }
    }
}
