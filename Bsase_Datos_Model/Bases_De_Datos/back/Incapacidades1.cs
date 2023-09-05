namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dcorona.Incapacidades")]
    public partial class Incapacidades1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodBandeja { get; set; }

        [StringLength(10)]
        public string CodDiagnostico { get; set; }

        [StringLength(100)]
        public string CodAfiliado { get; set; }

        public int? Correlativo { get; set; }

        public int? DiasIncapacidad { get; set; }

        public DateTime? FechaLlamada { get; set; }

        public DateTime? FechaFinIncapacidad { get; set; }
    }
}
