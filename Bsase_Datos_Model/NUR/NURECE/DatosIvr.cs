namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dcorona.DatosIvr")]
    public partial class DatosIvr
    {
        [Required]
        [StringLength(20)]
        public string Autorizacion { get; set; }

        [Required]
        [StringLength(50)]
        public string Numero { get; set; }

        [Required]
        [StringLength(50)]
        public string CodAfiliado { get; set; }

        public int CodParentesco { get; set; }

        public int? codEmpresa { get; set; }

        public int? control { get; set; }

        public DateTime? fechaVerificacion { get; set; }

        public int Id { get; set; }
    }
}
