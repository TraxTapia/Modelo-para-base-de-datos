namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstatusFolio")]
    public partial class EstatusFolio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstatusFolio()
        {
            FoliosFacturas = new HashSet<FoliosFacturas>();
        }

        [Key]
        [StringLength(1)]
        public string CodEstatusFolio { get; set; }

        [Column("EstatusFolio")]
        [Required]
        [StringLength(50)]
        public string EstatusFolio1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FoliosFacturas> FoliosFacturas { get; set; }
    }
}
