namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.ElegibilidadesMI#")]
    public partial class ElegibilidadesMI_
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string autorizacion { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string codcuenta { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string codafiliado { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int correlativo { get; set; }

        public int? codempresa { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codautorizacion { get; set; }

        [StringLength(15)]
        public string xusrinsert { get; set; }

        public DateTime? xdateinsert { get; set; }

        [StringLength(10)]
        public string fechaRegistro { get; set; }
    }
}
