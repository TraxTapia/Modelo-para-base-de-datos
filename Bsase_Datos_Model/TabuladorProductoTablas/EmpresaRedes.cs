namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EmpresaRedes
    {
        public int Id { get; set; }

        public int? CodEmpresa { get; set; }

        public int? CodRed { get; set; }

        [StringLength(50)]
        public string xUsrInsert { get; set; }

        public DateTime? xDateInsert { get; set; }

        public int? codPlan { get; set; }

        [StringLength(20)]
        public string codProducto { get; set; }

        public int? Preferencia { get; set; }
    }
}
