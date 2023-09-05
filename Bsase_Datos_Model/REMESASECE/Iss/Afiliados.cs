namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Afiliados
    {
        [Key]
        public int AfiliadoID { get; set; }

        public int? CodEmpresa { get; set; }

        [StringLength(200)]
        public string CodAfiliado { get; set; }

        public int? Correlativo { get; set; }

        public int? CodEstatusAfiliado { get; set; }
    }
}
