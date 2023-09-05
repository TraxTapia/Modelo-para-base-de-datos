namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TabuladorFarmaciaM_R
    {
        public int ID { get; set; }

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

        [StringLength(150)]
        public string diaVigencia { get; set; }

        [StringLength(150)]
        public string mesVigencia { get; set; }

        [StringLength(150)]
        public string anioVigencia { get; set; }

        public DateTime? fechaVigencia { get; set; }

        [StringLength(255)]
        public string keyWord { get; set; }

        [StringLength(255)]
        public string gravaIva { get; set; }

        [StringLength(255)]
        public string tipo { get; set; }

        [StringLength(100)]
        public string farmaco { get; set; }

        public string Rechazo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fmatchs { get; set; }

        public string Archivo { get; set; }

        public DateTime? Finsert { get; set; }
    }
}
