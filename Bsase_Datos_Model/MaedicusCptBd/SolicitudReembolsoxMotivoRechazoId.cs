namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SolicitudReembolsoxMotivoRechazoId")]
    public partial class SolicitudReembolsoxMotivoRechazoId
    {
        public int Id { get; set; }

        [StringLength(70)]
        public string Folio { get; set; }

        public int? MotivoReclamacionId { get; set; }
    }
}
