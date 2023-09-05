namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ValidatedFilesLog")]
    public partial class ValidatedFilesLog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string CurrentUser { get; set; }

        public int RemittanceStatus_Id { get; set; }

        public DateTime DateLastChange { get; set; }

        public int ValidatedFiles_Id { get; set; }

        public virtual RemittanceStatus RemittanceStatus { get; set; }

        public virtual ValidatedFiles ValidatedFiles { get; set; }
    }
}
