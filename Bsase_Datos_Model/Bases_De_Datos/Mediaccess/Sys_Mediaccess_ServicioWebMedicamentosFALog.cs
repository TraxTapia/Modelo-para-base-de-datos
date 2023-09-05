namespace Bsase_Datos_Model.Bases_De_Datos.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_ServicioWebMedicamentosFALog
    {
        public int id { get; set; }

        public DateTime? FechaAutorizacion { get; set; }

        public string Peticion { get; set; }

        public string Respuesta { get; set; }
    }
}
