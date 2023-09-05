namespace Bsase_Datos_Model.macmedi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class consultaElectronicaHSA_sase
    {
        [Key]
        [StringLength(20)]
        public string Elegibilidad { get; set; }

        [StringLength(20)]
        public string Folio { get; set; }

        public int? CodEmpresa { get; set; }

        [StringLength(50)]
        public string CodAfiliado { get; set; }

        public int? Correlativo { get; set; }

        [StringLength(50)]
        public string CodCuenta { get; set; }

        public int? CodFarmacia { get; set; }

        public int? IdMedicoTratante { get; set; }

        public double? Total { get; set; }

        [Column(TypeName = "ntext")]
        public string Observaciones { get; set; }

        public bool? IsExterno { get; set; }

        public bool? IsFactura { get; set; }

        public DateTime? xDateInsert { get; set; }

        public int? CodEstatus { get; set; }
    }
}
