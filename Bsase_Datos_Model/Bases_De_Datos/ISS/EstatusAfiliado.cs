namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstatusAfiliado")]
    public partial class EstatusAfiliado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodEstatusAfiliado { get; set; }

        [Column("EstatusAfiliado")]
        [Required]
        [StringLength(50)]
        public string EstatusAfiliado1 { get; set; }

        [Required]
        [StringLength(1)]
        public string CodEstatus { get; set; }

        public virtual Estatus Estatus { get; set; }
    }
}
