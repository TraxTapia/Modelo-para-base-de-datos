namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RolConceptosEmpresas
    {
        public int id { get; set; }

        [Required]
        [StringLength(12)]
        public string cve_empresa { get; set; }

        public int idRol { get; set; }

        public bool estatus { get; set; }
    }
}
