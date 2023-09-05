namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mcpt.gastoTOtalLentes#")]
    public partial class gastoTOtalLentes_
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string TIPO { get; set; }

        public int? ANIO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string NOMINA { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(300)]
        public string TITULAR { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(300)]
        public string BENEFICIARIO { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(40)]
        public string PARENTESCO { get; set; }

        public double? ENE { get; set; }

        public double? FEB { get; set; }

        public double? MAR { get; set; }

        public double? ABR { get; set; }

        public double? MAY { get; set; }

        public double? JUN { get; set; }

        public double? JUL { get; set; }

        public double? AGO { get; set; }

        public double? SEP { get; set; }

        public double? OCT { get; set; }

        public double? NOV { get; set; }

        public double? DIC { get; set; }

        public double? TOTAL { get; set; }
    }
}
