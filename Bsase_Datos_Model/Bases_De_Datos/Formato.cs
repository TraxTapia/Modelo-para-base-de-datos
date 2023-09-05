namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mcpt.Formato")]
    public partial class Formato
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Formato()
        {
            CopiaFormato = new HashSet<CopiaFormato>();
        }

        [Key]
        [StringLength(2)]
        public string CodFormato { get; set; }

        [Column("Formato")]
        [Required]
        [StringLength(255)]
        public string Formato1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CopiaFormato> CopiaFormato { get; set; }
    }
}
