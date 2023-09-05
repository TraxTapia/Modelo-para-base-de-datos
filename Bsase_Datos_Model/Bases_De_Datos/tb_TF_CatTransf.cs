namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_TF_CatTransf
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string NombreBanco { get; set; }

        [StringLength(50)]
        public string cve_banco { get; set; }

        [StringLength(255)]
        public string Cve_tranfer { get; set; }
    }
}
