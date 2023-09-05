namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SamiEstado")]
    public partial class SamiEstado
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string CodEstado { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [Required]
        [StringLength(2)]
        public string CodZona { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codTabulador { get; set; }

        public DateTime fechaActualizacion { get; set; }
    }
}
