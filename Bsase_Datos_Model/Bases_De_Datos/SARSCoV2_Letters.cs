namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SARSCoV2_Letters
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string CodeProvider { get; set; }

        [Required]
        [StringLength(20)]
        public string CodeConcept { get; set; }

        public bool Visible { get; set; }

        public virtual Recursos_Medicos Recursos_Medicos { get; set; }
    }
}
