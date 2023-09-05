namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmpresasFacturaAfiliado")]
    public partial class EmpresasFacturaAfiliado
    {
        public long id { get; set; }

        [StringLength(20)]
        public string cveEmpresa_Afiliado { get; set; }

        [StringLength(20)]
        public string cveEmpresa_Factura { get; set; }

        public int? codempresa { get; set; }

        public int? codPyme { get; set; }

        public bool? Activo { get; set; }

        [StringLength(50)]
        public string UsrAlta { get; set; }

        public DateTime? FechaAlta { get; set; }
    }
}
