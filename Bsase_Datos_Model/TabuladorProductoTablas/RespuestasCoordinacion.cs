namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dcorona.RespuestasCoordinacion")]
    public partial class RespuestasCoordinacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CveRespCoordinacion { get; set; }

        [StringLength(50)]
        public string DescripcionRespCoordinacion { get; set; }

        [StringLength(50)]
        public string Notas { get; set; }
    }
}
