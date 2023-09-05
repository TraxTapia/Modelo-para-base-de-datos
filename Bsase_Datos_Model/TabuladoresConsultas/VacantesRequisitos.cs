namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VacantesRequisitos
    {
        public int Id { get; set; }

        public int Vacante_Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Requisito { get; set; }

        public bool Activo { get; set; }

        public virtual Vacantes Vacantes { get; set; }
    }
}
