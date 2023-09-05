namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CatMunicipio")]
    public partial class CatMunicipio
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string cve_ent { get; set; }

        [StringLength(255)]
        public string cve_mun { get; set; }

        [StringLength(255)]
        public string nom_mun { get; set; }
    }
}
