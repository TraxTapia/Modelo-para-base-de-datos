namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nomina#")]
    public partial class nomina_
    {
        [Key]
        [StringLength(12)]
        public string nomina { get; set; }
    }
}
