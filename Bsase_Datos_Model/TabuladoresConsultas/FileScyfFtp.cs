namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FileScyfFtp")]
    public partial class FileScyfFtp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FileScyfFtp()
        {
            DetalleSCYF = new HashSet<DetalleSCYF>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreArchivo { get; set; }

        [Required]
        public string ContentFile { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(30)]
        public string Estatus { get; set; }

        [Required]
        [StringLength(50)]
        public string UserInsert { get; set; }

        public bool Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleSCYF> DetalleSCYF { get; set; }
    }
}
