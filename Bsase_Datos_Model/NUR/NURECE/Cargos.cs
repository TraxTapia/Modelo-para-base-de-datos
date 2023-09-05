namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cargos
    {
        [Key]
        public int IdCargo { get; set; }

        [StringLength(50)]
        public string Cargo { get; set; }
    }
}
