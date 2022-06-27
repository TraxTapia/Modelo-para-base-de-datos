namespace Bsase_Datos_Model.MaedicusCPT_Web.FoliosReceta
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FoliosRecetas
    {
        public int id { get; set; }

        public int secuenciamac { get; set; }

        [Required]
        [StringLength(50)]
        public string folio { get; set; }

        public DateTime f_creacion { get; set; }

        public DateTime? f_baja { get; set; }

        public byte activo { get; set; }

        [Required]
        [StringLength(50)]
        public string seglogin { get; set; }
    }
}
