namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ResumenGasto")]
    public partial class ResumenGasto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codEmpresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string codAfiliado { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int correlativo { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string codProducto { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idTipoCobertura { get; set; }

        public decimal gastoReservado { get; set; }

        public decimal gastoReal { get; set; }

        public bool excede { get; set; }

        public DateTime creadoEn { get; set; }

        public DateTime? actualizadoEn { get; set; }

        public virtual TipoCobertura TipoCobertura { get; set; }
    }
}
