namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_LogSami
    {
        public int id { get; set; }

        [StringLength(100)]
        public string UserInsert { get; set; }

        public DateTime? DateInsert { get; set; }

        [StringLength(500)]
        public string Action { get; set; }
    }
}
