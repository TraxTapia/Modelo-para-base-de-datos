namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Afiliadosactualizacion_operaciones
    {
        public int? secuenciamac { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string nomina { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int numbenef { get; set; }

        [StringLength(50)]
        public string autorizacion { get; set; }

        [StringLength(50)]
        public string Elegibilidad { get; set; }
    }
}
