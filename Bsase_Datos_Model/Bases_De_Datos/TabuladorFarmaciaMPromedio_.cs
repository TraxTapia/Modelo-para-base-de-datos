namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TabuladorFarmaciaMPromedio#")]
    public partial class TabuladorFarmaciaMPromedio_
    {
        [Key]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FMedi { get; set; }
    }
}
