namespace Bsase_Datos_Model.macmedi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.PasoCargaImpresion")]
    public partial class PasoCargaImpresion
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(152)]
        public string nombre { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string CodAfiliado { get; set; }

        public DateTime? FechaFinServicio { get; set; }

        [StringLength(8000)]
        public string cobertura { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int correlativo { get; set; }

        [StringLength(10)]
        public string codproductoaux { get; set; }

        public int? codcobertura { get; set; }
    }
}
