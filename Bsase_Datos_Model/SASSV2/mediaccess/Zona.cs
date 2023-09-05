namespace Bsase_Datos_Model.SASSV2.mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Zona")]
    public partial class Zona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodZona { get; set; }

        [Column("Zona")]
        [StringLength(50)]
        public string Zona1 { get; set; }

        [StringLength(100)]
        public string Responsable { get; set; }
    }
}
