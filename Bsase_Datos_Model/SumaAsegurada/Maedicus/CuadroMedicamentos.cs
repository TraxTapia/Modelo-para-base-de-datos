namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CuadroMedicamentos
    {
        public int Id { get; set; }

        public int IdCuadro { get; set; }

        [Required]
        [StringLength(250)]
        public string NombreCuadro { get; set; }
    }
}
