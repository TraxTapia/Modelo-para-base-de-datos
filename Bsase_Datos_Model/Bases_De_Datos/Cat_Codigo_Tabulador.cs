namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cat_Codigo_Tabulador
    {
        [Key]
        [StringLength(50)]
        public string CodTabulador { get; set; }

        [StringLength(30)]
        public string Descripcion { get; set; }

        public DateTime? FECHA_USO { get; set; }
    }
}
