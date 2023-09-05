namespace Bsase_Datos_Model.SASSV2.mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Grupo_Empresa
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodGrupo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CodEmpresa { get; set; }

        public DateTime? FechaAsignacion { get; set; }

        [StringLength(20)]
        public string xUsrInsert { get; set; }

        public DateTime? xDateInsert { get; set; }

        [StringLength(20)]
        public string xUsrUpdate { get; set; }

        public DateTime? xDateUpdate { get; set; }
    }
}
