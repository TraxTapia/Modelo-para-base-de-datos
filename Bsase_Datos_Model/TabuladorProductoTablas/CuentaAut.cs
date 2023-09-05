namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CuentaAut")]
    public partial class CuentaAut
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string Autorizacion { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string CodCuenta { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string UsrUpdate { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "smalldatetime")]
        public DateTime FUpdate { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string IPupdate { get; set; }

        [StringLength(50)]
        public string UsrChange { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fchange { get; set; }

        [StringLength(20)]
        public string ipChange { get; set; }

        [StringLength(255)]
        public string MotivoRechazo { get; set; }

        [StringLength(255)]
        public string MotivoRechazo1 { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Estatus { get; set; }
    }
}
