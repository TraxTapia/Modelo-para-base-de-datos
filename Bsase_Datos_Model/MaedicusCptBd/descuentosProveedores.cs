namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class descuentosProveedores
    {
        [Key]
        public int idDescuento { get; set; }

        [StringLength(50)]
        public string cve_prov { get; set; }

        [StringLength(50)]
        public string rfc { get; set; }

        public double? descto { get; set; }

        public DateTime? fechaInicio { get; set; }

        public DateTime? fechaFin { get; set; }

        public int? codEstatus { get; set; }

        public DateTime? fechaRegistro { get; set; }

        [StringLength(50)]
        public string cve_empresa { get; set; }
    }
}
