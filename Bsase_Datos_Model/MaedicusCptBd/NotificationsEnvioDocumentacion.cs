namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NotificationsEnvioDocumentacion")]
    public partial class NotificationsEnvioDocumentacion
    {
        public int Id { get; set; }

        public int EnvioDocumentacionStatus_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public bool Active { get; set; }

        public virtual EnvioDocumentacionStatus EnvioDocumentacionStatus { get; set; }
    }
}
