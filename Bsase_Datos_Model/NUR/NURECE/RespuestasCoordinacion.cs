namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RespuestasCoordinacion")]
    public partial class RespuestasCoordinacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RespCoordCve { get; set; }

        [StringLength(50)]
        public string RespCoorDescripcion { get; set; }

        [StringLength(50)]
        public string RespCoorNotas { get; set; }
    }
}
