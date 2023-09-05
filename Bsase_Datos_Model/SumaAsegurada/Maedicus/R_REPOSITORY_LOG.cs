namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mcpt.R_REPOSITORY_LOG")]
    public partial class R_REPOSITORY_LOG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_REPOSITORY_LOG { get; set; }

        [StringLength(255)]
        public string REP_VERSION { get; set; }

        public DateTime? LOG_DATE { get; set; }

        [StringLength(255)]
        public string LOG_USER { get; set; }

        [Column(TypeName = "text")]
        public string OPERATION_DESC { get; set; }
    }
}
