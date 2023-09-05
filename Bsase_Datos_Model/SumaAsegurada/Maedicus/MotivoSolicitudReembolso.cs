namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MotivoSolicitudReembolso")]
    public partial class MotivoSolicitudReembolso
    {
        public int Id { get; set; }

        public int ProcesoId { get; set; }

        [Required]
        [StringLength(150)]
        public string Descripcion { get; set; }
    }
}
