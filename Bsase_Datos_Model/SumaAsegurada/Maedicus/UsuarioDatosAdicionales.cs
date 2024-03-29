namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UsuarioDatosAdicionales
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Afiliado { get; set; }

        public DateTime FechaNacimiento { get; set; }
    }
}
