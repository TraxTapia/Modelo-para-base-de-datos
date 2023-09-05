namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecursosBansefi")]
    public partial class RecursosBansefi
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string no_fac { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string secuenciaMac { get; set; }

        public string ProvOrigen { get; set; }

        [StringLength(100)]
        public string Nomina { get; set; }

        public string nombre { get; set; }
    }
}
