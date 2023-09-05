namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NuevoTabuladorFarmacia_R
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(150)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string EAN { get; set; }

        [StringLength(255)]
        public string identificadorExtra { get; set; }

        [StringLength(255)]
        public string sal { get; set; }

        [StringLength(255)]
        public string nombreComercial { get; set; }

        [StringLength(255)]
        public string laboratorio { get; set; }

        [StringLength(150)]
        public string descuento { get; set; }

        [Column(TypeName = "money")]
        public decimal? pmp { get; set; }

        [StringLength(255)]
        public string controlado { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mesVigencia { get; set; }

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
    }
}
