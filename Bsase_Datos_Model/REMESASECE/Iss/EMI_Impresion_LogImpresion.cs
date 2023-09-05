namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EMI_Impresion_LogImpresion
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodEmpresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CodAfiliado { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Correlativo { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(25)]
        public string CodProducto { get; set; }

        public int? codPlan { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(60)]
        public string UserImpresion { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime FechaImpresion { get; set; }
    }
}
