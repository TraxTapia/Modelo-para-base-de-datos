namespace Bsase_Datos_Model.BDMediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Respuesta_Coordinador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CveRespCoor { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        [StringLength(50)]
        public string Nota { get; set; }
    }
}
