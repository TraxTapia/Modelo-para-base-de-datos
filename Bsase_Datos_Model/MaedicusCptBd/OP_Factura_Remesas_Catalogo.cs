namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OP_Factura_Remesas_Catalogo
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string CodEmp { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string Cve_empresa { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Estatus { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Proceso { get; set; }
    }
}
