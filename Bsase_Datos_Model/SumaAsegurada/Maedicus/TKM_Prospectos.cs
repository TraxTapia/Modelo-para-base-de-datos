namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TKM_Prospectos
    {
        [Key]
        public int idProspecto { get; set; }

        [StringLength(300)]
        public string nombre { get; set; }

        [StringLength(150)]
        public string a_paterno { get; set; }

        [StringLength(300)]
        public string correo { get; set; }

        [StringLength(50)]
        public string telefono { get; set; }

        public int? id_agente { get; set; }

        public DateTime? fecha { get; set; }
    }
}
