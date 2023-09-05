namespace Bsase_Datos_Model.SASSV2.mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MotivoQueja")]
    public partial class MotivoQueja
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodMotivoQueja { get; set; }

        [Column("MotivoQueja")]
        [StringLength(50)]
        public string MotivoQueja1 { get; set; }
    }
}
