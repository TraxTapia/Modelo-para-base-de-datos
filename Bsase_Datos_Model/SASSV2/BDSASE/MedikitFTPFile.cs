namespace Bsase_Datos_Model.SASSV2.BDSASE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MedikitFTPFile")]
    public partial class MedikitFTPFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MedikitFTPFile()
        {
            MedikitFtpFileDetail = new HashSet<MedikitFtpFileDetail>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreArchivo { get; set; }

        public DateTime FechaProceso { get; set; }

        [Required]
        [StringLength(50)]
        public string UserInsert { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedikitFtpFileDetail> MedikitFtpFileDetail { get; set; }
    }
}
