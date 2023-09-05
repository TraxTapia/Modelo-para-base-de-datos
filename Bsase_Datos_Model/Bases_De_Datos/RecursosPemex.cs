namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecursosPemex")]
    public partial class RecursosPemex
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

        public int? secuenciaMac { get; set; }

        public string ProvOrigen { get; set; }

        [StringLength(100)]
        public string Nomina { get; set; }

        public string nombre { get; set; }

        public virtual Facturas Facturas { get; set; }
    }
}
