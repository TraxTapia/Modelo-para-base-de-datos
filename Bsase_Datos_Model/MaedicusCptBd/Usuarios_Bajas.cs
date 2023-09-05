namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios_Bajas
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string cve_usuario { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string nom_usuario { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string nivel { get; set; }

        [StringLength(25)]
        public string contrasena { get; set; }

        [StringLength(100)]
        public string spass { get; set; }

        public int? codGrupo { get; set; }

        public int? codEstatus { get; set; }

        public DateTime? fechaCreacion { get; set; }

        [StringLength(50)]
        public string usuarioCreo { get; set; }

        public DateTime? fechaModificacion { get; set; }

        [StringLength(50)]
        public string usuarioModifico { get; set; }

        public int? codGrupoCoordina { get; set; }

        public int? codCliente { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public int? codSI { get; set; }

        public int? CodEmpresa { get; set; }
    }
}
