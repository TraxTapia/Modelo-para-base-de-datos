namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TabuladorFarmaciaM_log
    {
        public int? ID { get; set; }

        [StringLength(150)]
        public string cve_prov { get; set; }

        [StringLength(255)]
        public string EAN { get; set; }

        [StringLength(255)]
        public string identificadorExtra { get; set; }

        public string sal { get; set; }

        public string nombreComercial { get; set; }

        public string laboratorio { get; set; }

        [StringLength(150)]
        public string descuento { get; set; }

        [Column(TypeName = "money")]
        public decimal? pmp { get; set; }

        [StringLength(255)]
        public string controlado { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int diaVigencia { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mesVigencia { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int anioVigencia { get; set; }

        public DateTime? fechaVigencia { get; set; }

        [StringLength(255)]
        public string keyWord { get; set; }

        [StringLength(255)]
        public string gravaIva { get; set; }

        [StringLength(255)]
        public string tipo { get; set; }

        [StringLength(100)]
        public string farmaco { get; set; }

        [StringLength(2)]
        public string codTabulador { get; set; }

        [StringLength(100)]
        public string xUsrInsertEvento { get; set; }

        public DateTime? xDateInsertEvento { get; set; }

        public int? Codevento { get; set; }
    }
}
