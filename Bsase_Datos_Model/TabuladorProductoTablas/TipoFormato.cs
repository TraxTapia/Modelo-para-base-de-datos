namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoFormato")]
    public partial class TipoFormato
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoFormato()
        {
            FoliosFacturas = new HashSet<FoliosFacturas>();
        }

        [Key]
        [StringLength(2)]
        public string CodTipoFormato { get; set; }

        [Column("TipoFormato")]
        [Required]
        [StringLength(25)]
        public string TipoFormato1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FoliosFacturas> FoliosFacturas { get; set; }
    }
}
