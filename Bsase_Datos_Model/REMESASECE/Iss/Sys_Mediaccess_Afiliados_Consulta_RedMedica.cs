namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_Afiliados_Consulta_RedMedica
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string AfiliadoComodin { get; set; }

        [StringLength(50)]
        public string codproducto { get; set; }

        public DateTime? xDateInsert { get; set; }

        [StringLength(50)]
        public string UsrInsert { get; set; }

        public DateTime? xDateUpdate { get; set; }

        [StringLength(50)]
        public string UsrUpdate { get; set; }

        public bool? Activo { get; set; }

        public int? codEmpresa { get; set; }
    }
}
