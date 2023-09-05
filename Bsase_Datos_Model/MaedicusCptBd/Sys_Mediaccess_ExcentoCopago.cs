namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_ExcentoCopago
    {
        public int id { get; set; }

        [StringLength(10)]
        public string cve_prov { get; set; }

        [StringLength(20)]
        public string UsrInsert { get; set; }

        public DateTime? DateInsert { get; set; }

        [StringLength(20)]
        public string UsrUpdate { get; set; }

        public DateTime? DateUpdate { get; set; }

        public bool? Activo { get; set; }
    }
}
