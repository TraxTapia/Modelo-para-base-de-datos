namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_EmpresasFacturaAfiliado
    {
        public long id { get; set; }

        [StringLength(20)]
        public string cveEmpresa_Afiliado { get; set; }

        [StringLength(20)]
        public string cveEmpresa_Factura { get; set; }

        public int? codEmpresa { get; set; }

        public int? codPyme { get; set; }

        public bool? Activo { get; set; }

        [StringLength(50)]
        public string UsrAlta { get; set; }

        public DateTime? FechaAlta { get; set; }
    }
}
