namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("generacionOrdenPago")]
    public partial class generacionOrdenPago
    {
        public int id { get; set; }

        [StringLength(10)]
        public string cve_prov { get; set; }

        [StringLength(50)]
        public string remesa { get; set; }

        [StringLength(50)]
        public string no_fac { get; set; }

        public int? secuenciamac { get; set; }

        public double? total { get; set; }

        public DateTime? fecha { get; set; }

        [StringLength(15)]
        public string usr { get; set; }

        [StringLength(50)]
        public string ordenPago { get; set; }

        public int? codEstatus { get; set; }
    }
}
