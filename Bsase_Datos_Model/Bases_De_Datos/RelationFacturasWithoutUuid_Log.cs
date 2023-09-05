namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RelationFacturasWithoutUuid_Log
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string CurrentUser { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(36)]
        public string UUID { get; set; }

        public int SecuenciaMAC { get; set; }

        public bool Active { get; set; }

        public DateTime DateCancelation { get; set; }

        [Required]
        [StringLength(50)]
        public string CancelationUser { get; set; }
    }
}
