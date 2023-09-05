namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOCUMENTACIONENVIO")]
    public partial class DOCUMENTACIONENVIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOCUMENTACIONENVIO()
        {
            DOCUMENTACIONENVIODETALLES = new HashSet<DOCUMENTACIONENVIODETALLES>();
            DocumentosCargados = new HashSet<DocumentosCargados>();
            EnvioDocumentacionMovimientos = new HashSet<EnvioDocumentacionMovimientos>();
            DOCUMENTACIONENVIOCORREO = new HashSet<DOCUMENTACIONENVIOCORREO>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string OT { get; set; }

        [Required]
        [StringLength(100)]
        public string archivo { get; set; }

        public DateTime? fecha_Envio { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuCambio { get; set; }

        public DateTime FechaCambio { get; set; }

        public bool Credenciales { get; set; }

        public int? EnvioStatus_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOCUMENTACIONENVIODETALLES> DOCUMENTACIONENVIODETALLES { get; set; }

        public virtual EnvioDocumentacionStatus EnvioDocumentacionStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentosCargados> DocumentosCargados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnvioDocumentacionMovimientos> EnvioDocumentacionMovimientos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOCUMENTACIONENVIOCORREO> DOCUMENTACIONENVIOCORREO { get; set; }
    }
}
