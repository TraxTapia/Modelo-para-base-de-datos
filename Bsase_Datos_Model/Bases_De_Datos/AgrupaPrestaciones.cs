namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AgrupaPrestaciones
    {
        public int Id { get; set; }

        public int AgrupacionId { get; set; }

        public int codEmpresa { get; set; }

        [Required]
        [StringLength(25)]
        public string ProductoId { get; set; }

        public int ClinicaId { get; set; }
    }
}
