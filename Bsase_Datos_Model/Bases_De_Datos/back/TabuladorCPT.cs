namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TabuladorCPT")]
    public partial class TabuladorCPT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string cve_espec { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string CPT { get; set; }

        [Required]
        [StringLength(1)]
        public string CodEstatus { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codTabulador { get; set; }

        public DateTime fechaActualizacion { get; set; }
    }
}
