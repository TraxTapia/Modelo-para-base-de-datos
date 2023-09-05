namespace Bsase_Datos_Model.macmedi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoPersona")]
    public partial class TipoPersona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodTipoPersona { get; set; }

        [Column("TipoPersona")]
        [StringLength(50)]
        public string TipoPersona1 { get; set; }
    }
}
