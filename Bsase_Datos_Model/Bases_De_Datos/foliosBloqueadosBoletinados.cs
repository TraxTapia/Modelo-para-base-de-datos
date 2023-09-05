namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class foliosBloqueadosBoletinados
    {
        public int id { get; set; }

        [StringLength(20)]
        public string folio { get; set; }

        public DateTime? fechaInsert { get; set; }

        [StringLength(50)]
        public string observaciones { get; set; }
    }
}
