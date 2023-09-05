namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.ventasWSValidacion")]
    public partial class ventasWSValidacion
    {
        [Key]
        public int idVenta { get; set; }

        public int? consecutivo { get; set; }

        public DateTime? fechaInsert { get; set; }

        [StringLength(50)]
        public string codAfiliado { get; set; }

        public int? codEmpresa { get; set; }

        public int? codPyme { get; set; }

        [StringLength(50)]
        public string xusrInsert { get; set; }
    }
}
