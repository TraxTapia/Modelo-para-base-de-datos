namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProvidersWithoutCopay")]
    public partial class ProvidersWithoutCopay
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string CodeProvider { get; set; }

        public bool Active { get; set; }

        public virtual Recursos_Medicos Recursos_Medicos { get; set; }
    }
}
