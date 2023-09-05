namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProvidersExceedsDays
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string CodeProvider { get; set; }

        [Required]
        [StringLength(50)]
        public string UserRegisterProvider { get; set; }

        public DateTime DateRegisterProvider { get; set; }

        [StringLength(50)]
        public string UserCancelationProvider { get; set; }

        public DateTime? DateCancelationProvider { get; set; }

        public bool Visible { get; set; }

        public virtual Recursos_Medicos Recursos_Medicos { get; set; }
    }
}
