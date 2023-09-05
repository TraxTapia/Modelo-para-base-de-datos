namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class muestra_estatus
    {
        public int id { get; set; }

        [Column(TypeName = "text")]
        public string condiones { get; set; }

        [Column(TypeName = "text")]
        public string resultados { get; set; }

        public DateTime? fecha_creacion { get; set; }

        public byte? activo { get; set; }

        [StringLength(10)]
        public string comando { get; set; }

        [Column(TypeName = "text")]
        public string usuario_cambios { get; set; }
    }
}
