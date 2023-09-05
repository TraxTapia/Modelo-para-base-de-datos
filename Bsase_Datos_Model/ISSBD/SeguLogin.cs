namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SeguLogin")]
    public partial class SeguLogin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SeguLogin()
        {
            SeguSession = new HashSet<SeguSession>();
        }

        [Key]
        [StringLength(50)]
        public string CodLogin { get; set; }

        [Required]
        [StringLength(255)]
        public string ClaveAcceso { get; set; }

        [Required]
        [StringLength(1)]
        public string TipoUsuario { get; set; }

        public int CodPerfil { get; set; }

        public int CodPersona { get; set; }

        public virtual SeguPerfil SeguPerfil { get; set; }

        public virtual SeguPersona SeguPersona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeguSession> SeguSession { get; set; }
    }
}
