namespace Bsase_Datos_Model.REMESASECE.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SeguLogin")]
    public partial class SeguLogin
    {
        [Key]
        public int CodFolio { get; set; }

        [StringLength(255)]
        public string CodLogin { get; set; }

        public int? CodPersona { get; set; }

        [StringLength(255)]
        public string CodPerfil { get; set; }

        [StringLength(255)]
        public string ClaveAcceso { get; set; }

        [StringLength(1)]
        public string TipoUsuario { get; set; }

        [StringLength(50)]
        public string xUsrInsert { get; set; }

        public DateTime? xDateInsert { get; set; }

        [StringLength(50)]
        public string xUsrUpdate { get; set; }

        public DateTime? xDateUpdate { get; set; }
    }
}
