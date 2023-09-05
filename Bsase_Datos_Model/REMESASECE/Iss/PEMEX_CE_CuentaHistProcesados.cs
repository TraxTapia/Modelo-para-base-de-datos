namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PEMEX_CE_CuentaHistProcesados
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Autorizacion { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodCuenta { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string tipoMovimiento { get; set; }

        public DateTime? FechaProcesado { get; set; }
    }
}
