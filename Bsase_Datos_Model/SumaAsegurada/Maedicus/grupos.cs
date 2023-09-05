namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class grupos
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codGrupo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string cve_empresa { get; set; }

        [StringLength(50)]
        public string descripcion { get; set; }

        public int? codEmpresa { get; set; }
    }
}
