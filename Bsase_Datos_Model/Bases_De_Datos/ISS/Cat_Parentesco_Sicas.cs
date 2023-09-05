namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cat_Parentesco_Sicas
    {
        [Key]
        [Column(Order = 0)]
        public int autoid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string codvalor { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Descripcion { get; set; }

        [StringLength(2)]
        public string codEquivalencia { get; set; }
    }
}
