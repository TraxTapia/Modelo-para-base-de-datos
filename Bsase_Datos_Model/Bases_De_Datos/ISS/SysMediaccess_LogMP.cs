namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SysMediaccess_LogMP
    {
        public long Id { get; set; }

        [StringLength(100)]
        public string UserInsert { get; set; }

        public DateTime? FechaImpresion { get; set; }

        [StringLength(100)]
        public string Operacion { get; set; }

        [StringLength(50)]
        public string Formato { get; set; }

        [StringLength(20)]
        public string Poliza { get; set; }

        [StringLength(50)]
        public string codProducto { get; set; }
    }
}
