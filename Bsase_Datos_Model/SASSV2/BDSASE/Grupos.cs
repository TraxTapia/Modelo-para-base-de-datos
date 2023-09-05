namespace Bsase_Datos_Model.SASSV2.BDSASE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Grupos
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codGrupo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string cve_empresa { get; set; }

        [StringLength(50)]
        public string descripcion { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool GenElegibilidad { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool GenAutorizacion { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCatCuadro { get; set; }
    }
}
