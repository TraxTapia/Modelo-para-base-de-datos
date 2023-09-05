namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MotivoDetencion")]
    public partial class MotivoDetencion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodMotivoDetencion { get; set; }

        [Column("MotivoDetencion")]
        [StringLength(50)]
        public string MotivoDetencion1 { get; set; }
    }
}
