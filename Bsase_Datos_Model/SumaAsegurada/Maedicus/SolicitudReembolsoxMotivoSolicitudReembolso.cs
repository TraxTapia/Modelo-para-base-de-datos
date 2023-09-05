namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SolicitudReembolsoxMotivoSolicitudReembolso")]
    public partial class SolicitudReembolsoxMotivoSolicitudReembolso
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Folio { get; set; }

        public int MotivoSolicitudReembolsoId { get; set; }
    }
}
