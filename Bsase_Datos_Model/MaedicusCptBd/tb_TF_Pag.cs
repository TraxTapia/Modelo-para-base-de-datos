namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_TF_Pag
    {
        public DateTime? fecha { get; set; }

        [StringLength(50)]
        public string hora { get; set; }

        [StringLength(200)]
        public string suc { get; set; }

        [StringLength(200)]
        public string descripcion { get; set; }

        [StringLength(200)]
        public string cargo { get; set; }

        [StringLength(200)]
        public string abono { get; set; }

        [StringLength(200)]
        public string saldo { get; set; }

        [StringLength(200)]
        public string referencia { get; set; }

        [StringLength(500)]
        public string concepto { get; set; }

        [Key]
        [Column(Order = 0)]
        public DateTime xfecha { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Xuser { get; set; }
    }
}
