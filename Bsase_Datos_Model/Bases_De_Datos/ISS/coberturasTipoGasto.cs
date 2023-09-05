namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coberturasTipoGasto")]
    public partial class coberturasTipoGasto
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codPlan { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codCobertura { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codTipoGasto { get; set; }

        public int? numeroEventos { get; set; }

        public int? deducible { get; set; }

        [StringLength(10)]
        public string coaseguro { get; set; }

        public double? copago { get; set; }

        public double? topeMonto { get; set; }
    }
}
