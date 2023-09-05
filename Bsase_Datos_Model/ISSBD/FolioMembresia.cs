namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FolioMembresia")]
    public partial class FolioMembresia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FolioMembresia()
        {
            FolioAfiliado = new HashSet<FolioAfiliado>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CodVendedor { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NoEntrega { get; set; }

        public DateTime FechaEntrega { get; set; }

        [Required]
        [StringLength(5)]
        public string InicioFolioMembresia { get; set; }

        [Required]
        [StringLength(6)]
        public string FinFolioMembresaia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FolioAfiliado> FolioAfiliado { get; set; }

        public virtual Vendedor Vendedor { get; set; }
    }
}
