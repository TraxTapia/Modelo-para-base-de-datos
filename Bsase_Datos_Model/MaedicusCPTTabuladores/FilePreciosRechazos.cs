namespace Bsase_Datos_Model.MaedicusCPTTabuladores
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FilePreciosRechazos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FilePreciosRechazos()
        {
            FilesByListaRechazos = new HashSet<FilesByListaRechazos>();
            TabuladorProveedorPreciosRechazos = new HashSet<TabuladorProveedorPreciosRechazos>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FileName { get; set; }

        public DateTime FechaCreacion { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilesByListaRechazos> FilesByListaRechazos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TabuladorProveedorPreciosRechazos> TabuladorProveedorPreciosRechazos { get; set; }
    }
}
