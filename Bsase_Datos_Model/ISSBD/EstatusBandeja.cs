namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstatusBandeja")]
    public partial class EstatusBandeja
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodEstatusBandeja { get; set; }

        [Column("EstatusBandeja")]
        [Required]
        [StringLength(25)]
        public string EstatusBandeja1 { get; set; }
    }
}
