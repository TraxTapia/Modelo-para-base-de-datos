namespace Bsase_Datos_Model.REMESASECE.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProcesaPagosCodigoBarras
    {
        [Key]
        [StringLength(50)]
        public string Autorizacion { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] CodigoBarras { get; set; }
    }
}