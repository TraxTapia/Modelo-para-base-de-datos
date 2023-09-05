namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_mediaccess_CatMensajes_ECE
    {
        public int id { get; set; }

        [StringLength(500)]
        public string Mensaje { get; set; }

        public int? idClave { get; set; }

        public int? Prioridad { get; set; }

        public bool? Activo { get; set; }

        public DateTime? xdateInsert { get; set; }

        [StringLength(50)]
        public string UsrInsert { get; set; }
    }
}
