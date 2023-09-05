namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("catLugaresIngreso")]
    public partial class catLugaresIngreso
    {
        [Key]
        public int lugIngrId { get; set; }

        [StringLength(40)]
        public string lugIngrCode { get; set; }

        [StringLength(95)]
        public string lugIngrDesc { get; set; }
    }
}
