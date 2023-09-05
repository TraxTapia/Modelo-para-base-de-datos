namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSFacturaXML_UUIDRelacionado
    {
        public int id { get; set; }

        [Required]
        [StringLength(40)]
        public string UUID { get; set; }

        [Required]
        [StringLength(40)]
        public string UUIDRelacionado { get; set; }

        [StringLength(5)]
        public string TipoRelacion { get; set; }

        public DateTime created_at { get; set; }
    }
}
