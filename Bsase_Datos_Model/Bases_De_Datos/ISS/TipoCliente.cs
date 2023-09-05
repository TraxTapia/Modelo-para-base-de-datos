namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoCliente")]
    public partial class TipoCliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodTipoCliente { get; set; }

        [Column("TipoCliente")]
        [Required]
        [StringLength(50)]
        public string TipoCliente1 { get; set; }
    }
}
