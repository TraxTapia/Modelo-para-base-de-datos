namespace Bsase_Datos_Model.macmedi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class filesProveedores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public filesProveedores()
        {
            DocumentosPorAplicacion = new HashSet<DocumentosPorAplicacion>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string NombreArchivo { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Required]
        public string Archivo { get; set; }

        public int IdCatFiles { get; set; }

        public bool Activo { get; set; }

        public DateTime FechaRegistro { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public virtual CatArchivos CatArchivos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentosPorAplicacion> DocumentosPorAplicacion { get; set; }
    }
}
