namespace Bsase_Datos_Model.Bases_De_Datos.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AutorizacionEspecial")]
    public partial class AutorizacionEspecial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AutorizacionEspecial()
        {
            AutorizacionEspecialDetalle = new HashSet<AutorizacionEspecialDetalle>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal IdAutorizaion { get; set; }

        [Required]
        [StringLength(1)]
        public string Autorizacion { get; set; }

        [Required]
        [StringLength(1)]
        public string CodTipoValidacion { get; set; }

        [Required]
        [StringLength(1)]
        public string xUsrInsert { get; set; }

        public DateTime xDateInsert { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutorizacionEspecialDetalle> AutorizacionEspecialDetalle { get; set; }
    }
}
