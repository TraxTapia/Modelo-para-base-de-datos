namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.GastoCoberturasDetalleLog")]
    public partial class GastoCoberturasDetalleLog
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idLista { get; set; }

        public int? CodCuenta { get; set; }

        public int? CodTipoCuenta { get; set; }

        [StringLength(50)]
        public string CodEspecialidad { get; set; }

        [StringLength(50)]
        public string CodDiagnostico { get; set; }

        [StringLength(50)]
        public string CodProcedimiento { get; set; }

        [StringLength(2)]
        public string CopagoEN { get; set; }

        public double? Copago { get; set; }

        public int? Cantidad { get; set; }

        public double? PrecioUnitario { get; set; }

        public double? ImporteOp { get; set; }

        [StringLength(20)]
        public string Consecutivo { get; set; }

        public double? Total { get; set; }

        public double? TotalOp { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string xUsrInsert { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime xDateInsert { get; set; }
    }
}
