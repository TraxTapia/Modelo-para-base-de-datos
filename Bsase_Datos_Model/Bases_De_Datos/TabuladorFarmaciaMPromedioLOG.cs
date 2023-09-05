namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TabuladorFarmaciaMPromedioLOG")]
    public partial class TabuladorFarmaciaMPromedioLOG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string PASO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string EAN { get; set; }

        [StringLength(255)]
        public string identificadorExtra { get; set; }

        public string sal { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(450)]
        public string nombreComercial { get; set; }

        public string laboratorio { get; set; }

        [StringLength(150)]
        public string descuento { get; set; }

        [Column(TypeName = "money")]
        public decimal? pmp { get; set; }

        [StringLength(255)]
        public string controlado { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int anioVigencia { get; set; }

        [StringLength(255)]
        public string keyWord { get; set; }

        [StringLength(255)]
        public string gravaIva { get; set; }

        [StringLength(255)]
        public string tipo { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "date")]
        public DateTime Fecha { get; set; }
    }
}
