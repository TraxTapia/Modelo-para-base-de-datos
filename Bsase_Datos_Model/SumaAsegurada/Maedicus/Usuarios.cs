namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            Sami_Reportes_UsuariosCaptura = new HashSet<Sami_Reportes_UsuariosCaptura>();
        }

        [Key]
        [StringLength(100)]
        public string cve_usuario { get; set; }

        [Required]
        [StringLength(100)]
        public string nom_usuario { get; set; }

        [Required]
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sami_Reportes_UsuariosCaptura> Sami_Reportes_UsuariosCaptura { get; set; }
    }
}
