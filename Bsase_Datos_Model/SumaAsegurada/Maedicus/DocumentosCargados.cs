namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DocumentosCargados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocumentosCargados()
        {
            DocumentosCargadosEliminacionLog = new HashSet<DocumentosCargadosEliminacionLog>();
        }

        public int Id { get; set; }

        public int EnvioDocumentacion_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuarioCarga { get; set; }

        public DateTime FechaCarga { get; set; }

        [Required]
        [StringLength(100)]
        public string Archivo { get; set; }

        [Required]
        [StringLength(10)]
        public string FileSize { get; set; }

        public bool Activo { get; set; }

        public int TipoDocumento_Id { get; set; }

        public int NumeroSolicitud { get; set; }

        public virtual DOCUMENTACIONENVIO DOCUMENTACIONENVIO { get; set; }

        public virtual TipoDocumento TipoDocumento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentosCargadosEliminacionLog> DocumentosCargadosEliminacionLog { get; set; }
    }
}
