namespace Bsase_Datos_Model.macmedi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SeguPerfil")]
    public partial class SeguPerfil
    {
        [Key]
        [StringLength(10)]
        public string CodPerfil { get; set; }

        [StringLength(50)]
        public string Perfil { get; set; }
    }
}
