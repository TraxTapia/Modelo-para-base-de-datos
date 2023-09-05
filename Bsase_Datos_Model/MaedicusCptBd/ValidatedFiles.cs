namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ValidatedFiles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ValidatedFiles()
        {
            ValidatedFileDetails = new HashSet<ValidatedFileDetails>();
            ValidatedFilesLog = new HashSet<ValidatedFilesLog>();
        }

        public int Id { get; set; }

        [StringLength(200)]
        public string FolioVal { get; set; }

        [Required]
        [StringLength(250)]
        public string Archivo { get; set; }

        public int Filas_Total { get; set; }

        public int Filas_OK { get; set; }

        public int Filas_Error { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario_Carga { get; set; }

        public bool Estatus { get; set; }

        [Column(TypeName = "money")]
        public decimal Total { get; set; }

        [Required]
        [StringLength(10)]
        public string CodeProvider { get; set; }

        public int RemittanceStatus_Id { get; set; }

        [StringLength(1000)]
        public string LeftOvers { get; set; }

        [StringLength(50)]
        public string no_fac { get; set; }

        [StringLength(10)]
        public string cve_empresa { get; set; }

        [StringLength(50)]
        public string CodTabulador { get; set; }

        [StringLength(4)]
        public string cve_espec { get; set; }

        public virtual RemittanceStatus RemittanceStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValidatedFileDetails> ValidatedFileDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValidatedFilesLog> ValidatedFilesLog { get; set; }
    }
}
