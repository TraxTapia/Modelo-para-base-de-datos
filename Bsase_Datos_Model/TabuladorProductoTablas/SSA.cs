namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SSA")]
    public partial class SSA
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodEmpresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string CodAfiliado { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Correlativo { get; set; }

        [Required]
        [StringLength(100)]
        public string NoCuenta { get; set; }

        public int CodTipoPago { get; set; }

        public int CodBanco { get; set; }

        public int CodDivisa { get; set; }

        public virtual Banco Banco { get; set; }

        public virtual Divisa Divisa { get; set; }

        public virtual TipoPago TipoPago { get; set; }
    }
}
