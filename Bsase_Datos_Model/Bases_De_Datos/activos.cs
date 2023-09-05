namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class activos
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string cve_empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string nomina { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string nombre { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int numbenef { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(40)]
        public string parentesco { get; set; }

        public int? foliosdistinctos { get; set; }

        public int? cantidadServicios { get; set; }

        public double? importe { get; set; }
    }
}
