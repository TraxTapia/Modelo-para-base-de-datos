namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CuadroBasicoM")]
    public partial class CuadroBasicoM
    {
        [Key]
        [StringLength(255)]
        public string EAN { get; set; }

        public string sal { get; set; }

        [StringLength(450)]
        public string nombreComercial { get; set; }

        public string laboratorio { get; set; }

        [Column(TypeName = "money")]
        public decimal? pmp { get; set; }

        [StringLength(255)]
        public string controlado { get; set; }

        [StringLength(255)]
        public string tipo { get; set; }
    }
}
