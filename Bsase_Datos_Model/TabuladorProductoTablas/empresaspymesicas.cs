namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class empresaspymesicas
    {
        public int? CodEmpresa { get; set; }

        public int? codPlan { get; set; }

        public int? codPyme { get; set; }

        [StringLength(100)]
        public string nombreFiscal { get; set; }

        [StringLength(100)]
        public string nombreComercial { get; set; }

        [StringLength(50)]
        public string rfc { get; set; }

        public int? codEstatus { get; set; }

        public DateTime? fechaMovimiento { get; set; }

        public int Id { get; set; }
    }
}
