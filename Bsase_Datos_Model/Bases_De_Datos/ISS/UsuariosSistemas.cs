namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UsuariosSistemas
    {
        [Key]
        public int IdUsuariosistema { get; set; }

        [StringLength(100)]
        public string NombreUsuario { get; set; }

        [StringLength(100)]
        public string ApellidoPaternoUsuario { get; set; }

        [StringLength(100)]
        public string ApellidoMaternoUsuario { get; set; }

        [StringLength(200)]
        public string Puesto { get; set; }

        [StringLength(100)]
        public string NombreJefeInmediato { get; set; }

        [StringLength(100)]
        public string ApellidoPaternoJefeInmediato { get; set; }

        [StringLength(100)]
        public string ApellidoMaternoJefeInmediato { get; set; }

        public DateTime? FechaAltausuario { get; set; }

        [StringLength(100)]
        public string UsrAlta { get; set; }

        public DateTime? FechaBaja { get; set; }

        [StringLength(100)]
        public string UsrBaja { get; set; }

        [StringLength(500)]
        public string observaciones { get; set; }

        public bool? Status { get; set; }
    }
}
