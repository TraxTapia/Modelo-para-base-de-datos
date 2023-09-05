namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Login")]
    public partial class Login
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Login()
        {
            CargaArchivos = new HashSet<CargaArchivos>();
        }

        [Key]
        [StringLength(100)]
        public string SegLogin { get; set; }

        [Required]
        [StringLength(50)]
        public string SegPass { get; set; }

        public int CodPerfil { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [StringLength(1)]
        public string CodEstatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CargaArchivos> CargaArchivos { get; set; }

        public virtual Perfil Perfil { get; set; }
    }
}
